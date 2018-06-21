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
            string rowFilter ="";
            if (RbFirstName.Checked == true)
                rowFilter = string.Format("[{0}] = '{1}'", "Nombres", TxtSearch.Text);
            if (RbLastName.Checked == true)
                rowFilter = string.Format("[{0}] = '{1}'", "Apellidos", TxtSearch.Text);

            dt.DefaultView.RowFilter = rowFilter;
            this.DgvAlumnos.AutoGenerateColumns = true;
            DgvAlumnos.DataSource = dt;
           
        }

        private void DgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnGoToExam.Enabled = false;

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


        private void BtnBack_Click(object sender, EventArgs e)
        {
            DgvAlumnos.Visible = false;
            DgvExams.Visible = false;
            TxtSearch.Text = "";

            FormMain.formContinueToExam.Hide();
            FormMain.formMain.Left = this.Left;
            FormMain.formMain.Top = this.Top;
            FormMain.formMain.Show();
        }

        private void BtnGoToExam_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvExams.SelectedRows)
            {
                FormMain.idExamenActual = Convert.ToInt32(row.Cells[2].Value);
                FormMain.ExamenSeleccionado = row.Cells[0].Value.ToString();
                FormMain.NUMERO_DE_PREGUNTAS = Convert.ToInt32(row.Cells[3].Value);
            }

            Screen screen = Screen.PrimaryScreen;

            //BR: el monitor actual es de 1080 X 1920
            int WidthScreen = screen.Bounds.Width;
            int HeightScreen = screen.Bounds.Height;

            FormQuestionsPanel formQuestionsPanel = new FormQuestionsPanel
            {
                StartPosition = FormStartPosition.Manual,
                Left = 0,
                //formQuestionsPanel.Top = Height - 180; //BR: No tomaremos una medida fija, sino que será proporcional a la resolución de ptantalla
                Top = HeightScreen - HeightScreen * 200 / 1080,
                Width = WidthScreen,
                Height = HeightScreen * 200 / 1080
            };
            formQuestionsPanel.Show();
            this.Hide();
        }
        

        private void DgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           BtnGoToExam.Enabled = true;
        }
    }
}
