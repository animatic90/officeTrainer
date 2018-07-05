using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormMain : Form
    {
        public static int idAlumnoActual;
        public static int idExamenActual;
        public static int NUMERO_DE_PREGUNTAS;
        public static FormContinueToExam formContinueToExam = new FormContinueToExam();
        public static FormStartExam formStartExam = new FormStartExam();
        public static FormExamResult formExamResult = new FormExamResult();
        public static FormAdministrativeTools formAdministrativeTools = new FormAdministrativeTools();
        public static Form formMain;

        public static int leftPos;
        public static int topPos;

        public static string ExamenSeleccionado;

        Process[] allExcelProcsOld;//para capturar todos los excel abiertos antes de iniciar el programa
        Process[] allWordProcsOld;//para capturar todos los Word abiertos antes de iniciar el programa
        Process[] allPowerPointProcOld;//


        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (FormLogin.nivelDeusuario == "Administrador")
            {
                BtnHerramientasAdm.Visible = true;
            }

            obtenerPosicionVentana();

            allExcelProcsOld = Process.GetProcessesByName("EXCEL");
            allWordProcsOld = Process.GetProcessesByName("WINWORD");
            allPowerPointProcOld = Process.GetProcessesByName("POWERPNT");



        }
        private void BtnContinueExam_Click(object sender, EventArgs e)
        {
            formMain = FormMain.ActiveForm;
            formContinueToExam.Left = this.Left;
            formContinueToExam.Top = this.Top;
            formContinueToExam.Show();
            this.Hide();
        }

        private void BtnComenzarExamen_Click(object sender, EventArgs e)
        {
            formMain = FormMain.ActiveForm;
            formStartExam.Left = this.Left;
            formStartExam.Top = this.Top;
            formStartExam.Show();
            this.Hide();
        }
        private void BtnHerramientasAdm_Click(object sender, EventArgs e)
        {            
            formMain = FormMain.ActiveForm;
            formAdministrativeTools.Left = leftPos;
            formAdministrativeTools.Top = topPos;
            formAdministrativeTools.Show();
            this.Hide();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            BorrarTemporales();

            DestruirExcels();
            DestruirPowerPoints();
            DestruirWords();
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

        private void obtenerPosicionVentana()
        {
            leftPos = this.Left;
            topPos = this.Top;
        }

        private void FormMain_Move(object sender, EventArgs e)
        {
            obtenerPosicionVentana();
        }

        private void DestruirExcels()
        {
            Process[] allExcelProcsNew = Process.GetProcessesByName("EXCEL");
            foreach (Process procNew in allExcelProcsNew)
            {
                int exist = 0;
                foreach (Process procOld in allExcelProcsOld)
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

        private void DestruirPowerPoints()
        {
              Process[] allPowerPointProcsNew = Process.GetProcessesByName("POWERPNT");
               foreach (Process procNew in allPowerPointProcsNew)
               {
                   int exist = 0;
                   foreach (Process procOld in allPowerPointProcOld)
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
            Process[] allWordProcsNew = Process.GetProcessesByName("WINWORD");
            foreach (Process procNew in allWordProcsNew)
            {
                int exist = 0;
                foreach (Process procOld in allWordProcsOld)
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
    }
}
