using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public static Form formMain;

        public static string ExamenSeleccionado;


        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            
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

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            BorrarTemporales();
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
    }
}
