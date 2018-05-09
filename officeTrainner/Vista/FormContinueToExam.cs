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
    public partial class FormContinueToExam : Form
    {
        public FormContinueToExam()
        {
            InitializeComponent();            
        }
        private void FormContinueToExam_Load(object sender, EventArgs e)
        {
            this.DgvExams.AutoGenerateColumns = false;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MostrarTodosEstudiantesDgv();
            FiltrarEstudiantes();
            DgvAlumnos.Visible = true;
            DgvExams.Visible = false;
        }

        private void MostrarTodosEstudiantesDgv()
        {
            using (ModelContainer conexion = new ModelContainer())
            {
                this.DgvAlumnos.AutoGenerateColumns = false;                
                this.DgvAlumnos.DataSource = conexion.Alumnos.ToList();
            }
        }

        private void FiltrarEstudiantes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("idAlumno");

            foreach (DataGridViewRow row in DgvAlumnos.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["Nombres"] = row.Cells[0].Value;
                dr["Apellidos"] = row.Cells[1].Value;
                dr["idAlumno"] = row.Cells[2].Value;
                dt.Rows.Add(dr);
                              
            }
            string rowFilter = string.Format("[{0}] = '{1}'", "Nombres", TxtSearch.Text);
            dt.DefaultView.RowFilter = rowFilter;
            this.DgvAlumnos.AutoGenerateColumns = true;
            DgvAlumnos.DataSource = dt;
           
        }

        private void DgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int idAlumno = 0;
            foreach (DataGridViewRow row in DgvAlumnos.SelectedRows)
            {
                idAlumno = Convert.ToInt32(row.Cells[2].Value);
            }
            using (ModelContainer conexion = new ModelContainer())
            {
                this.DgvExams.DataSource = conexion.Examenes.Where(p => p.alumnoIdAlumno == idAlumno).Where(p => p.banderaReanudar == true).ToList();
            }
            DgvExams.Visible = true;
        }

        private void DgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvExams.SelectedRows)
            {
                FormMain.idExamenActual = Convert.ToInt32(row.Cells[2].Value);
            }
        }
    }
}
