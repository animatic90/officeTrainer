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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Vista
{
    public partial class FormExamResult : Form
    {
        int idAlumnoActual;
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
            idAlumnoActual = FormMain.idAlumnoActual;
            idExamenActual = FormMain.idExamenActual;
            NUMERO_DE_PREGUNTAS = FormMain.NUMERO_DE_PREGUNTAS;
            ExamenSeleccionado = FormMain.ExamenSeleccionado;

            var temp = FormMain.idAlumnoActual;

            rellenarLabel();
            rellenarResultados();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormMain.formExamResult.Hide();
            FormMain.formMain.Left = this.Left;
            FormMain.formMain.Top = this.Top;
            FormMain.formMain.Show();
        }
        #endregion


        #region Methods

        private void rellenarLabel()
        {
            LblTotal.Text = NUMERO_DE_PREGUNTAS.ToString();
            LblSelectedExam.Text = ExamenSeleccionado.ToString();

            using (ModelContainer conexion = new ModelContainer())
            {
                List<string> correctas = conexion.PuntajePreguntas.Where(p => p.ExamenIdExamen == idExamenActual).Where(p => p.sp1 == "CORRECTO").Select(p => p.sp1).ToList();

                preguntasCorrectas = correctas.Count;
            }

            LblCorrect.Text = preguntasCorrectas.ToString();

            double calculo = (double)(preguntasCorrectas * 100) / NUMERO_DE_PREGUNTAS;
            var porcentaje = Math.Round(calculo, 2);

            LblPercentage.Text = porcentaje.ToString() + "%";

            using (ModelContainer conexion = new ModelContainer())
            {
                var alumno = conexion.Alumnos.Where(p => p.IdAlumno == idAlumnoActual).Select(x => new { x.nombres, x.apellidos });

                foreach (var row in alumno)
                {
                    LblAlumno.Text = row.nombres.ToString() + " " + row.apellidos.ToString();
                }
            }
        }

        private void rellenarResultados()
        {
            using (ModelContainer conexion = new ModelContainer())
            {
                var listaResultados = conexion.PuntajePreguntas.Where(p => p.ExamenIdExamen == idExamenActual).Select(p => new { p.numeroDePregunta, p.sp1 }).ToList();

                StringBuilder stringBuilder = new StringBuilder(Environment.NewLine);

                for (int i = 0; i < listaResultados.Count; i++)
                {
                    string temp3 = "\t"+ "Pregunta " + listaResultados[i].numeroDePregunta.ToString() + "\t" + "|" + "\t" + listaResultados[i].sp1.ToString() + Environment.NewLine;

                    stringBuilder.Append(temp3);

                    string temp4 = "      ------------------------------------------------------------------------------" + Environment.NewLine;

                    stringBuilder.Append(temp4);

                }

                TxtResults.Text = stringBuilder.ToString();

            }
        }
        #endregion

        private void BtnImprCertificado_Click(object sender, EventArgs e)
        {
            Reportes.FrmReportes frmImprCertificado = new Reportes.FrmReportes();
            Reportes.CrsRptImprCertificado cr = new Reportes.CrsRptImprCertificado();

            TextObject alumno = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["TxtRptAlumno"];
            TextObject porcentaje = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["TxtRptPorcentaje"];
            TextObject examenSelecionado = (TextObject)cr.ReportDefinition.Sections["Section5"].ReportObjects["TxtRptExamenSelecionado"];

            alumno.Text = LblAlumno.Text;
            porcentaje.Text = LblPercentage.Text;
            examenSelecionado.Text = LblSelectedExam.Text;

            frmImprCertificado.crystalReportViewer1.ReportSource = cr;
            frmImprCertificado.Show();
        }

        private void BtnImprResultados_Click(object sender, EventArgs e)
        {
            Reportes.FrmReportes frmImprResultadeos = new Reportes.FrmReportes();
            Reportes.CrsRprImprResultados cr = new Reportes.CrsRprImprResultados();

            using (ModelContainer conexion = new ModelContainer())
            {
              var dt = conexion.PuntajePreguntas.Where(p => p.ExamenIdExamen == idExamenActual).Select(p => new { p.numeroDePregunta, p.sp1 });

                cr.SetDataSource(dt);
            }

            TextObject alumno = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["TxtRptAlumno"];
            TextObject porcentaje = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["TxtRptPorcentaje"];
            TextObject examenSelecionado = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["TxtRptExamenSelecionado"];
            TextObject correctas = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["TxtRptCorrectas"];
            TextObject numeroPreguntas = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["TxtRptTotalPreguntas"];

            alumno.Text = LblAlumno.Text;
            porcentaje.Text = LblPercentage.Text;
            examenSelecionado.Text = LblSelectedExam.Text;
            correctas.Text = LblCorrect.Text;
            numeroPreguntas.Text = LblTotal.Text;

            frmImprResultadeos.crystalReportViewer1.ReportSource = cr;
            frmImprResultadeos.Show();
        }
    }

}
