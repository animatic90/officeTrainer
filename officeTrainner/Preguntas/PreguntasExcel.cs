//using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Datos;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Preguntas
{

    public class PreguntasExcel
    {
        /****Excel guardado temporal****/
        Excel.Application ObjExcelAlumno;
        Excel.Worksheet wsheetAlumno;
        Excel.Workbook wbookAlumno;
        /****Excel ejercicio resuelto****/
        Excel.Application ObjExcelResuelto;
        Excel.Worksheet wsheetResuelto;
        Excel.Workbook wbookResuelto;
        /****Workbook Temporal****/
        //Excel.Worksheet wsheetAlumno2;
        int idExamen;
        
        /***** *********/
        string p1 = "NO EXISTE";
        string p2 = "NO EXISTE";
        string p3 = "NO EXISTE";
        string p4 = "NO EXISTE";
        string p5 = "NO EXISTE";
        

        Process[] excelProcsOld;

        public void Pregunta(int numeroDePregunta, int examenIdExamen)
        {
            excelProcsOld = Process.GetProcessesByName("EXCEL");
            
            idExamen = examenIdExamen;
            AbrirExcels(numeroDePregunta);

            switch (numeroDePregunta)
                {
                case 1: Pregunta1(); break;
                case 2: Pregunta2(); break;
                case 3: Pregunta3(); break;
                case 4: Pregunta4(); break;
                case 5: Pregunta5(); break;
                case 6: Pregunta6(); break;
                case 7: Pregunta7(); break;
                case 8: Pregunta8(); break;
                case 9: Pregunta9(); break;
                case 10: Pregunta10(); break;
                case 11: Pregunta11(); break;
                case 12: Pregunta12(); break;
                case 13: Pregunta13(); break;
                case 14: Pregunta14(); break;
                case 15: Pregunta15(); break;
                case 16: Pregunta16(); break;
                case 17: Pregunta17(); break;
                case 18: Pregunta18(); break;
                case 19: Pregunta19(); break;
                case 20: Pregunta20(); break;
                case 21: Pregunta21(); break;
                case 22: Pregunta22(); break;
                case 23: Pregunta23(); break;
                case 24: Pregunta24(); break;
                case 25: Pregunta25(); break;
                case 26: Pregunta26(); break;
                case 27: Pregunta27(); break;
                case 28: Pregunta28(); break;
                case 29: Pregunta29(); break;
                case 30: Pregunta30(); break;
                case 31: Pregunta31(); break;
                case 32: Pregunta32(); break;
                case 33: Pregunta33(); break;
                case 34: Pregunta34(); break;
                case 35: Pregunta35(); break;
                case 36: Pregunta36(); break;
                case 37: Pregunta37(); break;
                case 38: Pregunta38(); break;
                case 39: Pregunta39(); break;
                case 40: Pregunta40(); break;
                case 41: Pregunta41(); break;
                case 42: Pregunta42(); break;
                case 43: Pregunta43(); break;
                case 44: Pregunta44(); break;
                case 45: Pregunta45(); break;
                case 46: Pregunta46(); break;
                case 47: Pregunta47(); break;
                case 48: Pregunta48(); break;
                case 49: Pregunta49(); break;
                case 50: Pregunta50(); break;



            }
                 
        }

        private void AbrirExcels(int numeroDePregunta)
        {
            ObjExcelAlumno = new Excel.Application()
            {
                Visible = false
            };
            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.xlsx";
            wbookAlumno = ObjExcelAlumno.Workbooks.Open(ruta);
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.ActiveSheet;

            ObjExcelResuelto = new Excel.Application()
            {
                Visible = false
            };
            string rutaResuelto = Application.StartupPath + @"\Documentos\Excel\Pregunta "+ numeroDePregunta+@"\Pregunta "+ numeroDePregunta+@" Resuelta.xlsx";
            wbookResuelto = ObjExcelResuelto.Workbooks.Open(rutaResuelto);
            wsheetResuelto = (Excel.Worksheet)wbookResuelto.ActiveSheet;
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

        private void BorrarTemporales()
        {
            string rutaEjercicio = Application.StartupPath + @"\Documentos\Temp\Ejercicio";
            System.IO.DirectoryInfo di = new DirectoryInfo(rutaEjercicio);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private void Pregunta1()
        {

            if (wsheetAlumno.ListObjects.Count == 0)
            {
                p1 = "INCORRECTO";
                p2 = "INCORRECTO";
            }
            else
            {
                Excel.TableStyle tableStyleALumno = wsheetAlumno.ListObjects.get_Item("Tabla1").TableStyle;
                Excel.TableStyle tableStyleResuelto = wsheetResuelto.ListObjects.get_Item("Tabla2").TableStyle;

                Excel.Range rangeAlumno = wsheetAlumno.ListObjects.get_Item("Tabla1").Range;
                Excel.Range rangeResuelto = wsheetResuelto.ListObjects.get_Item("Tabla2").Range;

                if (tableStyleALumno.Name == tableStyleResuelto.Name && rangeAlumno.Column == rangeResuelto.Column && rangeAlumno.Row == rangeResuelto.Row && rangeAlumno.Count == rangeResuelto.Count)
                {
                    p1 = "CORRECTO";
                }
                else
                {
                    p1 = "INCORRECTO";
                }


                if (wsheetAlumno.ListObjects.get_Item("Tabla1").ShowTableStyleRowStripes == false)
                {
                    p2 = "CORRECTO";
                }
                else
                {
                    p2 = "INCORRECTO";
                }
            }
            


            PuntajePregunta puntajePregunta = new PuntajePregunta
            {                
                sp1 = p1,
                sp2 = p2,
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }

            CerrarExcels();
        }

        private void Pregunta2()
        {
            ////Microsoft.Office.Interop.Excel.Worksheet sheet = workbook.Sheets[1];

            int maxCol = 13; // set maximum number of rows/columns to search
            int maxRow = 325;
            bool banderaSalirDelFor = false;



            //this is pretty slow, since it has to interact with 10,000 cells in Excel
            // just one example of how to access and set cell values       
            for (int col = 1; col <= maxCol; col++)
            {
                
                for (int row = 1; row <= maxRow; row++)
                {
                    if((wsheetAlumno.Cells[row, col] as Excel.Range).Value != (wsheetResuelto.Cells[row, col] as Excel.Range).Value)
                    {                       
                        banderaSalirDelFor = true;
                        p1 = "INCORRECTO";
                        break ;
                    }
                }
                if (banderaSalirDelFor)
                    break;
            }
            if(!banderaSalirDelFor)
            {               
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            CerrarExcels();
        }
   
        private void Pregunta3()
        {
            //var borrar = (wsheetAlumno.Cells[2, 13] as Excel.Range).Formula;
            if ((wsheetAlumno.Cells[2, 13] as Excel.Range).Formula != (wsheetResuelto.Cells[2, 13] as Excel.Range).Formula)
            {
                p1 = "INCORRECTO";
            }
            else
            {
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            CerrarExcels();
        }
        private void Pregunta4()
        {
            // (wsheetAlumno.Cells[2, 6] as Excel.Range).NumberFormat = "0.000";
            p1 = "CORRECTO";

            for (int row = 2; row <= 26; row++)
            {
                if ((wsheetAlumno.Cells[row, 6] as Excel.Range).NumberFormat != (wsheetResuelto.Cells[row, 6] as Excel.Range).NumberFormat)
                {
                    p1 = "INCORRECTO";
                    break;
                }
                
            }  

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }

            CerrarExcels();
        }
        private void Pregunta5()
        {            
            CerrarExcels();
            ////Descomprimir ejercicio
            //string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";
            //string ruta_7z = Application.StartupPath + @"\Documentos\Temp\7z";
            ////string ruta_ResAlum = Application.StartupPath + @"\Documentos\Temp\xl\worksheets";

            //ProcessStartInfo info = new ProcessStartInfo();

            //info.UseShellExecute = true;
            //info.FileName = "7z.exe";
            //info.WorkingDirectory = ruta_7z;
            //info.Arguments = "x "+ruta_ResTem+"Ejercicio.xlsx"+" "+"-o"+ruta_ResTem+"Ejercicio";

            //Process.Start(info);
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            //Thread t = new Thread(new ThreadStart(DescomprimirZip));
            //t.Start();
            //t.Join();
            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000);


            string cadenaAchequear1 = "conditionalFormatting";
            string cadenaAchequear2 = "sqref=\"J2:J325\"";
            string cadenaAchequear3 = "type=\"aboveAverage\"";
            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\worksheets\sheet1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2) && contenidoDeArchivo[1].Contains(cadenaAchequear3))
                //if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";            
            else
                p1 = "INCORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta6()
        {
            var borrar = (wsheetAlumno.Cells[2, 13] as Excel.Range).Formula;
            if ((wsheetAlumno.Cells[2, 9] as Excel.Range).Formula != (wsheetResuelto.Cells[2, 9] as Excel.Range).Formula)
            {
                p1 = "INCORRECTO";
            }
            else
            {
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            CerrarExcels();
        }
        private void Pregunta7()
        {
            p1 = "CORRECTO";

            for (int row = 2; row <= 308; row++)
            {
                if (!(wsheetAlumno.Cells[row, 1] as Excel.Range).Value.Equals((wsheetResuelto.Cells[row, 1] as Excel.Range).Value))
                {
                    p1 = "INCORRECTO";
                    break;
                }

            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }

            CerrarExcels();
        }
        private void Pregunta8()
        {
            p1 = "INCORRECTO";
            //Excel.Worksheet sheet = null;
            foreach (Excel.Worksheet sheet in wbookAlumno.Sheets)
            {
                if (sheet.Name.Equals("Resumen") && wbookAlumno.Sheets.Count==3)
                {
                    p1 = "CORRECTO";
                    break;
                }
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }

            CerrarExcels();            
        }

        static void DescomprimirZip()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";
            string ruta_7z = Application.StartupPath + @"\Documentos\Temp\7z";            
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "7z.exe";
            info.WorkingDirectory = ruta_7z;
            info.Arguments = "x " + ruta_ResTem + "Ejercicio.xlsx" + " " + "-o" + ruta_ResTem + "Ejercicio";

            Process.Start(info);            
        }

        private void Pregunta9()
        {
            CerrarExcels();
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "a:pattFill";
            string cadenaAchequear2 = "prst=\"horzBrick\"";
            
            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\drawings\drawing1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta10()
        {
            CerrarExcels();
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "tabColor";
            string cadenaAchequear2 = "theme=\"5\"";
            string cadenaAchequear3 = "tint=\"-0.249977111117893\""; //Con esto, probalbmente, se trabaja los otros parámetros que por ahora no comparamos

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\worksheets\sheet3.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2) && contenidoDeArchivo[1].Contains(cadenaAchequear3))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta11()
        {
            CerrarExcels();
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "state=\"hidden\"";            

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\workbook.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta12()
        {
            CerrarExcels();
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "First Semester Report";
            string cadenaAchequear2 = "Certificación";            
            string cadenaAchequear3 = "<cp:revision>2</cp:revision>";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\docProps\core.xml"));
            if (!contenidoDeArchivo[1].Contains(cadenaAchequear1) &&
                !contenidoDeArchivo[1].Contains(cadenaAchequear2) &&
                !contenidoDeArchivo[1].Contains(cadenaAchequear3))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta13()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];
            var temp = (wsheetAlumno.Cells[5,3] as Excel.Range).Value;

            if (temp != 54)
            {
                p1 = "INCORRECTO";
            }
            else
            {
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            CerrarExcels();
        }
        private void Pregunta14()
        {
            //CerrarExcels();
            //string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            //Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            //Task.WaitAll(task1);

            //Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente            

            //String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\styles.xml"));
            //String[] cadenaBuscada = File.ReadAllLines(Application.StartupPath + @"\Documentos\Excel\Pregunta 14\CadenaBuscada.txt");
            //if (contenidoDeArchivo[1].Contains(cadenaBuscada[0]))
            //    p1 = "CORRECTO";
            //else
            //    p1 = "INCORRECTO";

            int maxCol = 5; // set maximum number of rows/columns to search
            int maxRow = 13;
            bool banderaSalirDelFor = false;
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1]; 

            //this is pretty slow, since it has to interact with 10,000 cells in Excel
            // just one example of how to access and set cell values       
            for (int col = 1; col <= maxCol; col++)
            {
                for (int row = 3; row <= maxRow; row++)
                {
                    //var temp = (wsheetAlumno2.Cells[row, col] as Excel.Range).WrapText;

                    if ((wsheetAlumno.Cells[row, col] as Excel.Range).WrapText != true)
                    {
                        banderaSalirDelFor = true;
                        p1 = "INCORRECTO";
                        break;
                    }
                }
                if (banderaSalirDelFor)
                    break;
            }
            if (!banderaSalirDelFor)
            {
                p1 = "CORRECTO";
            }


            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta15()
        {
            int maxCol = 3; // set maximum number of rows/columns to search
            int maxRow = 13;
            bool banderaSalirDelFor = true;
            string temp = "CORRECTO"; //parcialmente correcto
            p1 = "INCORRECTO";

            //var NombreDeTabla = wsheetAlumno.ListObjects.get_Item("Resumen").Name;

            //if (!String.IsNullOrEmpty(wsheetAlumno.ListObjects.get_Item("Resumen").Name.))
            //{
            //    temp = "CORRECTO"; //Significa que la tabla resumen ya no existe
            //}

            foreach (Excel.ListObject obj in wsheetAlumno.ListObjects)
            {
                if(obj.Name != "Resumen")                
                    temp = "CORRECTO"; //Significa que la tabla resumen ya no existe                
                else
                    temp = "INCORRECTO";
            }

            //this is pretty slow, since it has to interact with 10,000 cells in Excel
            // just one example of how to access and set cell values      
            if (temp == "CORRECTO")
            {
                for (int col = 1; col <= maxCol; col++)
                {
                    for (int row = 3; row <= maxRow; row++)
                    {
                        if ((wsheetAlumno.Cells[row, col] as Excel.Range).Interior.Color == (wsheetResuelto.Cells[row, col] as Excel.Range).Interior.Color &&
                            (wsheetAlumno.Cells[row, col] as Excel.Range).Value == (wsheetResuelto.Cells[row, col] as Excel.Range).Value &&
                            (wsheetAlumno.Cells[row, col] as Excel.Range).Formula == (wsheetResuelto.Cells[row, col] as Excel.Range).Formula)
                            {
                                p1 = "CORRECTO";
                                banderaSalirDelFor = false;
                            }

                        if (banderaSalirDelFor) //quiere decir que no entro al if anterior, lo qeu significa que cambio el color el valor o la formula
                        { 
                            banderaSalirDelFor = true; //basta con que entre una vez aquí, ya que eso invalida todo el ejercicio
                            break;
                        }
                    }
                }
                if (banderaSalirDelFor)
                {
                    p1 = "INCORRECTO";
                }
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            CerrarExcels();
        }
        private void Pregunta16()
        {
            p1 = "INCORRECTO";
            var contador = wbookAlumno.Sheets.Count;
            if (contador == 3)
            {
                var nombre = wbookAlumno.Sheets[3].Name;
                if (nombre == "Calificaciones (2)")
                {
                    p1 = "CORRECTO";
                }               
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta17()
        {
            //copiar Alumnado.txt a C:\OfficeTrainner

            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[2];
            wsheetResuelto = (Excel.Worksheet)wbookResuelto.Sheets[2];
            int maxCol = 8; // set maximum number of rows/columns to search
            int maxRow = 13;
            bool banderaSalirDelFor = false;

            //this is pretty slow, since it has to interact with 10,000 cells in Excel
            // just one example of how to access and set cell values     
            for (int col = 5; col <= maxCol; col++)
            {
                for (int row = 3; row <= maxRow; row++)
                {
                    //var temp1 = (wsheetAlumno.Cells[row, col] as Excel.Range).Value.ToString();
                    //var temp2 = (wsheetResuelto.Cells[row, col] as Excel.Range).Value.ToString();

                    if ((wsheetAlumno.Cells[row, col] as Excel.Range).Value.ToString() != (wsheetResuelto.Cells[row, col] as Excel.Range).Value.ToString())
                    {
                        banderaSalirDelFor = true;
                        p1 = "INCORRECTO";
                        break;
                    }
                }
                if (banderaSalirDelFor)
                    break;
            }
            if (!banderaSalirDelFor)
            {
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta18()
        {
            //wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];

            //Excel.Range range = wsheetAlumno.get_Range("A3:F8");
            //var temp = range.Interior.ThemeColor;
            //p1 = "INCORRECTO";


            int maxCol = 6; // set maximum number of rows/columns to search
            int maxRow = 8;
            bool banderaSalirDelFor = false;



            //this is pretty slow, since it has to interact with 10,000 cells in Excel
            // just one example of how to access and set cell values       
            for (int col = 1; col <= maxCol; col++)
            {
                for (int row = 3; row <= maxRow; row++)
                {
                    if ((wsheetAlumno.Cells[row, col] as Excel.Range).Interior.Color != (wsheetResuelto.Cells[row, col] as Excel.Range).Interior.Color ||
                        (wsheetAlumno.Cells[row, col] as Excel.Range).Value != (wsheetResuelto.Cells[row, col] as Excel.Range).Value)
                    {
                        banderaSalirDelFor = true;
                        p1 = "INCORRECTO";
                        break;
                    }
                }
                if (banderaSalirDelFor)
                    break;
            }
            if (!banderaSalirDelFor)
            {
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            CerrarExcels();

        }
        private void Pregunta19()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[2];

            Excel.Range range = wsheetAlumno.get_Range("A3:F8");
            //var tempo = wsheetAlumno.ListObjects.get_Item("Table1").TableStyle.Name;
            p1 = "INCORRECTO";

            foreach (Excel.ListObject obj in wsheetAlumno.ListObjects)
            {
                Excel.Range rangeAlumno = wsheetAlumno.ListObjects.get_Item(obj.Name).Range;
                if (obj.TableStyle.Name == "TableStyleMedium1" && rangeAlumno.Column == range.Column && rangeAlumno.Row == range.Row && rangeAlumno.Count == range.Count)
                {
                    p1 = "CORRECTO";
                }
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }

        private void Pregunta20()
        {

            //primero comprobar si la carpeta charts existe
            //comprobar que el archivo chart1.xml existe
            //cadenas a buscar
            //<a:t>Ventas Semana 3</a:t>
            //<cx:v>SEMANA 3</cx:v>
            //layoutId="paretoLine"

            CerrarExcels();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "<a:t>Ventas Semana 3</a:t>";
            string cadenaAchequear2 = "<cx:v>SEMANA 3</cx:v>";
            string cadenaAchequear3 = "layoutId=\"paretoLine\"";


            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\charts\chart1.xml"));
            if (contenidoDeArchivo[0].Contains(cadenaAchequear1) &&
                contenidoDeArchivo[0].Contains(cadenaAchequear2) &&
                contenidoDeArchivo[0].Contains(cadenaAchequear3))
                p1 = "CORRECTO";


            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();

        }
        private void Pregunta21()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[3];            
            int maxRow = 27;            
            p1 = "CORRECTO";
  
            //var temp = (wsheetAlumno.Cells[4, 5] as Excel.Range).FormatConditions.GetType();
                for (int row = 4; row <= maxRow; row++)
                {
                    if ((wsheetAlumno.Cells[row, 4] as Excel.Range).Formula != (wsheetResuelto.Cells[row, 4] as Excel.Range).Formula)
                    {                        
                        p1 = "INCORRECTO";
                        break;
                    }
                }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta22()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];
            int maxRow = 41;
            p1 = "CORRECTO";

            //var temp = (wsheetAlumno.Cells[4, 5] as Excel.Range).FormatConditions.GetType();
            for (int row = 5; row <= maxRow; row++)
            {
                if ((wsheetAlumno.Cells[row, 2] as Excel.Range).Value != (wsheetResuelto.Cells[row, 2] as Excel.Range).Value)
                {
                    p1 = "INCORRECTO";
                    break;
                }
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta23()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];            
            p1 = "INCORRECTO";

            if ((wsheetAlumno.Cells[1, 7] as Excel.Range).Formula == "=SUMIF(C5:C41,\"Importado\",F5:F41)")
            {
              p1 = "CORRECTO";                    
            }         

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta24()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];
            p1 = "INCORRECTO";

            if ((wsheetAlumno.Cells[1, 7] as Excel.Range).Formula == "=COUNTIF(B5:B41,\"Cocina\")")
            {
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta25()
        {
            CerrarExcels();
            p1 = "INCORRECTO";
            string temp = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "rowBreaks count=\"3\"";            

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\worksheets\sheet1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
                temp = "CORRECTO";

            //SOLO PARA ESTA PREGUNTA, SE NECESITA ABRIR TODO LO CORRESPONDIENTE AL EXCEL
            ObjExcelAlumno = new Excel.Application()
            {
                Visible = false
            };
            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.xlsx";
            wbookAlumno = ObjExcelAlumno.Workbooks.Open(ruta);
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.ActiveSheet;

            //Ahora falta hacer las otras verificaciones
            //wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];
            //if ((wsheetAlumno.Cells[19, 5] as Excel.Range).Formula == "=SUBTOTAL(9,E5:E18)"
            //    && (wsheetAlumno.Cells[29, 5] as Excel.Range).Formula == "=SUBTOTAL(9,E20:E28)"
            //    && (wsheetAlumno.Cells[44, 5] as Excel.Range).Formula == "=SUBTOTAL(9,E30:E43)"
            //    && (wsheetAlumno.Cells[45, 5] as Excel.Range).Formula == "=SUBTOTAL(9,E5:E43)"
            if ((wsheetAlumno.Cells[19, 5] as Excel.Range).Value.ToString() == "945"
                && (wsheetAlumno.Cells[29, 5] as Excel.Range).Value.ToString() == "519"
                && (wsheetAlumno.Cells[44, 5] as Excel.Range).Value.ToString() == "1111"
                && (wsheetAlumno.Cells[45, 5] as Excel.Range).Value.ToString() == "2575"
                && temp == "CORRECTO")
                {
                    p1 = "CORRECTO";
                }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();

        }
        private void Pregunta26()
        {
            CerrarExcels();
            p1 = "INCORRECTO";            

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "view=\"pageLayout\"";
            string cadenaAchequear2 = "sqref=\"A35"; //"sqref=\"A35:XFD35\"";
            string cadenaAchequear3 = "rowBreaks count=\"1\"";


            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\worksheets\sheet1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) &&
                contenidoDeArchivo[1].Contains(cadenaAchequear2) &&
                contenidoDeArchivo[1].Contains(cadenaAchequear3))
                p1 = "CORRECTO";


            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta27()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];
            p1 = "INCORRECTO";

            if ((wsheetAlumno.Cells[14, 13] as Excel.Range).Formula == "=SUBTOTAL(109,[Dic])")
            {
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta28()
        {
            CerrarExcels(); 
            p1 = "INCORRECTO";
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "Ventas!$A$4";
            string cadenaAchequear2 = "Ventas!$A$5";
            string cadenaAchequear3 = "Ventas!$A$6";
            string cadenaAchequear4 = "Ventas!$A$7";
            string cadenaAchequear5 = "Ventas!$A$8";
            string cadenaAchequear6 = "Ventas!$A$9";
            string cadenaAchequear7 = "Ventas!$A$10";
            string cadenaAchequear8 = "Ventas!$A$11";
            string cadenaAchequear9 = "Ventas!$A$12";
            string cadenaAchequear10 = "Ventas!$A$13";

            string cadenaAchequear11 = "Ventas!$B$3:$D$3";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\charts\chart1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) 
                && contenidoDeArchivo[1].Contains(cadenaAchequear2) 
                && contenidoDeArchivo[1].Contains(cadenaAchequear3)
                && contenidoDeArchivo[1].Contains(cadenaAchequear4)
                && contenidoDeArchivo[1].Contains(cadenaAchequear5)
                && contenidoDeArchivo[1].Contains(cadenaAchequear6)
                && contenidoDeArchivo[1].Contains(cadenaAchequear7)
                && contenidoDeArchivo[1].Contains(cadenaAchequear8)
                && contenidoDeArchivo[1].Contains(cadenaAchequear9)
                && contenidoDeArchivo[1].Contains(cadenaAchequear10)
                && contenidoDeArchivo[1].Contains(cadenaAchequear11))
                p1 = "CORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();


            /******************************ESTO DE ABAJO SÍ FUNCIONA**********************************/
            //var charts = wsheetAlumno.ChartObjects() as Excel.ChartObjects;
            //var chart = charts. Item(1);
            //MessageBox.Show(chart.ChartTitle.ToString());  

            //foreach (Excel.ChartObject obj in wsheetAlumno.ChartObjects())
            //{
            //    //MessageBox.Show(obj.TableStyle.Name);
            //    MessageBox.Show(obj.Chart.ChartTitle.Caption);
            //}
        }
        private void Pregunta29()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];
            p1 = "INCORRECTO";

            foreach (Excel.ChartObject obj in wsheetAlumno.ChartObjects())
            {
                if(obj.Chart.HasLegend == true)
                    if(obj.Chart.Legend.Name == "Legend")
                        p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta30()
        {
            CerrarExcels();
            p1 = "INCORRECTO";
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "/xl/chartsheets/sheet1.xml";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\[Content_Types].xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
                p1 = "CORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();

        }
        private void Pregunta31()
        {
            CerrarExcels();
            p1 = "INCORRECTO";
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "Target=\"../media/image1.png\"";
            string cadenaAchequear2 = "Target=\"http://www.uanl.mx";
            string cadenaAchequear3 = "TargetMode=\"External\"";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\drawings\_rels\drawing1.xml.rels"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1)
                && contenidoDeArchivo[1].Contains(cadenaAchequear2)
                && contenidoDeArchivo[1].Contains(cadenaAchequear3))
                p1 = "CORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta32()
        {
            CerrarExcels();
            p1 = "INCORRECTO";
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "showFormulas=\"1\"";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\worksheets\sheet2.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
                p1 = "CORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta33()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[2];            

            p1 = "INCORRECTO";

            if (wsheetAlumno.Visible == Excel.XlSheetVisibility.xlSheetVisible)
            {
                p1 = "CORRECTO";
            }

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta34()
        {
            wsheetAlumno = (Excel.Worksheet)wbookAlumno.Sheets[1];
            p1 = "INCORRECTO";            

            //primero verificar que se haya seleccionado un área de impresión
            if (!String.IsNullOrEmpty(wsheetAlumno.PageSetup.PrintArea))
            {
                if (wsheetAlumno.PageSetup.PrintArea == "$C$3:$E$13")
                {
                    p1 = "CORRECTO";
                }
            }
            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
            CerrarExcels();
        }
        private void Pregunta35()
        {
            CerrarExcels();
            p1 = "INCORRECTO";
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZip());
            Task.WaitAll(task1);

            Thread.Sleep(2000); //para esperar a que el zip se descomprima totalmente
            string cadenaAchequear1 = "(Calificaciones!$C$4:$D$8,Calificaciones!$C$9:$D$13)";
            string cadenaAchequear2 = "(Calificaciones!$E$4:$E$8,Calificaciones!$E$9:$E$13)";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\xl\charts\chart1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1)
                && contenidoDeArchivo[1].Contains(cadenaAchequear2))
                p1 = "CORRECTO";

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = "NO EXISTE",
                sp3 = "NO EXISTE",
                sp4 = "NO EXISTE",
                sp5 = "NO EXISTE",
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
            BorrarTemporales();
        }
        private void Pregunta36()
        {
        }
        private void Pregunta37()
        {
        }
        private void Pregunta38()
        {
        }
        private void Pregunta39()
        {
        }
        private void Pregunta40()
        {
        }
        private void Pregunta41()
        {
        }
        private void Pregunta42()
        {
        }
        private void Pregunta43()
        {
        }
        private void Pregunta44()
        {
        }
        private void Pregunta45()
        {
        }
        private void Pregunta46()
        {
        }
        private void Pregunta47()
        {
        }
        private void Pregunta48()
        {
        }
        private void Pregunta49()
        {
        }
        private void Pregunta50()
        {
        }
    }
}


