using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

using iTextSharp.text;
using PdfReader = iTextSharp.text.pdf;

namespace Preguntas
{
    public class PreguntasPowerPoint
    {
        PowerPoint.Application ObjPowerPointAlumno;
        PowerPoint.Presentation pptAlumno;
        int idExamen;
        //Process[] powerPointProcsOld;

        string p1 = "NO RESUELTA";
        string p2 = "NO EXISTE";
        string p3 = "NO EXISTE";
        string p4 = "NO EXISTE";
        string p5 = "NO EXISTE";
        string numeroPregunta;

        /***********Propiedades de Impresion**********/
        string numeroCopias; //
        string slidesPorHoja; //
        string color;//
        string rango;//
        string intercalar;//
        /*********************************************/

        public void Pregunta(int numeroDePregunta, int examenIdExamen)
        {
           // powerPointProcsOld = Process.GetProcessesByName("POWERPNT");
            idExamen = examenIdExamen;
            numeroPregunta = numeroDePregunta.ToString();
            //AbrirPowerPoints(numeroDePregunta);

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

        public void PropiedadesDeImpresion(string NumeroCopias, string SlidesPorHoja, string Color, string Rango, string Intercalar)
        {
            numeroCopias = NumeroCopias;
            slidesPorHoja = SlidesPorHoja;
            color = Color;
            rango = Rango;
            intercalar = Intercalar;
        }

      /*  private void AbrirPowerPoints(int numeroDePregunta)
        {

            ObjPowerPointAlumno = new PowerPoint.Application();


            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pptx";
            pptAlumno = ObjPowerPointAlumno.Presentations.Open(ruta);

        }*/

        private void CerrarPowerPoints()
        {
            try
            {
                pptAlumno.Close();
                ObjPowerPointAlumno.Quit();
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

        static void DescomprimirZipPowerPoint()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";
            string ruta_7z = Application.StartupPath + @"\Documentos\Temp\7z";
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            //info.CreateNoWindow = true;
            info.FileName = "7z.exe";
            info.WorkingDirectory = ruta_7z;
            info.Arguments = "x " + ruta_ResTem + "Ejercicio.pptx" + " " + "-o" + ruta_ResTem + "Ejercicio";

            Process.Start(info);
        }

        private void ComprobarDescompresion()
        {
            for (int i = 0; i < 10; i++)
            {
                string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio\ppt\presentation.xml";

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
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:transition spd=\"slow\"><p:randomBar dir=\"vert\"/></p:transition>";
                        
            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }                

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta2()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\ppt\slides\";
            
            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:cNvPr id=\"4\" name=\"3 Imagen\" descr=\"imagesCALRA574.jpg\"/>";                                      
            string cadenaAchequear2 = "<p:animEffect transition=\"in\" filter=\"checkerboard(across)\">";            
            string cadenaAchequear3 = "<a:t>pasar por casillas controladas por piezas contrarias.</a:t>";
            string cadenaAchequear4 = "<a:t>, conocido como tablas o </a";
            string cadenaAchequear5 = "<a:t>, de forma que una de ellas será necesariamente capturada.</a:t>";
            string cadenaAchequear6 = "<a:t> Consisten en elegir cuál entre todos los elementos es el más importante.</a:t>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide7.xml")) && 
                File.Exists(Path.Combine(ruta_ResTem, @"slide8.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide9.xml")) && 
                File.Exists(Path.Combine(ruta_ResTem, @"slide10.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide11.xml")))
                {
                    String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide6.xml"));
                    String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide7.xml"));
                    String[] contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide8.xml"));
                    String[] contenidoDeArchivo4 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide9.xml"));
                    String[] contenidoDeArchivo5 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide10.xml"));
                    String[] contenidoDeArchivo6 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide11.xml"));

                    if (contenidoDeArchivo1[contenidoDeArchivo1.Length - 1].Contains(cadenaAchequear1) && 
                        contenidoDeArchivo2[contenidoDeArchivo2.Length - 1].Contains(cadenaAchequear2) && 
                        contenidoDeArchivo3[contenidoDeArchivo3.Length - 1].Contains(cadenaAchequear3) && 
                        contenidoDeArchivo4[contenidoDeArchivo4.Length - 1].Contains(cadenaAchequear4) && 
                        contenidoDeArchivo5[contenidoDeArchivo5.Length - 1].Contains(cadenaAchequear5) && 
                        contenidoDeArchivo6[contenidoDeArchivo6.Length - 1].Contains(cadenaAchequear6))
                        {
                            p1 = "CORRECTO";
                        }
                }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta3()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "Geraldine Huerta";
            string cadenaAchequear2 = "<dc:title>El juego del Ajedrez</dc:title>";
            string cadenaAchequear3 = "<dc:subject>Un juego educativo</dc:subject>";
            string cadenaAchequear4 = "<cp:contentStatus>En revisión</cp:contentStatus>";

            if (!File.Exists(Path.Combine(ruta_ResTem, @"docProps\custom.xml")))
            {
                String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"docProps\core.xml"));

                int indice = contenidoDeArchivo1.Length - 1;
                if (!contenidoDeArchivo1[indice].Contains(cadenaAchequear1) && 
                    !contenidoDeArchivo1[indice].Contains(cadenaAchequear2) &&
                    !contenidoDeArchivo1[indice].Contains(cadenaAchequear3) && 
                    contenidoDeArchivo1[indice].Contains(cadenaAchequear4))
                {
                    p1 = "CORRECTO";
                }                    
            }            
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta4()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "fmtScheme name=\"Sector\">";
            string cadenaAchequear2 = "<a:clrScheme name=\"Sector\">";
            string cadenaAchequear3 = "<a:fontScheme name=\"Sector\">";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\theme\theme1.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\theme\theme1.xml"));
                int indice = contenidoDeArchivo.Length - 1;

                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) &&
                    contenidoDeArchivo[indice].Contains(cadenaAchequear2) &&
                    contenidoDeArchivo[indice].Contains(cadenaAchequear3))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta5()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "peón</a:t></a:r></a:p></p:txBody></p:sp><p:sp><p:nvSpPr><p:cNvPr id=";
            string cadenaAchequear2 = "</p:nvGrpSpPr><p:grpSpPr><a:xfrm><a:off x=\"503434\" y=\"1268016\"/><a:ext cx=\"698642\" cy=\"2803734\"/><a:chOff x=\"503434\" y=\"1268016\"/><a:chExt cx=\"698642\" cy=\"2803734\"/></a:xfrm></p:grpSpPr><p:sp><p:nvSpPr>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (!contenidoDeArchivo[1].Contains(cadenaAchequear1) &&
                    contenidoDeArchivo[1].Contains(cadenaAchequear2))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta6()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<dgm:catLst><dgm:cat type=\"colorful\"";
            string cadenaAchequear2 = "/colors/colorful3\">";
            string cadenaAchequear3 = "<a:schemeClr val=\"accent3\"";
            string cadenaAchequear4 = "<a:schemeClr val=\"accent4\"";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\diagrams\colors1.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\diagrams\colors1.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) &&
                    contenidoDeArchivo[indice].Contains(cadenaAchequear2) &&
                    contenidoDeArchivo[indice].Contains(cadenaAchequear3) &&
                    contenidoDeArchivo[indice].Contains(cadenaAchequear4))
                {
                    p1 = "CORRECTO";
                }
            } 
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta7()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:childTnLst><p:seq concurrent=\"1\" nextAc=\"seek\"><p:cTn id=\"2\" dur=\"indefinite\" nodeType=\"mainSeq\"><p:childTnLst><p:par><p:cTn id=\"3\" fill=\"hold\"><p:stCondLst><p:cond delay=\"indefinite\"/><p:cond evt=\"onBegin\" delay=\"0\"><p:tn val=\"2\"/></p:cond></p:stCondLst><p:childTnLst><p:par><p:cTn id=\"4\" fill=\"hold\"><p:stCondLst><p:cond delay=\"0\"/></p:stCondLst><p:childTnLst>";
            string cadenaAchequear2 = "presetClass=\"entr\" presetSubtype=\"8\" fill=\"hold\" nodeType=\"withEffect\"><p:stCondLst><p:cond delay=\"0\"/></p:stCondLst><p:childTnLst><p:set><p:cBhvr><p:cTn id=\"6\" dur=\"1\" fill=\"hold\"><p:stCondLst><p:cond delay=\"0\"/></p:stCondLst></p:cTn><p:tgtEl><p:spTgt spid=\"3\"><p:txEl><p:pRg st=\"0\" end=\"0\"/></p:txEl></p:spTgt></p:tgtEl><p:attrNameLst><p:attrName>style.visibility</p:attrName></p:attrNameLst></p:cBhvr><p:to><p:strVal val=\"visible\"/></p:to></p:set><p:animEffect transition=\"in\" filter=\"wipe(left)\"><p:cBhvr><p:cTn id=\"7\" dur=\"500\"/><p:tgtEl><p:spTgt spid=\"3\"><p:txEl><p:pRg st=\"0\" end=\"0\"/></p:txEl></p:spTgt></p:tgtEl></p:cBhvr></p:animEffect></p:childTnLst></p:cTn></p:par></p:childTnLst></p:cTn></p:par><p:par><p:cTn id=\"8\" fill=\"hold\"><p:stCondLst><p:cond delay=\"500\"/>";
            string cadenaAchequear3 = "nodeType=\"afterEffect\"><p:stCondLst><p:cond delay=\"1000\"/></p:stCondLst><p:childTnLst><p:set><p:cBhvr><p:cTn id=\"10\" dur=\"1\" fill=\"hold\"><p:stCondLst><p:cond delay=\"0\"/></p:stCondLst></p:cTn><p:tgtEl><p:spTgt spid=\"3\"><p:txEl><p:pRg st=\"1\" end=\"1\"";
            string cadenaAchequear4 = "transition=\"in\" filter=\"wipe(left)\"><p:cBhvr><p:cTn id=\"11\" dur=\"500\"/><p:tgtEl><p:spTgt spid=\"3\"><p:txEl><p:pRg st=\"1\" end=\"1\"/></p:txEl></p:spTgt></p:tgtEl></p:cBhvr></p:animEffect></p:childTnLst></p:cTn></p:par></p:childTnLst></p:cTn></p:par><p:par><p:cTn id=\"12\" fill=\"hold\"><p:stCondLst><p:cond delay=\"2000\"/>";
            string cadenaAchequear5 = "spid=\"3\"><p:txEl><p:pRg st=\"2\" end=\"2\"/></p:txEl></p:spTgt></p:tgtEl><p:attrNameLst><p:attrName>style.visibility</p:attrName></p:attrNameLst></p:cBhvr><p:to><p:strVal val=\"visible\"/></p:to></p:set><p:animEffect transition=\"in\" filter=\"wipe(left)\"";
            string cadenaAchequear6 = "delay=\"3500\"/></p:stCondLst><p:childTnLst><p:par><p:cTn id=\"17\" presetID=\"22\" presetClass=\"entr\" presetSubtype=\"8\" fill=\"hold\" nodeType=\"afterEffect\"><p:stCondLst><p:cond delay=\"1000\"/></p:stCondLst><p:childTnLst><p:set><p:cBhvr><p:cTn id=\"18\" dur=\"1\" fill=\"hold\"><p:stCondLst><p:cond delay=\"0\"/></p:stCondLst></p:cTn><p:tgtEl><p:spTgt spid=\"3\"><p:txEl><p:pRg st=\"3\" end=\"3\"";
            string cadenaAchequear7 = "delay=\"5000\"/></p:stCondLst><p:childTnLst><p:par><p:cTn id=\"21\" presetID=\"22\" presetClass=\"entr\" presetSubtype=\"8\" fill=\"hold\" nodeType=\"afterEffect\"><p:stCondLst><p:cond delay=\"1000\"/></p:stCondLst><p:childTnLst><p:set><p:cBhvr><p:cTn id=\"22\" dur=\"1\" fill=\"hold\"><p:stCondLst><p:cond delay=\"0\"/></p:stCondLst></p:cTn><p:tgtEl><p:spTgt spid=\"3\"><p:txEl><p:pRg st=\"4\" end=\"4\"";
            string cadenaAchequear8 = "transition=\"in\" filter=\"wipe(left)\"><p:cBhvr><p:cTn id=\"23\" dur=\"500\"/><p:tgtEl><p:spTgt spid=\"3\"><p:txEl><p:pRg st=\"4\" end=\"4\"";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && contenidoDeArchivo[indice].Contains(cadenaAchequear2) && 
                    contenidoDeArchivo[indice].Contains(cadenaAchequear3) && contenidoDeArchivo[indice].Contains(cadenaAchequear4) && 
                    contenidoDeArchivo[indice].Contains(cadenaAchequear5) && contenidoDeArchivo[indice].Contains(cadenaAchequear6) && 
                    contenidoDeArchivo[indice].Contains(cadenaAchequear7) && contenidoDeArchivo[indice].Contains(cadenaAchequear8))
                {
                    p1 = "CORRECTO";
                }
            }
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta8()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:cNvPr id=\"6\" name=\"Imagen 5\"/><p:cNvPicPr><a:picLocks noChangeAspect=\"1\"/></p:cNvPicPr><p:nvPr/></p:nvPicPr><p:blipFill><a:blip r:embed=\"rId2\"/><a:stretch><a:fillRect/></a:stretch></p:blipFill><p:spPr><a:xfrm><a:off x=\"5867400\" y=\"1563624\"/><a:ext cx=\"2517866\" cy=\"2243522\"/><";
            string cadenaAchequear2 = "a:gridCol";
            string cadenaAchequear3 = "<a:tc><a:txBody><a:bodyPr/><a:lstStyle/><a:p><a:endParaRPr";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                MatchCollection numColumnas = Regex.Matches(contenidoDeArchivo[indice], cadenaAchequear2);
                MatchCollection numFilas = Regex.Matches(contenidoDeArchivo[indice], cadenaAchequear3);

                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && numFilas.Count == 20)
                {
                    if (numColumnas.Count == 5 || numColumnas.Count == 10)
                        p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta9()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "main\" meth=\"cycle\" id=\"13\"><a:schemeClr val=\"accent6\"/><a:schemeClr val=\"accent5\"/><a:schemeClr val=\"accent4\"/><cs:variation/><cs:variation><a:lumMod val=\"60000\"/>";
            string cadenaAchequear2 = "/main\" id=\"293\"><cs:axisTitle>";                                      
            string cadenaAchequear3 = "<a:schemeClr val=\"bg1\"";                                      
            string cadenaAchequear4 = "val=\"tx1\"";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\charts\colors1.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"ppt\charts\style1.xml")))
            {
                String[] contenidoDeArchivoA = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\colors1.xml"));
                String[] contenidoDeArchivoB = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\style1.xml"));
                MatchCollection numText = Regex.Matches(contenidoDeArchivoB[0], cadenaAchequear4);

                if (numText.Count == 25 && contenidoDeArchivoA[contenidoDeArchivoA.Length - 1].Contains(cadenaAchequear1) &&
                    contenidoDeArchivoB[contenidoDeArchivoB.Length - 1].Contains(cadenaAchequear2) && contenidoDeArchivoB[0].Contains(cadenaAchequear3))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta10()
        {
            if (numeroCopias.Equals("4") && slidesPorHoja.Equals("ppPrintOutputTwoSlideHandouts") &&
                color.Equals("ppPrintColor") && rango.Equals("ppPrintAll") && intercalar.Equals("msoFalse"))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";
            GuardarPuntaje();
        }

        private void Pregunta11()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:bg><p:bgPr><a:gradFill><a:gsLst><a:gs pos=\"0\"><a:schemeClr val=\"accent1\"><a:lumMod val=\"5000\"/><a:lumOff val=\"95000\"/></a:schemeClr></a:gs><a:gs pos=\"74000\"><a:schemeClr val=\"accent1\"><a:lumMod val=\"45000\"/><a:lumOff val=\"55000\"/></a:schemeClr></a:gs><a:gs pos=\"83000\"><a:schemeClr val=\"accent1\"><a:lumMod val=\"45000\"/><a:lumOff val=\"55000\"/></a:schemeClr></a:gs><a:gs pos=\"100000\"><a:schemeClr val=\"accent1\"><a:lumMod val=\"30000\"/><a:lumOff val=\"70000\"/></a:schemeClr></a:gs></a:gsLst><a:lin ang=\"5400000\" scaled=\"1\"/></a:gradFill><a:effectLst/></p:bgPr>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta12()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p14:trim st=\"1500\" end=\"2801\"/></p14:media>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide7.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide7.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }
                
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta13()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "tp://schemas.microsoft.com/office/drawing/2010/main\" val=\"0\"/></a:ext></a:extLst></a:blip><a:stretch><a:fillRect/></a:stretch></p:blipFill><p:spPr><a:xfrm><a:off x=\"4128746\" y=\"1953908\"/><a:ext cx=\"2515284\" cy=\"2243747\"/></a:xfrm><a:prstGeom";
            string cadenaAchequear2 = "<p:ph sz=\"half\" idx=\"1\"/>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && contenidoDeArchivo[indice].Contains(cadenaAchequear2))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta14()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<a:off x=\"3388530\" y=\"2917294\"/><a:ext cx=\"1981200\" cy=\"1767320\"/>";
            string cadenaAchequear2 = "<a:off x=\"3924300\" y=\"3468422\"/><a:ext cx=\"909661\" cy=\"665064\"/>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && contenidoDeArchivo[indice].Contains(cadenaAchequear2))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta15()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:cNvPr id=\"4\" name=\"Date Placeholder 3\"/><p:cNvSpPr><a:spLocks noGrp=\"1\"/></p:cNvSpPr><p:nvPr><p:ph type=\"dt\" sz=\"half\" idx=\"2\"/>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slideMasters\slideMaster1.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slideMasters\slideMaster1.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (!contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta16()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();
           
            string cadenaAchequear1 = "spc=\"300\" dirty=\"0\" smtClean=\"0\"><a:effectLst><a:outerShdw blurRad=\"38100\" dist=\"38100\" dir=\"2700000\" algn=\"tl\"><a:srgbClr val=\"000000\"><a:alpha val=\"43137\"";
            string cadenaAchequear2 = "spc=\"300\" dirty=\"0\"><a:effectLst><a:outerShdw blurRad=\"38100\" dist=\"38100\" dir=\"2700000\" algn=\"tl\"><a:srgbClr val=\"000000\">";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide1.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide1.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && contenidoDeArchivo[indice].Contains(cadenaAchequear2))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta17()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

           /*************chartex**************/
            string cadenaAchequear1 = "<cx:numDim type=\"val\">";
            string cadenaAchequear2 = "Categoría";

            /***************slide6****************/
            string cadenaAchequear3 = "id=\"3\" name=\"Marcador de contenido 2\"";
            string cadenaAchequear4 = "schemas.microsoft.com/office/drawing/2014/chartex";

            /***********style***********/
            string cadenaAchequear5 = "schemas.openxmlformats.org/drawingml/2006/main\" id=\"366\"";


            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\charts\style1.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml")))
            {

                String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml"));
                String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\style1.xml"));
                String[] contenidoDeArchivo3 = new String[1];

                string temp = contenidoDeArchivo3[0];

                if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\charts\chartEx1.xml")))
                    contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\chartE1.xml"));
                if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\charts\chart1.xml")))
                    contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\chart1.xml"));
                
                if (!contenidoDeArchivo1[contenidoDeArchivo1.Length - 1].Contains(cadenaAchequear3) && 
                    contenidoDeArchivo1[contenidoDeArchivo1.Length - 1].Contains(cadenaAchequear4) && 
                    contenidoDeArchivo2[contenidoDeArchivo2.Length - 1].Contains(cadenaAchequear5) && 
                    contenidoDeArchivo3[contenidoDeArchivo3.Length - 1].Contains(cadenaAchequear1) && 
                    !contenidoDeArchivo3[contenidoDeArchivo3.Length - 1].Contains(cadenaAchequear2))
                  {
                    p1 = "CORRECTO";
                  }     
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta18()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pptx";
            string rutaPdf = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pdf";

            ObjPowerPointAlumno = new PowerPoint.Application();
            pptAlumno = ObjPowerPointAlumno.Presentations.Open(ruta);

            pptAlumno.SaveCopyAs(rutaPdf, PowerPoint.PpSaveAsFileType.ppSaveAsPDF, MsoTriState.msoFalse);

            StringBuilder text = new StringBuilder();
            using (PdfReader.PdfReader reader = new PdfReader.PdfReader(rutaPdf))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfReader.parser.PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }
            File.Delete(rutaPdf);
            CerrarPowerPoints();

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "Producción de ATP";
            string cadenaAchequear2 = "La producción de ATP por la oxidación de azucares orgánicos";
            string cadenaAchequear3 = "Descomposición de alimentos. Liberación de energia";
            string cadenaAchequear4 = "<mc:Choice xmlns:v=\"urn:schemas-microsoft-com:vml\" Requires=\"v\"><p:oleObj spid=\"_x0000_s1026\" name=";
            
            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide5.xml")))
            {
                string contenidoDeArchivo1 = text.ToString();
                String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide5.xml"));

                if (contenidoDeArchivo1.Contains(cadenaAchequear1) && contenidoDeArchivo1.Contains(cadenaAchequear2) &&
                    contenidoDeArchivo1.Contains(cadenaAchequear3) && contenidoDeArchivo2[contenidoDeArchivo2.Length - 1].Contains(cadenaAchequear4))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta19()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();
            string cadenaAchequear1 = "<a:ln w=\"57150\"/><a:scene3d><a:camera prst=\"orthographicFront\"/><a:lightRig rig=\"threePt\" dir=\"t\"/></a:scene3d><a:sp3d><a:bevelT prst=\"slope\"/></a:sp3d></p:spPr><p:style><a:lnRef idx=\"1\"><a:schemeClr val=\"accent4\"/></a:lnRef><a:fillRef idx=\"3\"><a:schemeClr val=\"accent4\"/></a:fillRef><a:effectRef idx=\"2\"><a:schemeClr val=\"accent4\"/></a:effectRef><a:fontRef idx=\"minor\"><a:schemeClr val=\"lt1\"/></a:fontRef></p:style>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }

        private void Pregunta20()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "typeface=\"Times New Roman\" panose=\"02020603050405020304\" pitchFamily=\"18\" charset=\"0\"/></a:rPr><a:t>ETAPAS DE LA FOTOSÍNTESIS</a:t></a:r></a:p></p:txBody>";
            string cadenaAchequear2 = "typeface=\"Times New Roman\" panose=\"02020603050405020304\" pitchFamily=\"18\" charset=\"0\"/></a:rPr><a:t>Reacciones luminosas";
            string cadenaAchequear3 = "typeface=\"Times New Roman\" panose=\"02020603050405020304\" pitchFamily=\"18\" charset=\"0\"/></a:rPr><a:t>Esta fase es la etapa inicial </a:t></a:r></a:p><a:p><a:pPr lvl=\"2\"";
            string cadenaAchequear4 = "typeface=\"Times New Roman\" panose=\"02020603050405020304\" pitchFamily=\"18\" charset=\"0\"/></a:rPr><a:t>Se convierte la energía solar en energía potencial";

            String[] contenidoDeArchivo;

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")))
            {
                contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

                if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && 
                    contenidoDeArchivo[1].Contains(cadenaAchequear2) &&
                    contenidoDeArchivo[1].Contains(cadenaAchequear3) && 
                    contenidoDeArchivo[1].Contains(cadenaAchequear4))
                    {
                    p1 = "CORRECTO";
                    }                    
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta21()
        {
            BorrarTemporales();

            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();
            //<a:t>Notas al pie</a:t></a:r><a:endParaRPr
            string cadenaAchequear1 = "<a:t>Notas al pie</a:t></a:r><a:endParaRPr";
            string cadenaAchequear2 = "a:t";
            
            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\handoutMasters\handoutMaster1.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\handoutMasters\handoutMaster1.xml"));
                MatchCollection comparar = Regex.Matches(contenidoDeArchivo[1], cadenaAchequear2);

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && comparar.Count == 6)
                    p1 = "CORRECTO"; 
            }
  
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta22()
        {
            if (numeroCopias.Equals("5") && slidesPorHoja.Equals("ppPrintOutputNotesPages") && 
                rango.Equals("ppPrintAll") && intercalar.Equals("msoFalse"))
            {
                p1 = "CORRECTO";
            }                
            else
                p1 = "INCORRECTO";
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta23()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();
          
            string cadenaAchequear1 = "<p:txBody><a:bodyPr numCol=\"2\"/><a:lstStyle/><a:p><a:r><a:rPr lang=";
            string cadenaAchequear2 = "<p:txBody><a:bodyPr numCol=\"1\"/><a:lstStyle/><a:p><a:r><a:rPr lang=";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && !contenidoDeArchivo[indice].Contains(cadenaAchequear2))
                    p1 = "CORRECTO";
            }                            

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta24()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();
  
            string cadenaAchequear1 = "<p14:section name=\"Historia\"";
            string cadenaAchequear2 = "<p14:sldId id=\"256\"/><p14:sldId id=\"258\"/><p14:sldId id=\"263\"/><p14:sldId id=\"257\"/><p14:sldId id=\"273\"/><p14:sldId id=\"289\"/><p14:sldId id=\"290\"/></p14:sldIdLst>";
            string cadenaAchequear3 = "<p14:section name=\"Aplicaciones\"";
            string cadenaAchequear4 = "<p14:sldIdLst><p14:sldId id=\"272\"/><p14:sldId id=\"274\"/><p14:sldId id=\"278\"/></p14:sldIdLst>";
            string cadenaAchequear5 = "<p14:section name = \"Sin nombre\"";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\presentation.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\presentation.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && contenidoDeArchivo[indice].Contains(cadenaAchequear2) &&
                    contenidoDeArchivo[indice].Contains(cadenaAchequear3) && contenidoDeArchivo[indice].Contains(cadenaAchequear4) &&
                    !contenidoDeArchivo[indice].Contains(cadenaAchequear5))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta25()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "p14:dur=\"2500\"><p15:prstTrans";

            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide1.xml"));
            String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));
            String[] contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide3.xml"));
            String[] contenidoDeArchivo4 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));
            String[] contenidoDeArchivo5 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide5.xml"));
            String[] contenidoDeArchivo6 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml"));
            String[] contenidoDeArchivo7 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide7.xml"));
            String[] contenidoDeArchivo8 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide8.xml"));
            String[] contenidoDeArchivo9 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide9.xml"));
            String[] contenidoDeArchivo10 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide10.xml"));

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide1.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml")) &&
                File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide3.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")) &&
                File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide5.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml")) &&
                File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide7.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide8.xml")) &&
                File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide9.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide10.xml")))
            {
                if (contenidoDeArchivo1[contenidoDeArchivo1.Length - 1].Contains(cadenaAchequear1) && contenidoDeArchivo2[contenidoDeArchivo2.Length - 1].Contains(cadenaAchequear1) &&
                contenidoDeArchivo3[contenidoDeArchivo3.Length - 1].Contains(cadenaAchequear1) && contenidoDeArchivo4[contenidoDeArchivo4.Length - 1].Contains(cadenaAchequear1) &&
                contenidoDeArchivo5[contenidoDeArchivo5.Length - 1].Contains(cadenaAchequear1) && contenidoDeArchivo6[contenidoDeArchivo6.Length - 1].Contains(cadenaAchequear1) &&
                contenidoDeArchivo7[contenidoDeArchivo7.Length - 1].Contains(cadenaAchequear1) && contenidoDeArchivo8[contenidoDeArchivo8.Length - 1].Contains(cadenaAchequear1) &&
                contenidoDeArchivo9[contenidoDeArchivo9.Length - 1].Contains(cadenaAchequear1) && contenidoDeArchivo10[contenidoDeArchivo10.Length - 1].Contains(cadenaAchequear1))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta26()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:cTn id=\"5\" presetID=\"3\" presetClass=\"path\" presetSubtype=\"0\" accel=\"50000\" decel=\"50000\" fill=\"hold\" grpId=\"0\" nodeType=\"clickEffect\">";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta27()
        {
            ObjPowerPointAlumno = new PowerPoint.Application();

            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pptx";
            if (File.Exists(ruta))
            {
                pptAlumno = ObjPowerPointAlumno.Presentations.Open(ruta, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);
                var gridLine = ObjPowerPointAlumno.DisplayGridLines;
                var snapToGrid = pptAlumno.SnapToGrid;

                if (snapToGrid == MsoTriState.msoTrue && gridLine == MsoTriState.msoTrue)
                    p1 = "CORRECTO";
                else
                    p1 = "INCORRECTO";
            }

            GuardarPuntaje();
            CerrarPowerPoints();

            BorrarPreguntasTemporales();
        }

        private void Pregunta28()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:cNvPr id=\"3\" name=\"Estrella de 5 puntas 2\"/><p:cNvSpPr><a:spLocks noChangeAspect=\"1\"/></p:cNvSpPr><p:nvPr/></p:nvSpPr><p:spPr><a:xfrm rot=\"20393680\"><a:off x=\"1549337\" y=\"1551327\"/><a:ext cx=\"5107864\" cy=\"3479696\"/></a:xfrm><a:prstGeom prst=\"star5\">";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta29()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:sndAc><p:stSnd><p:snd r:embed=\"rId2\" name=\"push.wav\"/></p:stSnd></p:sndAc>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta30()
        {
            BorrarTemporales();

            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "typeface=\"Times New Roman\" panose=\"02020603050405020304\" pitchFamily=\"18\" charset=\"0\"/></a:rPr><a:t>Por Desarrollar";
            string cadenaAchequear2 = "val=\"2E74B5\"/></a:solidFill><a:latin typeface=\"Times New Roman\" panose=\"02020603050405020304\" pitchFamily=\"18\" charset=\"0\"/></a:rPr><a:t>La Esperanza Verde";
            string cadenaAchequear3 = "typeface=\"Times New Roman\" panose=\"02020603050405020304\" pitchFamily=\"18\" charset=\"0\"/></a:rPr><a:t>Ciclo de Carnot";

            String[] contenidoDeArchivo;

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml")))
            {
                contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) &&
                    contenidoDeArchivo[indice].Contains(cadenaAchequear2) && 
                    contenidoDeArchivo[indice].Contains(cadenaAchequear3))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta31()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<PresentationFormat>Presentación en pantalla (16:9)</PresentationFormat>";
            string cadenaAchequear2 = "<a:off x=\"1719074\" y=\"1928814\"/><a:ext cx=\"5467541\" cy=\"2070167\"/>";
            string cadenaAchequear3 = "<a:off x=\"4881292\" y=\"1518967\"/><a:ext cx=\"2381793\" cy=\"2210303\"/>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"docProps\app.xml")) &&
                File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml")) &&
                File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml")))
            {
                String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"docProps\app.xml"));
                String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));
                String[] contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));

                if (contenidoDeArchivo1[contenidoDeArchivo1.Length - 1].Contains(cadenaAchequear1) &&
                    contenidoDeArchivo2[contenidoDeArchivo2.Length - 1].Contains(cadenaAchequear2) &&
                    contenidoDeArchivo3[contenidoDeArchivo3.Length - 1].Contains(cadenaAchequear3))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta32()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:custShow name=\"Síntesis\" id=\"0\"><p:sldLst><p:sld r:id=\"rId2\"/><p:sld r:id=\"rId4\"/><p:sld r:id=\"rId6\"/></p:sldLst></p:custShow>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\presentation.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\presentation.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1))
                    p1 = "CORRECTO";
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta33()
        {
            ///revisar uso de carpeta temporal c:\\OfficeTrainner\\Pregunta 33 Ejercicio.pptx
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            if (File.Exists(@"c:\OfficeTrainner\Pregunta 33 Ejercicio.pptx\"))
            {
                string ruta_7z = Application.StartupPath + @"\Documentos\Temp\7z";
                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = true;
                info.FileName = "7z.exe";
                info.WorkingDirectory = ruta_7z;
                info.Arguments = "x " + "\"c:\\OfficeTrainner\\Pregunta 33 Ejercicio.pptx\"" + " " + "-o" + ruta_ResTem;
                Process.Start(info);

                ComprobarDescompresion();
            }

            string cadenaAchequear1 = "embedTrueTypeFonts=\"1\"";
            string cadenaAchequear2 = "<p:embeddedFont><p:font typeface=\"Tw Cen MT Condensed\"";
            string cadenaAchequear3 = "<p:embeddedFont><p:font typeface=\"Tw Cen MT\"";

            String[] contenidoDeArchivo;

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\fonts\font1.fntdata")))
            {
                contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\presentation.xml"));

                if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && 
                    contenidoDeArchivo[1].Contains(cadenaAchequear2) && 
                    contenidoDeArchivo[1].Contains(cadenaAchequear3))
                    {
                    p1 = "CORRECTO";
                    }
            }
            
            if (File.Exists("c:\\OfficeTrainner\\Pregunta 33 Ejercicio.pptx"))
            {
                File.Delete("c:\\OfficeTrainner\\Pregunta 33 Ejercicio.pptx");
            }
            
            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta34()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:cMediaNode vol=\"80000\" showWhenStopped=\"0\">";
            string cadenaAchequear2 = "<p:cTn id=\"2\" dur=\"indefinite\" nodeType=\"mainSeq\"><p:childTnLst><p:par><p:cTn id=\"3\" fill=\"hold\"><p:stCondLst><p:cond delay=\"indefinite\"/><p:cond evt=\"onBegin\" delay=\"0\"";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && contenidoDeArchivo[indice].Contains(cadenaAchequear2))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

            BorrarPreguntasTemporales();
        }
        private void Pregunta35()
        {
            BorrarTemporales();
            p1 = "INCORRECTO";

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<a:softEdge rad=\"112500\"/></a:effectLst>";
            string cadenaAchequear2 = "<a:ext cx=\"2381793\" cy=\"2210303\"/></a:xfrm><a:prstGeom prst=\"ellipse\">";

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml")))
            {
                String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));

                int indice = contenidoDeArchivo.Length - 1;
                if (contenidoDeArchivo[indice].Contains(cadenaAchequear1) && contenidoDeArchivo[indice].Contains(cadenaAchequear2))
                {
                    p1 = "CORRECTO";
                }
            }

            GuardarPuntaje();

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
