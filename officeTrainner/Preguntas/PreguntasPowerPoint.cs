using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Datos;

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
            for (int i = 0; i < 20; i++)
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
        private void Pregunta1()
        {
            string ruta_ResTem = Application.StartupPath + @"\Documentos\Temp\";

            Task task1 = Task.Factory.StartNew(() => DescomprimirZipPowerPoint());

            ComprobarDescompresion();

            string cadenaAchequear1 = "<p:transition spd=\"slow\"><p:randomBar dir=\"vert\"/></p:transition>";

            String[] contenidoDeArchivo = File.ReadAllLines(Path.Combine(ruta_ResTem, @"Ejercicio\ppt\slides\slide2.xml"));
            if (contenidoDeArchivo[1].Contains(cadenaAchequear1))
                p1 = "CORRECTO";
            else
                p1 = "INCORRECTO";

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
            String[] contenidoDeArchivo1 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide6.xml"));
            String[] contenidoDeArchivo2 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide7.xml"));
            String[] contenidoDeArchivo3 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide8.xml"));
            String[] contenidoDeArchivo4 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide9.xml"));
            String[] contenidoDeArchivo5 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide10.xml"));
            String[] contenidoDeArchivo6 = File.ReadAllLines(Path.Combine(ruta_ResTem, @"slide11.xml"));

            if (File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")) && File.Exists(Path.Combine(ruta_ResTem, @"slide6.xml")))
            {
                if (contenidoDeArchivo1[1].Contains(cadenaAchequear1) && contenidoDeArchivo2[1].Contains(cadenaAchequear2) && contenidoDeArchivo3[1].Contains(cadenaAchequear3) && contenidoDeArchivo4[1].Contains(cadenaAchequear4) && contenidoDeArchivo5[1].Contains(cadenaAchequear5) && contenidoDeArchivo6[1].Contains(cadenaAchequear6))
                    p1 = "CORRECTO";
            }
            else
            {
                p1 = "INCORRECTO";
            }                

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
           BorrarTemporales();
        }

        private void Pregunta3()
        {

        }
        private void Pregunta4()
        {

        }
        private void Pregunta5()
        {

        }
        private void Pregunta6()
        {

        }
        private void Pregunta7()
        {

        }
        private void Pregunta8()
        {

        }

        static void DescomprimirZip()
        {

        }

        private void Pregunta9()
        {

        }
        private void Pregunta10()
        {
        
        }
        private void Pregunta11()
        {
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
