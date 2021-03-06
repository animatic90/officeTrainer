﻿using System;
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
using System.Text.RegularExpressions;

namespace Preguntas
{
    public class PreguntasWord
    {
        int idExamen;
        Word.Application objWordAlumno;
        Word.Document docAlumno;

        string p1 = "NO RESUELTA";
        string p2 = "NO EXISTE";
        string p3 = "NO EXISTE";
        string p4 = "NO EXISTE";
        string p5 = "NO EXISTE";
        string numeroPregunta;

        public void Pregunta(int numeroDePregunta, int examenIdExamen)
        {
            idExamen = examenIdExamen;
            numeroPregunta = numeroDePregunta.ToString();

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
            objWordAlumno.Visible = false;

            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.docx";
            object fileName = ruta;
            object missing = Type.Missing;

            docAlumno = objWordAlumno.Documents.Open(ruta, ReadOnly: false, Visible: true);            
        }
                
        private void CerrarWords()
        {
            try
            {
                docAlumno.Close();
                objWordAlumno.Quit();
            }
            catch (Exception){}
        }

        private void BorrarTemporales()
        {
            string rutaEjercicio = Application.StartupPath + @"\Documentos\Temp\Ejercicio";
            DirectoryInfo di = new DirectoryInfo(rutaEjercicio);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Attributes = FileAttributes.Normal;
                file.Delete();                
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Attributes = FileAttributes.Normal;
                dir.Delete(true);
            }
        }

        private void BorrarPreguntasTemporales()
        {
            string rutaEjercicio = @"C:\OfficeTrainnerResources\Temp";
            //string rutaEjercicio = Application.StartupPath + @"\Documentos\Temp\Ejercicio";
            DirectoryInfo di = new DirectoryInfo(rutaEjercicio);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Attributes = FileAttributes.Normal;
                file.Delete();
            }
        }

        static void DescomprimirZipWord()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";
            string ruta_7z = Application.StartupPath + @"\Documentos\Temp\7z";
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
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

        private string obtenerTextoDePdf()
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

            return text.ToString();
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
                numeroDePregunta = numeroPregunta,
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
            
            string textPdf = obtenerTextoDePdf();

            // Algoritmo recursivo (iteración) \n \nAutosimilitud\n  LOS FRACTALES
            // Algoritmo recursivo (iteración) \nAutosimilitud\n \n  LOS FRACTALES
            string cadenaAchequear1 = "Algoritmo recursivo (iteración) \n \nAutosimilitud\n  LOS FRACTALES";
            string cadenaAchequear2 = "Algoritmo recursivo (iteración) \nAutosimilitud\n \n  LOS FRACTALES";

            string contenidoDeArchivo = textPdf;

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
            BorrarPreguntasTemporales();
        }

        private void Pregunta2()
        {
            bool tablaEsCorrecto = false;
            bool posicionEsCorrecto = false;

            p1 = "INCORRECTO";

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
            }

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }

        private void Pregunta3()
        {
            p1 = "INCORRECTO";

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
            }
            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();

        }
        private void Pregunta4()
        {
            p1 = "INCORRECTO";
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
            }
            
            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta5()
        {
            CerrarWords();
            BorrarTemporales();

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

            BorrarPreguntasTemporales();
        }
        private void Pregunta6()
        {
            CerrarWords();
            BorrarTemporales();

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

            BorrarPreguntasTemporales();
        }
        private void Pregunta7()
        {
            string textPdf = obtenerTextoDePdf();

            string cadenaAchequear = "(iteración) \n \nDefinición";
            string contenidoDeArchivo = textPdf;

            int marksNum =  docAlumno.Paragraphs.Count;//41 todos

            bool active = objWordAlumno.ActiveWindow.View.ShowAll;

            if (contenidoDeArchivo.Contains(cadenaAchequear) && marksNum == 40 && active)
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta8()
        {
            p1 = "INCORRECTO";

            Word.Tables tablas = docAlumno.Tables;
            if (tablas.Count == 1) 
            {
                //Claves del éxito
                string cadenaAchequear = "Claves de éxito";
                string contenidoDeArchivo = tablas[1].Title;
                if (!String.IsNullOrEmpty(contenidoDeArchivo))
                {
                    if (contenidoDeArchivo.Equals(cadenaAchequear))
                    {
                        p1 = "CORRECTO";
                    }
                }  
            }

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }

        private void Pregunta9()
        {
            p1 = "INCORRECTO";
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
            }

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta10()
        {
            string textPdf = obtenerTextoDePdf();

            string cadenaAchequear = "LAS SERIES DE TV™";
            string contenidoDeArchivo = textPdf;

            if (contenidoDeArchivo.Contains(cadenaAchequear))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta11()
        {
            CerrarWords();
            BorrarTemporales();

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

            BorrarPreguntasTemporales();
        }
        private void Pregunta12()
        {
            //Se utiliza con mayor frecuencia una técnica llamada colecistectomía laparoscópica. En este procedimiento, se hacen incisiones quirúrgicas más pequeñas que permiten una recuperación más rápida. Los pacientes pueden salir del hospital un día después de la cirugía.
            CerrarWords();
            BorrarTemporales();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();
            //
            string cadenaAchequear1 = "Se utiliza con mayor frecuencia una técnica llamada colecistectomía laparoscópica. En este procedimiento, se hacen incisiones quirúrgicas más pequeñas que permiten una recuperación más rápida. Los pacientes pueden salir del hospital un día después de la cirugía.";

            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\document.xml"));

            if (!contenidoDeArchivo1[1].Contains(cadenaAchequear1))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
        }
        private void Pregunta13()
        {
            int numListas = docAlumno.Content.ListParagraphs.Count; //11

            string textPdf = obtenerTextoDePdf();

            string cadenaAchequear1 = "\nA. Ecografía abdominal";
            string cadenaAchequear2 = "\nF. Colangiopancreatografía";
            string cadenaAchequear3 = "\nK. Enzimas pancreáticas";

            string contenidoDeArchivo = textPdf;

            if (contenidoDeArchivo.Contains(cadenaAchequear1) &&
                contenidoDeArchivo.Contains(cadenaAchequear2) &&
                contenidoDeArchivo.Contains(cadenaAchequear3) &&
                numListas == 11)
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta14()
        {
            p1 = "INCORRECTO";

            BorrarTemporales();

            string textPdf = obtenerTextoDePdf();
            //\nCÁLCULOS BILIARES \nPrevención y Tratamiento \n \n  \n[FECHA] \n[NOMBRE DE LA COMPAÑÍA] \n[Dirección de la compañía] CÁLCULOS
            CerrarWords();
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();

            string ruta = Path.Combine(ruta_ResTem, @"word\glossary\document.xml");
            
            if (File.Exists(ruta))
            {
                string cadenaAchequear1 = "\nCÁLCULOS BILIARES \nPrevención y Tratamiento \n \n  \n[FECHA] \n[NOMBRE DE LA COMPAÑÍA] \n[Dirección de la compañía] CÁLCULOS";
                string contenidoDeArchivo = textPdf;

                if (contenidoDeArchivo.Contains(cadenaAchequear1))
                {
                    p1 = "CORRECTO";
                }
                    
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
            
        private void Pregunta15()
        {
            //Word.Range wrdRng = docAlumno.Bookmarks.get_Item("\\endofdoc").Range;
           var firstPage =  docAlumno.Sections[docAlumno.Sections.Count].PageSetup.Orientation;
           var lastPage = docAlumno.Sections[1].PageSetup.Orientation;

            if (firstPage == Word.WdOrientation.wdOrientLandscape && lastPage == Word.WdOrientation.wdOrientPortrait)
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta16()
        {
            p1 = "INCORRECTO";

            int palabras = docAlumno.Words.Count;//858 //864
            int vinculo = docAlumno.Hyperlinks.Count;//1

            if (palabras <= 864 && palabras >=858 && vinculo == 1)
            {
                //pancreáticas \n \nTratamiento
                //pancreáticas \nTratamiento
                //pancreáticas \n \n \nTratamiento
                string cadenaAchequear1 = "pancreáticas \n \nTratamiento";
                string cadenaAchequear2 = "pancreáticas \nTratamiento";
                string cadenaAchequear3 = "pancreáticas \n \n \nTratamiento";

                string textPdf = obtenerTextoDePdf();

                string contenidoDeArchivo = textPdf;

                if (contenidoDeArchivo.Contains(cadenaAchequear1) ||
                    contenidoDeArchivo.Contains(cadenaAchequear2) ||
                    contenidoDeArchivo.Contains(cadenaAchequear3))
                {
                    p1 = "CORRECTO";
                }
            }                

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta17()
        {
            //val=\"cyan\"/></w:rPr><w:lastRenderedPageBreak/><w:t>Definición de Fractal
            CerrarWords();
            BorrarTemporales();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();
            //
            string cadenaAchequear1 = "val=\"cyan\"/></w:rPr><w:lastRenderedPageBreak/><w:t>Definición de Fractal";

            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\document.xml"));

            if (contenidoDeArchivo1[1].Contains(cadenaAchequear1))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta18()
        {
            BorrarTemporales();
            string textPdf = obtenerTextoDePdf();

            /********no es efecitvo************
            Word.Shapes temp1 = docAlumno.Shapes;//7
            Word.ShapeRange rango = temp1.Range(7);
            float start = rango.Top;//-999999
            float end = rango.TopRelative;
            ***********************************/

            CerrarWords();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();
 
            string cadenaAchequear1 = "scaled=\"0\"/></w14:gradFill></w14:textFill></w:rPr><w:lastRenderedPageBreak/><w:t>Las series de Televisión";
            string cadenaAchequear2 = "val=\"C5C7CA\"/></w14:gs>";

            string cadenaAchequear3 = "TV \n \n \n \nLa";//TV \n \n \n \nLa

            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\document.xml"));
            string contenidoDeArchivo2 = textPdf;

            if (contenidoDeArchivo1[1].Contains(cadenaAchequear1) &&
                contenidoDeArchivo1[1].Contains(cadenaAchequear2) &&
                contenidoDeArchivo2.Contains(cadenaAchequear3))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta19()
        {
            CerrarWords();
            BorrarTemporales();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();

            string cadenaAchequear1 = "cirugía";
            string cadenaAchequear2 = "operación";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\document.xml"));

            MatchCollection numCirugia = Regex.Matches(contenidoDeArchivo[1], cadenaAchequear1);
            MatchCollection numOperacion = Regex.Matches(contenidoDeArchivo[1], cadenaAchequear2);

            if (numCirugia.Count == 0 && numOperacion.Count == 7)
            {
                p1 = "CORRECTO";
            }
            else
                p1 = "INCORRECTO";
            
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta20()
        {
            p1 = "INCORRECTO";

            string cadenaAchequear = "anticonceptivas. \n  \nDepósitos";//anticonceptivas. \n  \nDepósitos

            string textPdf = obtenerTextoDePdf();

            Word.Shapes temp = docAlumno.Shapes;
            if (temp.Count == 5 && textPdf.Contains(cadenaAchequear))
            {
                Word.Shape shape = temp[5];
                string cadenaAchequear1 = "5-Point Star";
                string cadenaAchequear2 = "Depósitos Biliares";

                string texto = shape.TextFrame.TextRange.Text; //Depósitos Biliares 

                if (shape.Name.Contains(cadenaAchequear1) && texto.Contains(cadenaAchequear2))  //5-Point Star 7 //5-Point Star 8
                {
                    float size = shape.TextFrame.TextRange.Font.Size; //9  
                    float top = shape.Top;//-999997 --abajo
                    float left = shape.Left;//-999998 --izquierda

                    if (size == 9 && top == -999997 && left == -999998)
                    {
                        p1 = "CORRECTO";
                    }
                } ;

            }

            CerrarWords();
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta21()
        {
            string textPdf = obtenerTextoDePdf();
            //vómitos\n \n  \n \n3 CÁLCULOS
            string cadenaAchequear = "vómitos\n \n  \n \n3 CÁLCULOS";
            string contenidoDeArchivo = textPdf;

            if (contenidoDeArchivo.Contains(cadenaAchequear))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta22()
        {
            p1 = "INCORRECTO";

            CerrarWords();
            BorrarTemporales();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();

            string cadenaAchequear1 = "Page Numbers (Bottom of Page)";
            string cadenaAchequear2 = "Cinta: curvada e inclinada hacia abajo";  
             
            string cadenaAchequear3 = "Cinta curvada hacia abajo";

            string ruta1 = Path.Combine(ruta_ResTem, @"word\footer1.xml");
            string ruta2 = Path.Combine(ruta_ResTem, @"word\footer2.xml");
            string ruta3 = Path.Combine(ruta_ResTem, @"word\footer3.xml");

            String[] contenidoDeArchivo1 = new String[3];
            String[] contenidoDeArchivo2 = new String[3];
            String[] contenidoDeArchivo3 = new String[3];

            if (File.Exists(ruta1))
            {
                contenidoDeArchivo1 = File.ReadAllLines(ruta1);

                if (File.Exists(ruta2))
                    contenidoDeArchivo2 = File.ReadAllLines(ruta2);
                else
                    contenidoDeArchivo2 = File.ReadAllLines(ruta1);
                if (File.Exists(ruta3))
                    contenidoDeArchivo3 = File.ReadAllLines(ruta3);
                else
                    contenidoDeArchivo3 = File.ReadAllLines(ruta1);

                if ((contenidoDeArchivo1[1].Contains(cadenaAchequear1) && (contenidoDeArchivo1[1].Contains(cadenaAchequear2) || contenidoDeArchivo1[1].Contains(cadenaAchequear3))) ||
                    (contenidoDeArchivo2[1].Contains(cadenaAchequear1) && (contenidoDeArchivo2[1].Contains(cadenaAchequear2) || contenidoDeArchivo2[1].Contains(cadenaAchequear3))) ||
                    (contenidoDeArchivo3[1].Contains(cadenaAchequear1) && (contenidoDeArchivo3[1].Contains(cadenaAchequear2) || contenidoDeArchivo3[1].Contains(cadenaAchequear3))))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta23()
        {
            p1 = "INCORRECTO";

            BorrarTemporales();

            int listas = docAlumno.Content.ListParagraphs.Count; //4
            //imagedata r:id="rId1" o:title="tv"          ---->     imagedata r:id=\"rId1\" o:title=\"tv\"
            //<w:numPicBullet w:numPicBulletId="0">       ---->     w:numPicBullet w:numPicBulletId=\"0\"

            CerrarWords();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";
            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());
            ComprobarDescompresion();

            string ruta = Path.Combine(ruta_ResTem, @"word\_rels\numbering.xml.rels");

            if (File.Exists(ruta))
            {
                string cadenaAchequear1 = "imagedata r:id=\"rId1\" o:title=\"tv\"";
                string cadenaAchequear2 = "w:numPicBullet w:numPicBulletId=\"0\"";

                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\numbering.xml"));
                int index = contenidoDeArchivo.Length - 1;

                if (contenidoDeArchivo[index].Contains(cadenaAchequear1) &&
                    contenidoDeArchivo[index].Contains(cadenaAchequear2) &&
                    listas == 4)
                {
                    p1 = "CORRECTO";
                }

            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta24()
        {
            //string=\"BORRADOR\"/></v:shape>
            //<v:shape id=\"PowerPlusWaterMark
            CerrarWords();
            BorrarTemporales();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();

            string cadenaAchequear1 = "string=\"BORRADOR\"/></v:shape>";
            string cadenaAchequear2 = "<v:shape id=\"PowerPlusWaterMark";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\header1.xml"));


            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) &&
                contenidoDeArchivo[1].Contains(cadenaAchequear2))
            {
                p1 = "CORRECTO";
            }
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta25()
        {
            int listas = docAlumno.Content.ListParagraphs.Count; //7

            string textPdf = obtenerTextoDePdf();

            string cadenaAchequear1 = "\n1. El matemático";
            string cadenaAchequear2 = "\n2. La geometría";
            string cadenaAchequear3 = "\n3. Sin embargo";
            string cadenaAchequear4 = "\n4. La geometría";
            string cadenaAchequear5 = "\n5. A menudo";
            string cadenaAchequear6 = "\n6. La característica";
            string cadenaAchequear7 = "\n7. Los fractales";


            string contenidoDeArchivo = textPdf;

            if (contenidoDeArchivo.Contains(cadenaAchequear1) &&
                contenidoDeArchivo.Contains(cadenaAchequear2) &&
                contenidoDeArchivo.Contains(cadenaAchequear3) &&
                contenidoDeArchivo.Contains(cadenaAchequear4) &&
                contenidoDeArchivo.Contains(cadenaAchequear5) &&
                contenidoDeArchivo.Contains(cadenaAchequear6) &&
                contenidoDeArchivo.Contains(cadenaAchequear7) &&
                listas == 7)
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();

            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta26()
        {
            Word.WdLineSpacing reglaDeEspaciado = docAlumno.Sections[1].Range.Paragraphs.Format.LineSpacingRule;
            //wdLineSpace1pt5

            string cadenaAchequear1 = "wdLineSpace1pt5";

            string contenidoDeArchivo = reglaDeEspaciado.ToString();

            if (contenidoDeArchivo.Contains(cadenaAchequear1))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta27()
        {
            p1 = "INCORRECTO";

            string textPdf = obtenerTextoDePdf();
            string cadenaAchequear1 = "(iteración) \n \nTodos";
            string cadenaAchequear2 = "(iteración) \nTodos";
            //(iteración) \n \nTodos
            //(iteración) \nTodos
            if (textPdf.Contains(cadenaAchequear1) || textPdf.Contains(cadenaAchequear2))
            {
                // var temp = docAlumno.Content.Text.IndexOf("todos los fractales tienen algo en común");
                int start = docAlumno.Content.Text.IndexOf("Todos los fractales tienen algo en común") - 15;
                int end = docAlumno.Content.Text.IndexOf("Todos los fractales tienen algo en común") + 25;

                Word.Range range = docAlumno.Range(Start: start, End: end);

                var negrita = Math.Abs(range.Font.Bold);
                var cursiva = Math.Abs(range.Font.Italic);
                int tamaño = Convert.ToInt32(range.Font.Size);//22

                Word.WdParagraphAlignment alineacion = range.Paragraphs.Alignment;//wdAlignParagraphLeft
                Word.WdCharacterCase tipo = range.Case;//wdTitleSentence

                string cadenaAchequear3 = "wdAlignParagraphLeft";
                string cadenaAchequear4 = "wdTitleSentence";

                string contenidoDeArchivo1 = alineacion.ToString();
                string contenidoDeArchivo2 = tipo.ToString();

                if (contenidoDeArchivo1.Contains(cadenaAchequear3) &&
                    contenidoDeArchivo2.Contains(cadenaAchequear4) &&
                    tamaño == 22 && negrita == 1 && cursiva == 1)
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta28()
        {
            p1 = "INCORRECTO";

            int start = docAlumno.Content.Text.IndexOf("Todos los fractales tienen algo en común") - 15;
            int end = docAlumno.Content.Text.IndexOf("Todos los fractales tienen algo en común") + 25;

            if (start >= 0)
            {
                Word.Range range = docAlumno.Range(Start: start, End: end);

                Word.Style estilo = range.Paragraphs.get_Style();

                string tipo = estilo.NameLocal; //"Cita"
                string cadenaAchequear = "Cita";

                if (tipo.Contains(cadenaAchequear))
                {
                    p1 = "CORRECTO";
                }
            }      

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta29()
        {
            p1 = "INCORRECTO";

            Word.Shapes shapes = docAlumno.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Shapes;//1

            if (shapes.Count == 1)
            {
                Word.Range rango = docAlumno.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                string tipo = rango.Case.ToString();//wdTitleWord
                string texto = rango.Text;//"Los Fractales\r\r"
                string tipoFuente = rango.Font.Name;//"Calibri"
                float tamaño = rango.Font.Size;//10
                int color = Math.Abs(Convert.ToInt32(rango.Font.Color));//-738131969
                string indexColor = rango.Font.ColorIndex.ToString();//wdYellow
                string alineacion = rango.Paragraphs.Alignment.ToString();//wdAlignParagraphLeft

                if (tipo.Contains("wdTitleWord") && texto.Contains("Los Fractales\r\r") &&
                    tipoFuente.Contains("Calibri") && tamaño == 10 && color == 738131969 &&
                    indexColor.Contains("wdYellow") && alineacion.Contains("wdAlignParagraphLeft"))
                {
                    p1 = "CORRECTO";
                }      
            }

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta30()
        {
            p1 = "INCORRECTO";

            int numMarcadores = docAlumno.Bookmarks.Count;//1

            if (numMarcadores == 1)
            {
                Word.Bookmark marcador = docAlumno.Bookmarks[1];
                int start = marcador.Start;//326
                int end = marcador.End;
                string name = marcador.Name;//Tipo

                if (start == 326 && end == 326 && name.Equals("Tipo"))
                {
                    p1 = "CORRECTO";
                }     
            }

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta31()
        {
            int numListas = docAlumno.Content.ListParagraphs.Count; //4
            string textPdf = obtenerTextoDePdf();
            //de éstos. \n \nPara más información acerca de las mejores Series, diríjase a la siguiente página: \nhttp: www.imdb.com/
            //de éstos. \n \n \nPara más información acerca de las mejores Series, diríjase a la siguiente página: \nhttp: www.imdb.com/
            string cadenaAchequear1 = "de éstos. \n \nPara más información acerca de las mejores Series, diríjase a la siguiente página: \nhttp: www.imdb.com/";
            string cadenaAchequear2 = "de éstos. \n \n \nPara más información acerca de las mejores Series, diríjase a la siguiente página: \nhttp: www.imdb.com/";

            string contenidoDeArchivo = textPdf;
                    
            if ((contenidoDeArchivo.Contains(cadenaAchequear1) || contenidoDeArchivo.Contains(cadenaAchequear2)) &&
                numListas == 4)

                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }

        private void Pregunta32()
        {
            //a:bevelT w="139700" h="139700" prst="divot"  ------>          a:bevelT w=\"139700\" h=\"139700\" prst=\"divot\"
            //effectExtent l="38100" t="57150" r="38100" b="38100" ------>  effectExtent l=\"38100\" t=\"57150\" r=\"38100\" b=\"38100\"

            CerrarWords();
            BorrarTemporales();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());

            ComprobarDescompresion();
            //
            string cadenaAchequear1 = "a:bevelT w=\"139700\" h=\"139700\" prst=\"divot\"";
            string cadenaAchequear2 = "effectExtent l=\"38100\" t=\"57150\" r=\"38100\" b=\"38100\"";

            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\document.xml"));

            int index = contenidoDeArchivo1.Length - 1;
            if (contenidoDeArchivo1[index].Contains(cadenaAchequear1) && contenidoDeArchivo1[index].Contains(cadenaAchequear2))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta33()
        {
            p1 = "INCORRECTO";

            Word.Shapes shapes = docAlumno.Shapes;//4
            Word.InlineShapes iShapes = docAlumno.InlineShapes;//1

            if (shapes.Count == 4 && iShapes.Count == 1)
            {
                string tipo = iShapes[1].Type.ToString();//wdInlineShapePicture
                var rango = iShapes[1].Range;
                int start = rango.Start;//2365
                int end = rango.End;//2366

                if (tipo.Equals("wdInlineShapePicture") &&
                    start == 2365 && end == 2366)
                {
                    p1 = "CORRECTO";
                }                    
            }

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
        }
        private void Pregunta34()
        {
            p1 = "INCORRECTO";
            BorrarTemporales();

            Word.Shapes shapes = docAlumno.Shapes;//4
            Word.InlineShapes iShapes = docAlumno.InlineShapes;//1

            if (shapes.Count == 4 && iShapes.Count == 1)
            {
                string tipo = iShapes[1].Type.ToString();//wdInlineShapePicture
                var rango = iShapes[1].Range;
                int start = rango.Start;//528
                int end = rango.End;//529

                //name=\"Eleven.jpg\"/><pic

                CerrarWords();
                string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";
                Task task1 = Task.Factory.StartNew(() => DescomprimirZipWord());
                ComprobarDescompresion();

                string cadenaAchequear = "name=\"Eleven.jpg\"/><pic";

                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"word\document.xml"));
                                
                if (contenidoDeArchivo[1].Contains(cadenaAchequear) && 
                    tipo.Equals("wdInlineShapePicture") &&
                    start == 528 && end == 529)
                    p1 = "CORRECTO";
                else
                    p1 = "INCORRECTO";
            }

            CerrarWords();
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta35()
        {
            p1 = "INCORRECTO";
            Word.InlineShapes iShapes = docAlumno.InlineShapes;
                
            if (iShapes.Count == 1)
            {
                Word.InlineShape smart = iShapes[1];
                int pagina = smart.Range.get_Information(Word.WdInformation.wdActiveEndPageNumber); //3
                MsoTriState isSmart = smart.HasSmartArt; //comprobar que sea smartart

                if (isSmart == MsoTriState.msoTrue && pagina == 3)
                {
                    string name = smart.SmartArt.Layout.Name;//"Lista con rectángulos en vertical"
                    int numeroNodos = smart.SmartArt.AllNodes.Count;//5

                    if (numeroNodos == 5)
                    {
                        SmartArtNode nodo1 = smart.SmartArt.AllNodes[1];
                        string texto1 = nodo1.TextFrame2.TextRange.Text;//Dolor abdominal

                        SmartArtNode nodo2 = smart.SmartArt.AllNodes[2];//Fiebre
                        string texto2 = nodo2.TextFrame2.TextRange.Text;

                        if (texto1.Equals("Dolor abdominal") && texto2.Equals("Fiebre"))
                        {
                            p1 = "CORRECTO";
                        }
                    }
                }
            }

            GuardarPuntaje();
            CerrarWords();

            BorrarPreguntasTemporales();
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
