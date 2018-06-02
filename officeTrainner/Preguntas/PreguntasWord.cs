using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Datos;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;
using PdfReader = iTextSharp.text.pdf;
using System.Diagnostics;
using System.Threading;

namespace Preguntas
{
    public class PreguntasWord
    {
        int idExamen;
        Word.Application objWordAlumno;
        Word.Document docAlumno;

        string p1 = "NO EXISTE";
        string p2 = "NO EXISTE";
        string p3 = "NO EXISTE";
        string p4 = "NO EXISTE";
        string p5 = "NO EXISTE";

        public void Pregunta(int numeroDePregunta, int examenIdExamen)
        {
            // powerPointProcsOld = Process.GetProcessesByName("POWERPNT");
            idExamen = examenIdExamen;
            AbrirWords(numeroDePregunta);

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

        private void AbrirWords(int numeroDePregunta)
        {
            objWordAlumno = new Word.Application();
            objWordAlumno.Visible = true;

            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.docx";
            object fileName = ruta;
            object missing = Type.Missing;

            /* docAlumno = objWordAlumno.Documents.Open(ref fileName,
                     ref missing, ref missing, ref missing, ref missing,
                     ref missing, ref missing, ref missing, ref missing,
                     ref missing, ref missing, ref missing, ref missing,
                     ref missing, ref missing, ref missing);*/

            docAlumno = objWordAlumno.Documents.Open(ruta, ReadOnly: false, Visible: true);
        }
                
        private void CerrarWords()
        {
            docAlumno.Close();
            objWordAlumno.Quit();
        }

        private void BorrarTemporales()
        {
            string rutaEjercicio = Application.StartupPath + @"\Documentos\Temp\Ejercicio";
            DirectoryInfo di = new DirectoryInfo(rutaEjercicio);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        static void DescomprimirZipWord()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";
            string ruta_7z = Application.StartupPath + @"\Documentos\Temp\7z";
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "7z.exe";
            info.WorkingDirectory = ruta_7z;
            info.Arguments = "x " + ruta_ResTem + "Ejercicio.docx" + " " + "-o" + ruta_ResTem + "Ejercicio";

            Process.Start(info);
        }

        private void ComprobarDescompresion()
        {
            for (int i = 0; i < 200; i++)
            {
                string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio\docProps\core.xml";

                if (!File.Exists(ruta))
                {
                    Thread.Sleep(500); //para esperar a que el zip se descomprima totalmente
                }
                else
                {
                    break;
                }
            }
        }
        
        private void GuardarPuntaje()
        {

            PuntajePregunta puntajePregunta = new PuntajePregunta
            {
                sp1 = p1,
                sp2 = p2,
                sp3 = p3,
                sp4 = p4,
                sp5 = p5,
                ExamenIdExamen = idExamen
            };

            using (ModelContainer conexion = new ModelContainer())
            {
                conexion.PuntajePreguntas.Add(puntajePregunta);
                conexion.SaveChanges();
            }
        }

        private void Pregunta1()
        {
            bool smartEsCorrecto = false;         
            /******************** Comprobar si el SmartArt es correcto ******************/
            string nameLayout = objWordAlumno.SmartArtLayouts[6].Name;

            Word.InlineShapes iShapes = docAlumno.InlineShapes;

            if (iShapes.Count == 1)
            {     
                Word.InlineShape smart = iShapes[1];
                var isSmart = smart.HasSmartArt;

                if (isSmart == MsoTriState.msoTrue) //comprobar que sea smartart
                {
                    string name = smart.SmartArt.Layout.Name;
                    int numeroNodos = smart.SmartArt.AllNodes.Count;

                    if (name.Equals(nameLayout) && numeroNodos == 3)
                    {
                        SmartArtNode nodo1 = smart.SmartArt.AllNodes[1];
                        string texto1 = nodo1.TextFrame2.TextRange.Text;

                        SmartArtNode nodo2 = smart.SmartArt.AllNodes[2];
                        string texto2 = nodo2.TextFrame2.TextRange.Text;

                        SmartArtNode nodo3 = smart.SmartArt.AllNodes[3];
                        string texto3 = nodo3.TextFrame2.TextRange.Text;

                        if (texto1.Equals("Autosimilitud") && texto2.Equals("") && texto3.Equals(""))
                        {
                            smartEsCorrecto = true;
                        }
                    }
                }
            }
            /*********************************************************************/

            //  var temp = docAlumno.Content.Text.Replace((char)(0x07), (char)(0x20));
            string rutaPdf = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pdf";
            docAlumno.ExportAsFixedFormat(rutaPdf, Word.WdExportFormat.wdExportFormatPDF);

            StringBuilder text = new StringBuilder();
            using (PdfReader.PdfReader reader = new PdfReader.PdfReader(rutaPdf))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfReader.parser.PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }
            File.Delete(rutaPdf);
            // Algoritmo recursivo (iteración) \n \nAutosimilitud\n  LOS FRACTALES
            // Algoritmo recursivo (iteración) \nAutosimilitud\n \n  LOS FRACTALES
            string cadenaAchequear1 = "Algoritmo recursivo (iteración) \n \nAutosimilitud\n  LOS FRACTALES";
            string cadenaAchequear2 = "Algoritmo recursivo (iteración) \nAutosimilitud\n \n  LOS FRACTALES";

            string contenidoDeArchivo = text.ToString();

            if (smartEsCorrecto)
            {
                if (contenidoDeArchivo.Contains(cadenaAchequear1) || contenidoDeArchivo.Contains(cadenaAchequear2))
                    p1 = "CORRECTO";
                else
                    p1 = "INCORRECTO";
            }
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();

        }

        private void Pregunta2()
        {
            bool tablaEsCorrecto = false;
            bool posicionEsCorrecto = false;

            Word.Tables tablas = docAlumno.Tables;
            if (tablas.Count == 1) //comprobar que exista solo una tabla
            {
                /******************** Comprobar si la Tabla es correcta ******************/
                int filas = tablas[1].Rows.Count;
                int columnas = tablas[1].Columns.Count;
                if (filas == 3 && columnas == 4)
                {
                    tablaEsCorrecto = true;
                }
                /*************************************************************************/
                
                /********comprobar la pisicion de la tabla*****/
                Word.Range rango = tablas[1].Range;     
                int numPage = tablas[1].Range.get_Information(Word.WdInformation.wdActiveEndPageNumber); //pagina donde se encuentra la tabla

                int start = rango.Start;
                int end = rango.End;
                if (start >= 345 && start <= 355 && end >= 360 && end <=370 && numPage == 1) 
                {
                    posicionEsCorrecto = true;
                }
                /*************************************************************************/

                if (tablaEsCorrecto && posicionEsCorrecto)
                {
                    p1 = "CORRECTO";
                }
                else
                {
                    p1 = "INCORRECTO";
                }
            }
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();
        }

        private void Pregunta3()
        {
            Word.Tables tablas = docAlumno.Tables;
            if (tablas.Count == 1) 
            {
                Word.Table tabla = tablas[1];
                int filas = tabla.Rows.Count;
                int columnas = tabla.Columns.Count;                
                

                if (filas == 6 && columnas == 2 && tabla.Uniform ==  false)
                {
                    Word.Cell cell = tabla.Cell(filas, 1);

                    try
                    {
                        Word.Column col = cell.Column;
                    }
                    catch (Exception)
                    {
                        p1 = "CORRECTO";
                    }
                    
                }
                else
                    p1 = "INCORRECTO";

            }
            else
            {
                p1 = "INCORRECTO";
            }


            GuardarPuntaje();
            CerrarWords();
        }
        private void Pregunta4()
        {
            Word.Tables tablas = docAlumno.Tables;
            if (tablas.Count == 1)
            {
                Word.Table tabla = tablas[1];
                int filas = tabla.Rows.Count;
                int columnas = tabla.Columns.Count;

                Word.Columns col = tabla.Columns;

                if (filas == 5 && columnas == 2 && col.Last.Width == col.First.Width)
                {                    
                        p1 = "CORRECTO";
                }
                else
                    p1 = "INCORRECTO";

            }
            else
            {
                p1 = "INCORRECTO";
            }

            GuardarPuntaje();
            CerrarWords();
        }
        private void Pregunta5()
        {
            CerrarWords();
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();
            //<dc:description>Me parece que la información es confusa</dc:description>
            string cadenaAchequear1 = "<dc:description>Me parece que la información es confusa</dc:description>";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"docProps\core.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta6()
        {
            CerrarWords();
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();
            //
            string cadenaAchequear1 = "<b:Year>2015</b:Year>";
            string cadenaAchequear2 = ". (2013).";

            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"customXml\item1.xml"));
            String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\document.xml"));

            int elementos = contenidoDeArchivo1.Count();
            if (contenidoDeArchivo1[elementos-1].Contains(cadenaAchequear1) && !contenidoDeArchivo2[1].Contains(cadenaAchequear2))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta7()
        {
            string rutaPdf = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pdf";
            docAlumno.ExportAsFixedFormat(rutaPdf, Word.WdExportFormat.wdExportFormatPDF);

            StringBuilder text = new StringBuilder();
            using (PdfReader.PdfReader reader = new PdfReader.PdfReader(rutaPdf))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfReader.parser.PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }
            File.Delete(rutaPdf);

            string cadenaAchequear = "(iteración) \n \nDefinición";
            string contenidoDeArchivo = text.ToString();

            int marksNum =  docAlumno.Paragraphs.Count;//41 todos

            bool active = objWordAlumno.ActiveWindow.View.ShowAll;

            if (contenidoDeArchivo.Contains(cadenaAchequear) && marksNum == 40 && active)
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();
        }
        private void Pregunta8()
        {
            Word.Tables tablas = docAlumno.Tables;
            if (tablas.Count == 1) 
            {
                //Claves del éxito
                string cadenaAchequear = "Claves de éxito";
                string contenidoDeArchivo = tablas[1].Title;

                if (contenidoDeArchivo.Equals(cadenaAchequear))
                {
                    p1 = "CORRECTO";
                }
                else
                {
                    p1 = "INCORRECTO";
                }
            }
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();
        }

        private void Pregunta9()
        {
            Word.Tables tablas = docAlumno.Tables;
            if (tablas.Count == 1)
            {
                Word.Style estilo =  tablas[1].get_Style();
                
                //Claves del éxito
                string cadenaAchequear = "Tabla de cuadrícula 2 - Énfasis 4";
                string contenidoDeArchivo = estilo.NameLocal;

                if (contenidoDeArchivo.Equals(cadenaAchequear))
                {
                    p1 = "CORRECTO";
                }
                else
                {
                    p1 = "INCORRECTO";
                }
            }
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();
        }
        private void Pregunta10()
        {
            string rutaPdf = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pdf";
            docAlumno.ExportAsFixedFormat(rutaPdf, Word.WdExportFormat.wdExportFormatPDF);

            StringBuilder text = new StringBuilder();
            using (PdfReader.PdfReader reader = new PdfReader.PdfReader(rutaPdf))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfReader.parser.PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }
            File.Delete(rutaPdf);

            string cadenaAchequear = "LAS SERIES DE TV™";
            string contenidoDeArchivo = text.ToString();

            if (contenidoDeArchivo.Contains(cadenaAchequear))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();
        }
        private void Pregunta11()
        {
            CerrarWords();
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();
            //
            string cadenaAchequear1 = "<dc:title></dc:title>";
            string cadenaAchequear2 = "<dc:subject></dc:subject>";
            string cadenaAchequear3 = "<dc:creator></dc:creator>";
            string cadenaAchequear4 = "<cp:lastModifiedBy></cp:lastModifiedBy>";

            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"docProps\core.xml"));

            if (contenidoDeArchivo1[1].Contains(cadenaAchequear1) 
                && contenidoDeArchivo1[1].Contains(cadenaAchequear2)
                && contenidoDeArchivo1[1].Contains(cadenaAchequear3)
                && contenidoDeArchivo1[1].Contains(cadenaAchequear4))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta12()
        {
            
        }
        private void Pregunta13()
        {
           
        }
        private void Pregunta14()
        {
           
        }
        private void Pregunta15()
        {

        }
        private void Pregunta16()
        {
          
        }
        private void Pregunta17()
        {
        }
        private void Pregunta18()
        {
            
        }
        private void Pregunta19()
        {

        }

        private void Pregunta20()
        {
           
        }
        private void Pregunta21()
        {
        }
        private void Pregunta22()
        {
          
        }
        private void Pregunta23()
        {
          
        }
        private void Pregunta24()
        {
          
        }
        private void Pregunta25()
        {
           
        }
        private void Pregunta26()
        {
        }
        private void Pregunta27()
        {
           
        }
        private void Pregunta28()
        {

        }
        private void Pregunta29()
        {
        }
        private void Pregunta30()
        {
        }
        private void Pregunta31()
        {
        }
        private void Pregunta32()
        {
        }
        private void Pregunta33()
        {
        }
        private void Pregunta34()
        {
        }
        private void Pregunta35()
        {
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
