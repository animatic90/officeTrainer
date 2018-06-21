using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Vista
{
    public partial class FormExamResult : Form
    {
        int idExamenActual;
        int NUMERO_DE_PREGUNTAS;
        string ExamenSeleccionado;
        int preguntasCorrectas;

        public FormExamResult()
        {
            InitializeComponent();
        }
        
        #region Events
        private void FormExamResult_Load(object sender, EventArgs e)
        {
            idExamenActual = FormMain.idExamenActual;
            NUMERO_DE_PREGUNTAS = FormMain.NUMERO_DE_PREGUNTAS;
            ExamenSeleccionado = FormMain.ExamenSeleccionado;

            LblTotal.Text = NUMERO_DE_PREGUNTAS.ToString();
            LblSelectedExam.Text = ExamenSeleccionado.ToString();

            
            using (ModelContainer conexion = new ModelContainer())
            {
                List<string> correctas = conexion.PuntajePreguntas.Where(p => p.ExamenIdExamen == idExamenActual).Where(p => p.sp1 == "CORRECTO").Select(p => p.sp1).ToList();

                preguntasCorrectas = correctas.Count;
            }

            LblCorrect.Text = preguntasCorrectas.ToString();

            double temp = (double)(preguntasCorrectas * 100)/NUMERO_DE_PREGUNTAS;
           var temp1 = Math.Round(temp, 2);

            LblPercentage.Text = temp1.ToString() + "%"; 
        }
       
        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormMain.formExamResult.Hide();
            FormMain.formMain.Left = this.Left;
            FormMain.formMain.Top = this.Top;
            FormMain.formMain.Show();
        }
        #endregion
    }


}
