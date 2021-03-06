﻿
namespace Vista
{
    using Datos;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Excel = Microsoft.Office.Interop.Excel;
    using Word = Microsoft.Office.Interop.Word;
    using PowerPoint = Microsoft.Office.Interop.PowerPoint;
    using Preguntas;
    using System.Diagnostics;
    using System.IO;

    public partial class FormQuestionsPanel : Form
    {
        #region atributes
        Screen screenExcel = Screen.PrimaryScreen;
        Screen screenPowerPoint = Screen.PrimaryScreen;

        int[] arrayOrdenPreguntas;
        int contadorDeAvance;//para navegar en el arrray de preguntas
        int preguntasResueltas; //para el avance de preguntas resueltas 
        string rutaPregunta;//rrellena el path segun el examen seleccionado

        Excel.Application ObjExcel;
        //Excel.Worksheet wsheet;
        Excel.Workbook wbook;

        PowerPoint.Application ObjPowerPoint;
        //PowerPoint.Presentations ppts;
        PowerPoint.Presentation ppt;

        Word.Application ObjWord;
        Word.Document doc;

        int examenIdExamen;
        string ExamenSeleccionado;

        Process[] excelProcsOld;//para capturar todos los excel abiertos antes de iniciar el programa
        Process[] wordProcsOld;//para capturar todos los Word abiertos antes de iniciar el programa
        Process[] powerPointProcOld;

        bool guardarCorrecto= false;
        #endregion

        public FormQuestionsPanel()
        {
            InitializeComponent();
        }

        #region Events
        private void FormQuestionsPanel_Load(object sender, EventArgs e)
        {
            excelProcsOld = Process.GetProcessesByName("EXCEL");
            wordProcsOld = Process.GetProcessesByName("WINWORD");
            powerPointProcOld = Process.GetProcessesByName("POWERPNT");

            ExamenSeleccionado = FormMain.ExamenSeleccionado;            
            examenIdExamen = FormMain.idExamenActual;

            CargarArrayOrdenPreguntas();
            ObtenerContadorDeAvance();
            RellenarLabelPregunta();
            MostrarPreguntaYEjercicio();            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            if (this.preguntasResueltas < FormMain.NUMERO_DE_PREGUNTAS)
            {
                ComprobarCorrectoIncorrecto(sender, e);
                if (guardarCorrecto)
                {
                    GuardarAvance();
                    RellenarLabelPregunta();    //rellenar label antes de MostrarPreguntaYEjercicio ya que el contador cambia;
                    MostrarPreguntaYEjercicio();     
                    guardarCorrecto = false;
                }
            }
            else
            {
                ComprobarCorrectoIncorrecto(sender, e);
                if (guardarCorrecto)
                {
                    GuardarAvance();
                    guardarCorrecto = false;
                }

                FormMain.formExamResult.Show();
                FormMain.formExamResult.Activate();
                this.Hide();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            //cerrar los archivos abiertos
            
            int numeroDePregunta = arrayOrdenPreguntas[contadorDeAvance - 1]; // - 1
            switch (ExamenSeleccionado)
            {
                case "Word":
                    CerrarWords();
                    AbrirEjercicioWord(numeroDePregunta);
                    break;
                case "Excel":
                    CerrarExcels();
                    AbrirEjercicioExcel(numeroDePregunta);
                    break;
                case "Power Point":
                    CerrarPowerPoints();
                    AbrirEjercicioPowerPoint(numeroDePregunta);
                    break;
            }

        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            TxtQuestion.Visible = !TxtQuestion.Visible;
            PnlOptions.Visible = !PnlOptions.Visible;
        }
        private void BtnAcept_Click(object sender, EventArgs e)
        {
            switch (ExamenSeleccionado)
            {
                case "Word":

                    CerrarWords();
                    DestruirWords();
                    break;
                case "Excel":
                    CerrarExcels();
                    break;
                case "Power Point":
                    CerrarPowerPoints();
                    DestruirPowerPoints();
                    break;
            }

            if (RbContineLatter.Checked == true)
            {
                Application.Exit();
            }
           if(RbFinishQuestions.Checked == true)
            {
                while (this.preguntasResueltas <= FormMain.NUMERO_DE_PREGUNTAS)
                {
                    GuardarNoResueltas();
                };

                using (ModelContainer conexion = new ModelContainer())
                {
                    var examen = conexion.Examenes
                        .Where(p => p.IdExamen == examenIdExamen).
                        FirstOrDefault();
                    examen.avance = contadorDeAvance - 1;
                    examen.preguntasResueltas = this.preguntasResueltas - 1;
                    examen.banderaReanudar = false;
                    conexion.SaveChanges();
                }

                FormMain.formExamResult.Show();
                FormMain.formExamResult.Activate();
                this.Hide();
            }
        }

        #endregion

        #region Methods

        private void GuardarNoResueltas()
        {
            //int numeroDePregunta = FormStartExam.arrayOrdenDePreguntas[contadorDeAvance];
            string numeroDePregunta = arrayOrdenPreguntas[contadorDeAvance-1].ToString();
            switch (ExamenSeleccionado)
            {
                case "Word":
                    rutaPregunta = Application.StartupPath + @"\Documentos\Word\pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @".docx";
                    if (!GuardarNoResueltas(numeroDePregunta, ExamenSeleccionado, "docx"))
                    {
                        contadorDeAvance++;
                        GuardarNoResueltas();
                    }
                    else
                    {                        
                        contadorDeAvance++;
                        this.preguntasResueltas++;
                    }
                    break;
                case "Excel":
                    rutaPregunta = Application.StartupPath + @"\Documentos\Excel\pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @".docx";
                    if (!GuardarNoResueltas(numeroDePregunta, ExamenSeleccionado, "xlsx"))
                    {
                        contadorDeAvance++;
                        GuardarNoResueltas();
                    }
                    else
                    {
                        contadorDeAvance++;
                        this.preguntasResueltas++;
                    }
                    break;
                case "Power Point":
                    rutaPregunta = Application.StartupPath + @"\Documentos\Power Point\pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @".docx";


                    if (!GuardarNoResueltas(numeroDePregunta, ExamenSeleccionado, "pptx"))
                    {
                        contadorDeAvance++;
                        GuardarNoResueltas();
                    }
                    else
                    {
                        contadorDeAvance++;
                        this.preguntasResueltas++;
                    }
                    break;
            }

        }
        private bool GuardarNoResueltas(string numeroDePregunta, string examen, string tipo)
        {
            string ruta = Application.StartupPath + @"\Documentos\"+ examen + @"\pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @" Ejercicio." +tipo;

             if (System.IO.File.Exists(ruta))
            {
                IncorrectoTodo(numeroDePregunta);
            }
            else
            {
                return false;
            }
            return true;
        }

        private void IncorrectoTodo(string numeroPregunta)
        {
            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = "INCORRECTO",
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                numeroDePregunta = numeroPregunta,
                ExamenIdExamen = FormMain.idExamenActual
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
        }

        private void RellenarLabelPregunta()
        {
            LblQuestions.Text = FormMain.NUMERO_DE_PREGUNTAS.ToString();
            // LblNumberOfQuestion.Text = (contadorDeAvance + 1).ToString(); = FormMain.NUMERO_DE_PREGUNTAS
            LblNumberOfQuestion.Text = (this.preguntasResueltas + 1).ToString();
        }

        private void CerrarExcels()
        {
            Process[] excelProcsNew = Process.GetProcessesByName("EXCEL");
            foreach (Process procNew in excelProcsNew)
            {
                int exist = 0;
                foreach (Process procOld in excelProcsOld)
                {
                    if (procNew.Id == procOld.Id)
                    {
                        exist++;
                    }
                }
                if (exist == 0)
                {
                    procNew.Kill();
                }
            }
        }

        private void CerrarPowerPoints()
        {
            try
            {
                ppt.Close();
                ObjPowerPoint.Quit();
            }
            catch (Exception){}
        }

        private void DestruirPowerPoints()
        {
            Process[] powerPointProcsNew = Process.GetProcessesByName("POWERPNT");
               foreach (Process procNew in powerPointProcsNew)
               {
                   int exist = 0;
                   foreach (Process procOld in powerPointProcOld)
                   {
                       if (procNew.Id == procOld.Id)
                       {
                           exist++;
                       }
                   }
                   if (exist == 0)
                   {
                       procNew.Kill();
                   }
               }
        }

        private void DestruirWords()
        {
            Process[] wordProcsNew = Process.GetProcessesByName("WINWORD");
            foreach (Process procNew in wordProcsNew)
            {
                int exist = 0;
                foreach (Process procOld in wordProcsOld)
                {
                    if (procNew.Id == procOld.Id)
                    {
                        exist++;
                    }
                }
                if (exist == 0)
                {
                    procNew.Kill();
                }
            } 
        }

        private void CerrarWords()
        {
            try
            {
                doc.Close();
                ObjWord.Quit();
            }
            catch (Exception) { }
        }

        private void ComprobarCorrectoIncorrecto(object sender, EventArgs e)
        {
            switch (ExamenSeleccionado)
            {
                case "Word":
                    ComprobarCorrectoIncorrectoWord(sender, e);
                    break;
                case "Excel":
                    ComprobarCorrectoIncorrectoExcel(sender, e);
                    break;
                case "Power Point":
                    ComprobarCorrectoIncorrectoPowerPoint(sender, e);
                    break;
            }


        }
        private void ComprobarCorrectoIncorrectoWord(object sender, EventArgs e)
        {
            
            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.docx";

            if (System.IO.File.Exists(ruta))
            {
                System.IO.File.Delete(ruta);
            }

            try
            {
                doc.SaveAs(ruta, Word.WdSaveFormat.wdFormatDocumentDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                DestruirWords();

                guardarCorrecto = true;           
            }
            catch (Exception)
            {
                BtnReset_Click(sender, e);
            }

            if (guardarCorrecto)
            {
                int numeroDePregunta = arrayOrdenPreguntas[contadorDeAvance - 1];
                PreguntasWord preguntasWord = new PreguntasWord();
                preguntasWord.Pregunta(numeroDePregunta, examenIdExamen);
            }            
        }

        private void ComprobarCorrectoIncorrectoExcel(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.xlsx";

            if (System.IO.File.Exists(ruta))
            {
                System.IO.File.Delete(ruta);
            }

            try
            {
                wbook.SaveAs(ruta, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                CerrarExcels();
                guardarCorrecto = true;
            }
            catch (Exception)
            {
                BtnReset_Click(sender, e);
            }
            if (guardarCorrecto)
            {
                int numeroDePregunta = arrayOrdenPreguntas[contadorDeAvance - 1];
                PreguntasExcel preguntasExcel = new PreguntasExcel();
                preguntasExcel.Pregunta(numeroDePregunta, examenIdExamen);
            }
 
        }
        private void ComprobarCorrectoIncorrectoPowerPoint(object sender, EventArgs e)
        {
            int numeroDePregunta = arrayOrdenPreguntas[contadorDeAvance - 1];
            PreguntasPowerPoint preguntasPowerPoint = new PreguntasPowerPoint();

            if (numeroDePregunta == 10 || numeroDePregunta == 22) //propiedades de impresion
            {
                var temp = ppt.PrintOptions;
               
                string numeroCopias = ppt.PrintOptions.NumberOfCopies.ToString(); 
                string slidesPorHoja = ppt.PrintOptions.OutputType.ToString();
                string color = ppt.PrintOptions.PrintColorType.ToString();
                string rango = ppt.PrintOptions.RangeType.ToString();
                string intercalar = ppt.PrintOptions.Collate.ToString();

                preguntasPowerPoint.PropiedadesDeImpresion(numeroCopias, slidesPorHoja, color, rango, intercalar);
            }
            
            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pptx";

            if (System.IO.File.Exists(ruta))
            {
                System.IO.File.Delete(ruta);
            }

            try
            {
                ppt.SaveCopyAs(ruta, PowerPoint.PpSaveAsFileType.ppSaveAsDefault, Microsoft.Office.Core.MsoTriState.msoFalse);

                CerrarPowerPoints();
                guardarCorrecto = true;
            }
            catch (Exception)
            {
                BtnReset_Click(sender, e);
            }

            if (guardarCorrecto)
            {
                preguntasPowerPoint.Pregunta(numeroDePregunta, examenIdExamen);
            }
            
        }

        private void GuardarAvance()
        {
            
            using (ModelContainer conexion = new ModelContainer())
            {
                var examen = conexion.Examenes
                    .Where(p => p.IdExamen == examenIdExamen).
                    FirstOrDefault();
                examen.avance = contadorDeAvance;
                examen.preguntasResueltas = this.preguntasResueltas;
                examen.banderaReanudar = true;
                conexion.SaveChanges();
            }
        }
        private void ObtenerContadorDeAvance()
        {
            if( FormStartExam.irAPregunta == 0)
            {
                using (ModelContainer conexion = new ModelContainer())
                {
                    var examen = conexion.Examenes
                        .Where(p => p.IdExamen == examenIdExamen).
                        FirstOrDefault();
                    contadorDeAvance = examen.avance;
                    this.preguntasResueltas = examen.preguntasResueltas;
                }
            }
            else
            {
                contadorDeAvance = FormStartExam.irAPregunta-1;
                this.preguntasResueltas = FormStartExam.irAPregunta - 1;
            }            
        }
        private void MostrarPreguntaYEjercicio()
        { 
            //int numeroDePregunta = FormStartExam.arrayOrdenDePreguntas[contadorDeAvance];
            int numeroDePregunta = arrayOrdenPreguntas[contadorDeAvance];
            switch (ExamenSeleccionado)
            {
                case "Word":
                    rutaPregunta = Application.StartupPath + @"\Documentos\Word\pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @".docx";
                    if (!AbrirEjercicioWord(numeroDePregunta))
                    {
                        contadorDeAvance++;
                        MostrarPreguntaYEjercicio();
                    }
                    else
                    {
                        MostrarPregunta(numeroDePregunta);
                        contadorDeAvance++;
                        this.preguntasResueltas++;
                    }
                    break;
                case "Excel":
                    rutaPregunta = Application.StartupPath + @"\Documentos\Excel\pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @".docx";
                    if (!AbrirEjercicioExcel(numeroDePregunta))
                    {
                        contadorDeAvance++;
                        MostrarPreguntaYEjercicio();
                    }
                    else
                    {
                        MostrarPregunta(numeroDePregunta);
                        contadorDeAvance++;
                        this.preguntasResueltas++;
                    }
                    break;
                case "Power Point":
                    rutaPregunta = Application.StartupPath + @"\Documentos\Power Point\pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @".docx";


                    if (!AbrirEjercicioPowerPoint(numeroDePregunta))
                    {
                        contadorDeAvance++;
                        MostrarPreguntaYEjercicio();
                    }
                    else
                    {
                        MostrarPregunta(numeroDePregunta);
                        contadorDeAvance++;
                        this.preguntasResueltas++;
                    }
                    break;
            }
                      
        }
        private bool AbrirEjercicioWord(int numeroDePregunta)
        {
            if (numeroDePregunta == 16 || numeroDePregunta == 23 ||
                numeroDePregunta == 31 || numeroDePregunta == 34)
            {
                string fileName = "";

                switch (numeroDePregunta)
                {
                    case 16:
                        fileName = "Tratamiento.docx";
                        break;
                    case 23:
                        fileName = "tv.png";
                        break;
                    case 31:
                        fileName = "Info.docx";
                        break;
                    case 34:
                        fileName = "Eleven.jpg";
                        break;
                }
                
                CopiarDatosParaPregunta(fileName, numeroDePregunta, "Word");
            }


            int WidthScreen = screenExcel.Bounds.Width;
            int HeightScreen = screenExcel.Bounds.Height;
            int newHeightScreen = HeightScreen - HeightScreen * 200 / 1080;

            ObjWord = new Word.Application();

            CopiarPregunta(numeroDePregunta, "Word", "docx");

            string ruta = @"C:\OfficeTrainnerResources\Temp\Pregunta " + numeroDePregunta + @" Ejercicio.docx";

            object objRuta = ruta;

            object missing = Type.Missing;
            
            if (System.IO.File.Exists(ruta))
            {
                ObjWord.Visible = true;
                doc = ObjWord.Documents.Open(ref objRuta,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

                ObjWord.ActiveWindow.WindowState = Word.WdWindowState.wdWindowStateNormal;
                ObjWord.ActiveWindow.Height = 811 * newHeightScreen / 1080;
                ObjWord.ActiveWindow.Width = WidthScreen;
                ObjWord.ActiveWindow.Left = 0;
                ObjWord.ActiveWindow.Top = 0;
            }
            else
            {
                return false;
            }


            return true;
        }

        private bool AbrirEjercicioExcel(int numeroDePregunta)
        {
            if (numeroDePregunta == 17)
            {
                string fileName = "Alumnado.txt";
                CopiarDatosParaPregunta(fileName, numeroDePregunta , "Excel");
            }

            int WidthScreen = screenExcel.Bounds.Width;
            int HeightScreen = screenExcel.Bounds.Height;
            int newHeightScreen = HeightScreen - HeightScreen * 200 / 1080;            
            ObjExcel = new Excel.Application();

            CopiarPregunta(numeroDePregunta, "Excel", "xlsx");

            string ruta = @"C:\OfficeTrainnerResources\Temp\Pregunta " + numeroDePregunta + @" Ejercicio.xlsx";

            if (System.IO.File.Exists(ruta))
            {
                ObjExcel.Visible = true;
                wbook = ObjExcel.Workbooks.Open(ruta);
                
                ObjExcel.ActiveWindow.Height = 811 * newHeightScreen / 1080;
                ObjExcel.ActiveWindow.Width = WidthScreen;
                ObjExcel.ActiveWindow.Left = 0;
                ObjExcel.ActiveWindow.Top = 0;
            }
            else
            {
                return false;
            }
            return true;
        }
        private bool AbrirEjercicioPowerPoint(int numeroDePregunta)
        {
            if (numeroDePregunta == 2 || numeroDePregunta == 18 ||
                numeroDePregunta == 20 || numeroDePregunta == 30)
            {
                string fileName = "";

                switch (numeroDePregunta)
                {
                    case 2:
                        fileName = "El ajedrez.pptx";
                        break;
                    case 18:
                        fileName = "Tabla.xlsx";
                        break;
                    case 20:
                        fileName = "Foto.docx";
                        break;
                    case 30:
                        fileName = "Extras.docx";
                        break;

                }

                CopiarDatosParaPregunta(fileName, numeroDePregunta, "Power Point");
            }

            int WidthScreen = screenPowerPoint.Bounds.Width;
            int HeightScreen = screenPowerPoint.Bounds.Height;
            int newHeightScreen = HeightScreen - HeightScreen * 200 / 1080;
            ObjPowerPoint = new PowerPoint.Application();

            CopiarPregunta(numeroDePregunta, "Power Point", "pptx");

            string ruta = @"C:\OfficeTrainnerResources\Temp\Pregunta " + numeroDePregunta + @" Ejercicio.pptx";

            if (System.IO.File.Exists(ruta))
            {
                ppt = ObjPowerPoint.Presentations.Open(ruta);

                ObjPowerPoint.ActiveWindow.WindowState = PowerPoint.PpWindowState.ppWindowNormal;
                ObjPowerPoint.ActiveWindow.Height = 811 * newHeightScreen / 1080;
                ObjPowerPoint.ActiveWindow.Width = WidthScreen;
                ObjPowerPoint.ActiveWindow.Left = 0;
                ObjPowerPoint.ActiveWindow.Top = 0;                
            }
            else
            {
                return false;
            }
            return true;
        }

        private void CopiarDatosParaPregunta(string FileName, int NumeroPregunta, string Examen)
        {
            string fileName = FileName;
            string sourcePath = Application.StartupPath + @"\Documentos\" + Examen + @"\Pregunta " + NumeroPregunta;
            string targetPath = @"C:\OfficeTrainnerResources";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            if (Directory.Exists(sourcePath))
            {
                if (File.Exists(destFile))
                {
                    File.SetAttributes(destFile, FileAttributes.Normal);
                    File.Delete(destFile);
                }
                File.Copy(sourceFile, destFile, true);
                File.SetAttributes(destFile, FileAttributes.Normal);
            }
        }

        private void CopiarPregunta(int NumeroPregunta, string Examen, string tipo)
        {
            string fileName = @"Pregunta " + NumeroPregunta + @" Ejercicio." + tipo;
            string sourcePath = Application.StartupPath + @"\Documentos\" + Examen + @"\Pregunta " + NumeroPregunta;
            string targetPath = @"C:\OfficeTrainnerResources\Temp";
            
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            if (Directory.Exists(sourcePath))
            {
                if (File.Exists(destFile))
                {
                    File.SetAttributes(destFile, FileAttributes.Normal);
                    File.Delete(destFile);
                }
                File.Copy(sourceFile, destFile, true);
                File.SetAttributes(destFile, FileAttributes.Normal);
            }
        }

        private void CargarArrayOrdenPreguntas()
        {

            arrayOrdenPreguntas = new int[50];//para un maximo de 50 preguntas

            int idExamen = FormMain.idExamenActual;
            using (ModelContainer conexion = new ModelContainer())
            {
                ArrayOrdenPreguntas arrayOrdenDePreguntasO = new ArrayOrdenPreguntas();

                arrayOrdenDePreguntasO = conexion.ArrayOrdenPreguntas.Where(p => p.ExamenIdExamen == idExamen).FirstOrDefault();

                arrayOrdenPreguntas[0] = arrayOrdenDePreguntasO.p01;
                arrayOrdenPreguntas[1] = arrayOrdenDePreguntasO.p02;
                arrayOrdenPreguntas[2] = arrayOrdenDePreguntasO.p03;
                arrayOrdenPreguntas[3] = arrayOrdenDePreguntasO.p04;
                arrayOrdenPreguntas[4] = arrayOrdenDePreguntasO.p05;
                arrayOrdenPreguntas[5] = arrayOrdenDePreguntasO.p06;
                arrayOrdenPreguntas[6] = arrayOrdenDePreguntasO.p07;
                arrayOrdenPreguntas[7] = arrayOrdenDePreguntasO.p08;
                arrayOrdenPreguntas[8] = arrayOrdenDePreguntasO.p09;
                arrayOrdenPreguntas[9] = arrayOrdenDePreguntasO.p10;
                arrayOrdenPreguntas[10] = arrayOrdenDePreguntasO.p11;
                arrayOrdenPreguntas[11] = arrayOrdenDePreguntasO.p12;
                arrayOrdenPreguntas[12] = arrayOrdenDePreguntasO.p13;
                arrayOrdenPreguntas[13] = arrayOrdenDePreguntasO.p14;
                arrayOrdenPreguntas[14] = arrayOrdenDePreguntasO.p15;
                arrayOrdenPreguntas[15] = arrayOrdenDePreguntasO.p16;
                arrayOrdenPreguntas[16] = arrayOrdenDePreguntasO.p17;
                arrayOrdenPreguntas[17] = arrayOrdenDePreguntasO.p18;
                arrayOrdenPreguntas[18] = arrayOrdenDePreguntasO.p19;
                arrayOrdenPreguntas[19] = arrayOrdenDePreguntasO.p20;
                arrayOrdenPreguntas[20] = arrayOrdenDePreguntasO.p21;
                arrayOrdenPreguntas[21] = arrayOrdenDePreguntasO.p22;
                arrayOrdenPreguntas[22] = arrayOrdenDePreguntasO.p23;
                arrayOrdenPreguntas[23] = arrayOrdenDePreguntasO.p24;
                arrayOrdenPreguntas[24] = arrayOrdenDePreguntasO.p25;
                arrayOrdenPreguntas[25] = arrayOrdenDePreguntasO.p26;
                arrayOrdenPreguntas[26] = arrayOrdenDePreguntasO.p27;
                arrayOrdenPreguntas[27] = arrayOrdenDePreguntasO.p28;
                arrayOrdenPreguntas[28] = arrayOrdenDePreguntasO.p29;
                arrayOrdenPreguntas[29] = arrayOrdenDePreguntasO.p30;
                arrayOrdenPreguntas[30] = arrayOrdenDePreguntasO.p31;
                arrayOrdenPreguntas[31] = arrayOrdenDePreguntasO.p32;
                arrayOrdenPreguntas[32] = arrayOrdenDePreguntasO.p33;
                arrayOrdenPreguntas[33] = arrayOrdenDePreguntasO.p34;
                arrayOrdenPreguntas[34] = arrayOrdenDePreguntasO.p35;
                arrayOrdenPreguntas[35] = arrayOrdenDePreguntasO.p36;
                arrayOrdenPreguntas[36] = arrayOrdenDePreguntasO.p37;
                arrayOrdenPreguntas[37] = arrayOrdenDePreguntasO.p38;
                arrayOrdenPreguntas[38] = arrayOrdenDePreguntasO.p39;
                arrayOrdenPreguntas[39] = arrayOrdenDePreguntasO.p40;
                arrayOrdenPreguntas[40] = arrayOrdenDePreguntasO.p41;
                arrayOrdenPreguntas[41] = arrayOrdenDePreguntasO.p42;
                arrayOrdenPreguntas[42] = arrayOrdenDePreguntasO.p43;
                arrayOrdenPreguntas[43] = arrayOrdenDePreguntasO.p44;
                arrayOrdenPreguntas[44] = arrayOrdenDePreguntasO.p45;
                arrayOrdenPreguntas[45] = arrayOrdenDePreguntasO.p46;
                arrayOrdenPreguntas[46] = arrayOrdenDePreguntasO.p47;
                arrayOrdenPreguntas[47] = arrayOrdenDePreguntasO.p48;
                arrayOrdenPreguntas[48] = arrayOrdenDePreguntasO.p49;
                arrayOrdenPreguntas[49] = arrayOrdenDePreguntasO.p50;

            }
        }
     
        private void MostrarPregunta(int numeroDePregunta)
        {            
            //object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWordPregunta = new Word.Application();
            //Document doc = new Document();

            //object fileName = path;            
            object fileName = rutaPregunta;
            // Define an object to pass to the API for missing parameters
            object missing = Type.Missing;
            Word.Document ObjDoc = ObjWordPregunta.Documents.Open(ref fileName,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            String read = string.Empty;           
            foreach (Word.Range tmpRange in ObjDoc.StoryRanges)
            {
                TxtQuestion.Text = tmpRange.Text;
            }
            ObjDoc.Close();
            ObjWordPregunta.Quit();            
        }

        #endregion


    }
}
