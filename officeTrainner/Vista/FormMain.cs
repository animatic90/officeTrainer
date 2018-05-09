using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormMain : Form
    {
        public static int idExamenActual;
        public static int NUMERO_DE_PREGUNTAS = 50;
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnContinueExam_Click(object sender, EventArgs e)
        {
            FormContinueToExam formContinueToExam = new FormContinueToExam();
            formContinueToExam.Show();
        }

        private void BtnComenzarExamen_Click(object sender, EventArgs e)
        {
            FormStartExam formStartExam = new FormStartExam();
            formStartExam.Show();
        }
    }
}
