using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace Preguntas
{
    public class PreguntasPowerPoint
    {
        PowerPoint.Application ObjPowerPointAlumno;
        PowerPoint.Presentation pptAlumno;
        int idExamen;
        //Process[] powerPointProcsOld;

        string p1 = "NO EXISTE";
        string p2 = "NO EXISTE";
        string p3 = "NO EXISTE";
        string p4 = "NO EXISTE";
        string p5 = "NO EXISTE";

        public void Pregunta(int numeroDePregunta, int examenIdExamen)
        {
           // powerPointProcsOld = Process.GetProcessesByName("POWERPNT");
            idExamen = examenIdExamen;
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

        private void AbrirPowerPoints(int numeroDePregunta)
        {/*

            ObjExcelResuelto = new Excel.Application()
            {
                Visible = false
            };
            string rutaResuelto = Application.StartupPath + @"\Documentos\Excel\Pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @" Resuelta.xlsx";
            wbookResuelto = ObjExcelResuelto.Workbooks.Open(rutaResuelto);
            wsheetResuelto = (Excel.Worksheet)wbookResuelto.ActiveSheet;*/

            //usar

            ObjPowerPointAlumno = new PowerPoint.Application();

            try
            {
                ObjPowerPointAlumno.Visible = MsoTriState.msoFalse; //aun no funciona
            }
            catch (Exception)
            {
                throw;
            }


            string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio.pptx";
            pptAlumno = ObjPowerPointAlumno.Presentations.Open(ruta);

            //string ruta = Application.StartupPath + @"\Documentos\Power Point\Pregunta " + numeroDePregunta + @"\Pregunta " + numeroDePregunta + @" Ejercicio.pptx";

        }

        private void CerrarPowerPoints()
        {

            pptAlumno.Close();
            ObjPowerPointAlumno.Quit();

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
        static void DescomprimirZipPowerPoint()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";
            string ruta_7z = Application.StartupPath + @"\Documentos\Temp\7z";
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.FileName = "7z.exe";
            info.WorkingDirectory = ruta_7z;
            info.Arguments = "x " + ruta_ResTem + "Ejercicio.pptx" + " " + "-o" + ruta_ResTem + "Ejercicio";

            Process.Start(info);
        }

        private void ComprobarDescompresion()
        {
            for (int i = 0; i < 100; i++)
            {
                string ruta = Application.StartupPath + @"\Documentos\Temp\Ejercicio\ppt\presentation.xml";

                if (!System.IO.File.Exists(ruta))
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
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:transition spd=\"slow\"><p:randomBar dir=\"vert\"/></p:transition>";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }

        private void Pregunta2()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\ppt\slides\";


            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());
            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:cNvPr id=\"4\" name=\"3 Imagen\" descr=\"imagesCALRA574.jpg\"/>";                                      
            string cadenaAchequear2 = "<p:animEffect transition=\"in\" filter=\"checkerboard(across)\">";            
            string cadenaAchequear3 = "<a:t>pasar por casillas controladas por piezas contrarias.</a:t>";
            string cadenaAchequear4 = "<a:t>, conocido como tablas o </a";
            string cadenaAchequear5 = "<a:t>, de forma que una de ellas será necesariamente capturada.</a:t>";
            string cadenaAchequear6 = "<a:t> Consisten en elegir cuál entre todos los elementos es el más importante.</a:t>";

            if (File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")))
            {
                String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide6.xml"));
                String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide7.xml"));
                String[] contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide8.xml"));
                String[] contenidoDeArchivo4 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide9.xml"));
                String[] contenidoDeArchivo5 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide10.xml"));
                String[] contenidoDeArchivo6 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide11.xml"));

                if (contenidoDeArchivo1[1].Contains(cadenaAchequear1) && contenidoDeArchivo2[1].Contains(cadenaAchequear2) && contenidoDeArchivo3[1].Contains(cadenaAchequear3) && contenidoDeArchivo4[1].Contains(cadenaAchequear4) && contenidoDeArchivo5[1].Contains(cadenaAchequear5) && contenidoDeArchivo6[1].Contains(cadenaAchequear6))
                    p1 = "CORRECTO";
            }
            else
            {
                p1 = "INCORRECTO";
            }

           GuardarPuntaje();
           BorrarTemporales();
        }

        private void Pregunta3()
        {
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

                if (!contenidoDeArchivo1[1].Contains(cadenaAchequear1) && !contenidoDeArchivo1[1].Contains(cadenaAchequear2) && !contenidoDeArchivo1[1].Contains(cadenaAchequear3) && contenidoDeArchivo1[1].Contains(cadenaAchequear4))
                    p1 = "CORRECTO";
                else
                    p1 = "INCORRECTO";
            }
            else
            {
                p1 = "INCORRECTO";
            }

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta4()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "fmtScheme name=\"Sector\">";
            string cadenaAchequear2 = "<a:clrScheme name=\"Sector\">";
            string cadenaAchequear3 = "<a:fontScheme name=\"Sector\">";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\theme\theme1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2) && contenidoDeArchivo[1].Contains(cadenaAchequear3))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta5()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "peón</a:t></a:r></a:p></p:txBody></p:sp><p:sp><p:nvSpPr><p:cNvPr id=";
            string cadenaAchequear2 = "</p:nvGrpSpPr><p:grpSpPr><a:xfrm><a:off x=\"503434\" y=\"1268016\"/><a:ext cx=\"698642\" cy=\"2803734\"/><a:chOff x=\"503434\" y=\"1268016\"/><a:chExt cx=\"698642\" cy=\"2803734\"/></a:xfrm></p:grpSpPr><p:sp><p:nvSpPr>";
            //string cadenaAchequear3 = "<a:fontScheme name=\"Sector\">";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));
            if (!contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta6()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "<dgm:catLst><dgm:cat type=\"colorful\"";
            string cadenaAchequear2 = "/colors/colorful3\">";
            string cadenaAchequear3 = "<a:schemeClr val=\"accent3\"";
            string cadenaAchequear4 = "<a:schemeClr val=\"accent4\"";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\diagrams\colors1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2) && contenidoDeArchivo[1].Contains(cadenaAchequear3) && contenidoDeArchivo[1].Contains(cadenaAchequear4))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta7()
        {
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

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2) && contenidoDeArchivo[1].Contains(cadenaAchequear3) && contenidoDeArchivo[1].Contains(cadenaAchequear4) && contenidoDeArchivo[1].Contains(cadenaAchequear5) && contenidoDeArchivo[1].Contains(cadenaAchequear6) && contenidoDeArchivo[1].Contains(cadenaAchequear7) && contenidoDeArchivo[1].Contains(cadenaAchequear8))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta8()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:cNvPr id=\"6\" name=\"Imagen 5\"/><p:cNvPicPr><a:picLocks noChangeAspect=\"1\"/></p:cNvPicPr><p:nvPr/></p:nvPicPr><p:blipFill><a:blip r:embed=\"rId2\"/><a:stretch><a:fillRect/></a:stretch></p:blipFill><p:spPr><a:xfrm><a:off x=\"5867400\" y=\"1563624\"/><a:ext cx=\"2517866\" cy=\"2243522\"/><";
            string cadenaAchequear2 = "a:gridCol";
            string cadenaAchequear3 = "<a:tc><a:txBody><a:bodyPr/><a:lstStyle/><a:p><a:endParaRPr";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));
            
            MatchCollection numColumnas = Regex.Matches(contenidoDeArchivo[1], cadenaAchequear2);
            MatchCollection numFilas = Regex.Matches(contenidoDeArchivo[1], cadenaAchequear3);


            if(contenidoDeArchivo[1].Contains(cadenaAchequear1) && numFilas.Count == 20)
            {
                if (numColumnas.Count == 5 || numColumnas.Count == 10)
                    p1 = "CORRECTO";
                else
                    p1 = "INCORRECTO";
            }
            else
                p1 = "INCORRECTO";
             

            GuardarPuntaje();
            BorrarTemporales();

        }
        private void Pregunta9()
        {

            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "main\" meth=\"cycle\" id=\"13\"><a:schemeClr val=\"accent6\"/><a:schemeClr val=\"accent5\"/><a:schemeClr val=\"accent4\"/><cs:variation/><cs:variation><a:lumMod val=\"60000\"/>";
            string cadenaAchequear2 = "/main\" id=\"293\"><cs:axisTitle>";                                      
            string cadenaAchequear3 = "<a:schemeClr val=\"bg1\"";
                                      
            string cadenaAchequear4 = "val=\"tx1\"";//25 veces

            String[] contenidoDeArchivoA = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\colors1.xml"));
            String[] contenidoDeArchivoB = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\style1.xml"));
            MatchCollection numText = Regex.Matches(contenidoDeArchivoB[0], cadenaAchequear4);


            if (numText.Count == 25 && contenidoDeArchivoA[0].Contains(cadenaAchequear1) && contenidoDeArchivoB[0].Contains(cadenaAchequear2) && contenidoDeArchivoB[0].Contains(cadenaAchequear3))
          // if (contenidoDeArchivoA[0].Contains(cadenaAchequear1))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }

        private void Pregunta10()
        {
            
        }
        private void Pregunta11()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:bg><p:bgPr><a:gradFill><a:gsLst><a:gs pos=\"0\"><a:schemeClr val=\"accent1\"><a:lumMod val=\"5000\"/><a:lumOff val=\"95000\"/></a:schemeClr></a:gs><a:gs pos=\"74000\"><a:schemeClr val=\"accent1\"><a:lumMod val=\"45000\"/><a:lumOff val=\"55000\"/></a:schemeClr></a:gs><a:gs pos=\"83000\"><a:schemeClr val=\"accent1\"><a:lumMod val=\"45000\"/><a:lumOff val=\"55000\"/></a:schemeClr></a:gs><a:gs pos=\"100000\"><a:schemeClr val=\"accent1\"><a:lumMod val=\"30000\"/><a:lumOff val=\"70000\"/></a:schemeClr></a:gs></a:gsLst><a:lin ang=\"5400000\" scaled=\"1\"/></a:gradFill><a:effectLst/></p:bgPr>";
            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide4.xml"));

            if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
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
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "tp://schemas.microsoft.com/office/drawing/2010/main\" val=\"0\"/></a:ext></a:extLst></a:blip><a:stretch><a:fillRect/></a:stretch></p:blipFill><p:spPr><a:xfrm><a:off x=\"4128746\" y=\"1953908\"/><a:ext cx=\"2515284\" cy=\"2243747\"/></a:xfrm><a:prstGeom";
            string cadenaAchequear2 = "<p:ph sz=\"half\" idx=\"1\"/>";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta14()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();
            string cadenaAchequear1 = "<a:off x=\"3388530\" y=\"2917294\"/><a:ext cx=\"1981200\" cy=\"1767320\"/>";
            string cadenaAchequear2 = "<a:off x=\"3924300\" y=\"3468422\"/><a:ext cx=\"909661\" cy=\"665064\"/>";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide2.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta15()
        {
        }
        private void Pregunta16()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\Ejercicio\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();
            //
            string cadenaAchequear1 = "spc=\"300\" dirty=\"0\" smtClean=\"0\"><a:effectLst><a:outerShdw blurRad=\"38100\" dist=\"38100\" dir=\"2700000\" algn=\"tl\"><a:srgbClr val=\"000000\"><a:alpha val=\"43137\"";
            string cadenaAchequear2 = "spc=\"300\" dirty=\"0\"><a:effectLst><a:outerShdw blurRad=\"38100\" dist=\"38100\" dir=\"2700000\" algn=\"tl\"><a:srgbClr val=\"000000\">";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide1.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1) && contenidoDeArchivo[1].Contains(cadenaAchequear2))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

            GuardarPuntaje();
            BorrarTemporales();
        }
        private void Pregunta17()
        {
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

            //schemas.openxmlformats.org/drawingml/2006/main\" id=\"366\"  style1
            //<cx:numDim type=\"val\"> chartex
            //Categoría  no en chartex


            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\slides\slide6.xml"));

            if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\charts\style1.xml")))
            {
                String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\style1.xml"));
                String[] contenidoDeArchivo3 = new String[1];
                if(File.Exists(Path.Combine(ruta_ResTem, @"ppt\charts\chartEx1.xml")))
                    contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\chartE1.xml"));
                if (File.Exists(Path.Combine(ruta_ResTem, @"ppt\charts\chart1.xml")))
                    contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"ppt\charts\chart1.xml"));

                if (!contenidoDeArchivo1[1].Contains(cadenaAchequear3) && contenidoDeArchivo1[1].Contains(cadenaAchequear4) && contenidoDeArchivo2[0].Contains(cadenaAchequear5)  && contenidoDeArchivo3[0].Contains(cadenaAchequear1) && !contenidoDeArchivo3[0].Contains(cadenaAchequear2))
                    p1 = "CORRECTO";
                else
                    p1 = "INCORRECTO";
            }
            else
            {
                p1 = "INCORRECTO";
            }

            GuardarPuntaje();
            BorrarTemporales();
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
