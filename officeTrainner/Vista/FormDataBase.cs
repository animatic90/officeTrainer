﻿using System;
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

namespace Vista
{
    public partial class FormDataBase : Form
    {
        string nombreAlumno;
        string apellidoAlumno;
        int preguntasCorrectas;

        //******* Exclusivos para el reporte******//

        //***************************************//

        string rangoFecha;// Hoy / Esta Semana / Este Mes //

        string imprimir;

        public FormDataBase()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            RestablecerDataGrids();

            FormMain.formAdministrativeTools.Left = this.Left;
            FormMain.formAdministrativeTools.Top = this.Top;
            FormAdministrativeTools.formDataBase.Hide();
            FormMain.formAdministrativeTools.Show();
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            RestablecerDataGrids();
            GbScore.Visible = true;
            BtnPrint.Enabled = true;

            imprimir = "rptPuntuacion";
            rangoFecha = "Hoy";

            MostrarPuntuacionsDgv(rangoFecha);
        }

        private void BtnThisWeek_Click(object sender, EventArgs e)
        {
            RestablecerDataGrids();
            GbScore.Visible = true;
            BtnPrint.Enabled = true;

            imprimir = "rptPuntuacion";
            rangoFecha = "Esta Semana";

            MostrarPuntuacionsDgv(rangoFecha);
        }
        private void BtnThisMonth_Click(object sender, EventArgs e)
        {
            RestablecerDataGrids();
            GbScore.Visible = true;
            BtnPrint.Enabled = true;

            imprimir = "rptPuntuacion";
            rangoFecha = "Este Mes";

            MostrarPuntuacionsDgv(rangoFecha);
        }
        private void BtnDetailsByCandidate_Click(object sender, EventArgs e)
        {
            RestablecerDataGrids();
            GbDetailByCandidate.Visible = true;

            imprimir = "rptDetalles";

            using (ModelContainer conexion = new ModelContainer())
            {
                this.DgvDetalleAlumno.AutoGenerateColumns = false;
                this.DgvDetalleAlumno.DataSource = conexion.Alumnos.Select(p => new { p.nombres, p.apellidos, p.IdAlumno }).ToList();
            }
        }

        private void DgvDetalleAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnPrint.Enabled = false;

            DgvDetalle.DataSource = null;
            DgvDetalle.Rows.Clear();
            DgvDetalle.Refresh();

            int idAlumno = 0;
            foreach (DataGridViewRow row in DgvDetalleAlumno.SelectedRows)
            {
                idAlumno = Convert.ToInt32(row.Cells[2].Value);
            }
            using (ModelContainer conexion = new ModelContainer())
            {
                this.DgvDetalleExamen.DataSource = conexion.Examenes.Where(p => p.alumnoIdAlumno == idAlumno).Select(p => new { p.nombreExamen, p.fecha, p.IdExamen, p.numeroDePreguntas }).OrderByDescending(p => p.fecha).ToList();
            }

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Examen"), new DataColumn("Fecha"), new DataColumn("Correctas"),
                                                    new DataColumn("Total"), new DataColumn("Porcentaje") , new DataColumn("idExamen")});


            foreach (DataGridViewRow row in DgvDetalleExamen.Rows)
            {                
                int idExamen = Convert.ToInt32(row.Cells[2].Value);

                contarCorrectas(idExamen);

                string examen = row.Cells[0].Value.ToString();
                string fecha = row.Cells[1].Value.ToString();
                string numeroPreguntas = row.Cells[3].Value.ToString();

                double calculoPorcentaje = (double)(preguntasCorrectas * 100) / Convert.ToInt32(numeroPreguntas);
                double aproxPorcentaje = Math.Round(calculoPorcentaje, 2);

                string porcentaje = aproxPorcentaje.ToString() + " %";



                dt.Rows.Add(examen, fecha, preguntasCorrectas, numeroPreguntas, porcentaje, idExamen);
            }

            this.DgvDetalleExamen.DataSource = dt;
            this.DgvDetalleExamen.Columns["idExamen"].Visible = false;
            this.DgvDetalleExamen.Refresh();
        }

        private void DgvDetalleExamen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnPrint.Enabled = true;

            int idExamen = 0;
            foreach (DataGridViewRow row in DgvDetalleExamen.SelectedRows)
            {
                idExamen = Convert.ToInt32(row.Cells["idExamen"].Value);
            }

            using (ModelContainer conexion = new ModelContainer())
            {
                this.DgvDetalle.DataSource = conexion.PuntajePreguntas.Where(p => p.ExamenIdExamen == idExamen).Select(p => new { p.numeroDePregunta, p.sp1 }).ToList();
                
            }

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Pregunta"), new DataColumn("Respuesta")});
            foreach (DataGridViewRow row in DgvDetalle.Rows)
            { 

                string pregunta = "Pregunta " + row.Cells[0].Value.ToString();
                string respuesta = row.Cells[1].Value.ToString();

                dt.Rows.Add(pregunta, respuesta);
            }

            this.DgvDetalle.DataSource = dt;
            this.DgvDetalle.Refresh();


        }

        private void BtnDetailsAll_Click(object sender, EventArgs e)
        {
            RestablecerDataGrids();
            GbDetailAll.Visible = true;

            imprimir = "rptDetalles";

            MostrarPuntuacionsTotal();
        }
        private void DgvTodoExamen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnPrint.Enabled = true;

            int idExamen = 0;
            foreach (DataGridViewRow row in DgvTodoExamen.SelectedRows)
            {
                idExamen = Convert.ToInt32(row.Cells["idExamen"].Value);
            }

            using (ModelContainer conexion = new ModelContainer())
            {
                this.DgvTodoDetalle.DataSource = conexion.PuntajePreguntas.Where(p => p.ExamenIdExamen == idExamen).Select(p => new { p.numeroDePregunta, p.sp1 }).ToList();

            }

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Pregunta"), new DataColumn("Respuesta") });
            foreach (DataGridViewRow row in DgvTodoDetalle.Rows)
            {

                string pregunta = "Pregunta " + row.Cells[0].Value.ToString();
                string respuesta = row.Cells[1].Value.ToString();

                dt.Rows.Add(pregunta, respuesta);
            }

            this.DgvTodoDetalle.DataSource = dt;
            this.DgvTodoDetalle.Refresh();
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            switch (imprimir)
            {
                case "rptPuntuacion":
                    ImprimirPuntuacion();
                    break; 

            }


        }

        private void BtnTotalTrouble_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirPuntuacion()
        {
            Reportes.FrmReportes frmImprPuntuacion = new Reportes.FrmReportes();
            Reportes.CrsRptImprPuntuacion cr = new Reportes.CrsRptImprPuntuacion();

            using (ModelContainer conexion = new ModelContainer())
            {
                var dt = DgvPuntuacion.DataSource;

                cr.SetDataSource(dt);
            }
            TextObject alumno = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["TxtRangoFecha"];

            alumno.Text = rangoFecha;

            frmImprPuntuacion.crystalReportViewer1.ReportSource = cr;
            frmImprPuntuacion.Show();
        }

        private void RestablecerDataGrids()
        {
            GbDetailAll.Visible = false;
            GbDetailByCandidate.Visible = false;
            GbScore.Visible = false;
            //GbTotals.Visible = false;

            BtnPrint.Enabled = false;
        }

        private void MostrarPuntuacionsTotal()
        {

           using (ModelContainer conexion = new ModelContainer())
           {
               this.DgvTodoExamen.DataSource = conexion.Examenes.Select(p => new { p.alumnoIdAlumno, p.nombreExamen, p.fecha, p.IdExamen, p.numeroDePreguntas }).OrderByDescending(p => p.fecha).ToList();
           }

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[8] { new DataColumn("Nombres"), new DataColumn("Apellidos"), new DataColumn("Examen"), new DataColumn("Fecha"),
                                                    new DataColumn("Correctas"), new DataColumn("Total"), new DataColumn("Porcentaje"), new DataColumn("idExamen") });

            foreach (DataGridViewRow row in DgvTodoExamen.Rows)
            {
                int idALumno = Convert.ToInt32(row.Cells[0].Value);
                int idExamen = Convert.ToInt32(row.Cells[3].Value);

                obtnereNombresDeId(idALumno);
                contarCorrectas(idExamen);

                string examen = row.Cells[1].Value.ToString();
                string fecha = row.Cells[2].Value.ToString();
                string numeroPreguntas = row.Cells[4].Value.ToString();

                double calculoPorcentaje = (double)(preguntasCorrectas * 100) / Convert.ToInt32(numeroPreguntas);
                double aproxPorcentaje = Math.Round(calculoPorcentaje, 2);

                string porcentaje = aproxPorcentaje.ToString() + "%";



                dt.Rows.Add(nombreAlumno, apellidoAlumno, examen, fecha, preguntasCorrectas, numeroPreguntas, porcentaje, idExamen);
            }

            this.DgvTodoExamen.DataSource = dt;
            this.DgvTodoExamen.Columns["idExamen"].Visible = false;
            this.DgvTodoExamen.Refresh();
        }

  


        private void MostrarPuntuacionsDgv(string time)
        {
            DateTime dateTime = DateTime.Today;

            switch (time)
            {
                case "Hoy":                    
                    using (ModelContainer conexion = new ModelContainer())
                    {
                        this.DgvPuntuacion.DataSource = conexion.Examenes.Where(p => p.fecha == dateTime).Select(p => new { p.alumnoIdAlumno, p.nombreExamen, p.fecha, p.IdExamen, p.numeroDePreguntas }).OrderByDescending(p => p.fecha).ToList();
                    }
                    break;
                case "Esta Semana":
                    DateTime start = dateTime.Date.AddDays(-(int)dateTime.DayOfWeek); // prev sunday 00:00
                    DateTime end = start.AddDays(7); // next sunday 00:00
                    using (ModelContainer conexion = new ModelContainer())
                    {
                        this.DgvPuntuacion.DataSource = conexion.Examenes.Where(p => p.fecha >= start && p.fecha < end).Select(p => new { p.alumnoIdAlumno, p.nombreExamen, p.fecha, p.IdExamen, p.numeroDePreguntas }).OrderByDescending(p => p.fecha).ToList();
                    }
                    break;
                case "Este Mes":
                    using (ModelContainer conexion = new ModelContainer())
                    {
                        this.DgvPuntuacion.DataSource = conexion.Examenes.Where(p => p.fecha.Month == dateTime.Month).Select(p => new { p.alumnoIdAlumno, p.nombreExamen, p.fecha, p.IdExamen, p.numeroDePreguntas }).OrderByDescending(p => p.fecha).ToList();
                    }
                    break;

            }
 
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Nombres"), new DataColumn("Apellidos"), new DataColumn("Examen"), new DataColumn("Fecha"),
                                                    new DataColumn("Correctas"), new DataColumn("Total"), new DataColumn("Porcentaje") });

            foreach (DataGridViewRow row in DgvPuntuacion.Rows)
            {
                int idALumno = Convert.ToInt32(row.Cells[0].Value);
                int idExamen = Convert.ToInt32(row.Cells[3].Value);

                obtnereNombresDeId(idALumno);
                contarCorrectas(idExamen);

                string examen = row.Cells[1].Value.ToString();
                string fecha = row.Cells[2].Value.ToString();
                string numeroPreguntas = row.Cells[4].Value.ToString();

                double calculoPorcentaje = (double)(preguntasCorrectas * 100) / Convert.ToInt32(numeroPreguntas);
                double aproxPorcentaje = Math.Round(calculoPorcentaje, 2);

                string porcentaje = aproxPorcentaje.ToString() + "%";

 

                dt.Rows.Add(nombreAlumno, apellidoAlumno, examen, fecha, preguntasCorrectas, numeroPreguntas, porcentaje);
            }

            this.DgvPuntuacion.DataSource = dt;
            this.DgvPuntuacion.Refresh();
        }

        private void obtnereNombresDeId(int idAlumno)
        {

            using (ModelContainer conexion = new ModelContainer())
            {
                var alumno = conexion.Alumnos.Where(p => p.IdAlumno == idAlumno).Select(p => new { p.nombres, p.apellidos }).ToList();

                foreach (var row in alumno)
                {
                    nombreAlumno = row.nombres;
                    apellidoAlumno = row.apellidos;
                }

            }
        }

        private void contarCorrectas(int idExamen)
        {
            using (ModelContainer conexion = new ModelContainer())
            {
                List<string> correctas = conexion.PuntajePreguntas.Where(p => p.ExamenIdExamen == idExamen).Where(p => p.sp1 == "CORRECTO").Select(p => p.sp1).ToList();

                preguntasCorrectas = correctas.Count;
            }
        }


    }
}
