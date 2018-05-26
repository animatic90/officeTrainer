namespace Vista
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Datos;

    public partial class FormStartExam : Form
    {
        #region Atributes        
        
        //****************************************************
        public static bool aleatorio;
        public static bool cronometro;
        public static bool guardar;
        public static bool reanudar;
        //****************************************************
        public static int[] arrayOrdenDePreguntas;
        // public static int[] arrayOrdenDePreguntas = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int irAPregunta;


            
        #endregion



        public FormStartExam()
        {
            InitializeComponent();
        }

        #region Events
        private void FormStartExam_Load(object sender, EventArgs e)
        {
            LblChangeType_Click(sender, e);
        }
        private void BtnComenzarExamen_Click(object sender, EventArgs e)
        {

            irAPregunta = Convert.ToInt32(LblNumeroPregunta.Text);

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
            //Llenamos los respectivos campos de la base de datos antes de abrir la siguiente ventana
           if(CrearNuevoAlumno())
            {
                CargarParametros();
                formQuestionsPanel.Show();
            }
            this.Hide();

        }

        private void BtnWord_Click(object sender, EventArgs e)
        {
            FormMain.ExamenSeleccionado = "Word";
            BtnSelectedExam.Text = "Word";
            PnlSelectExam.Visible = false;
            PnlSelectedExam.Visible = true;
            
            //PnlOptions.Visible = true; // descoemntar cuando se implementen preguntas para word
            PnlNames.Visible = true;
        }

        private void BtnPowerPoint_Click(object sender, EventArgs e)
        {
            FormMain.ExamenSeleccionado = "Power Point";
            BtnSelectedExam.Text = "Power Point";
            PnlSelectExam.Visible = false;            
            PnlSelectedExam.Visible = true;

            FormMain.NUMERO_DE_PREGUNTAS = 35;

            PnlOptions.Visible = true;
            PnlNames.Visible = true;
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            FormMain.ExamenSeleccionado = "Excel";
            BtnSelectedExam.Text = "Excel";
            PnlSelectExam.Visible = false;
            PnlSelectedExam.Visible = true;

            FormMain.NUMERO_DE_PREGUNTAS = 35;

            PnlOptions.Visible = true;
            PnlNames.Visible = true;
        }

        private void LblCambiar_Click(object sender, EventArgs e)
        {
            PnlSelectExam.Visible = true;
            PnlSelectedExam.Visible = false;

            PnlOptions.Visible = false;
            PnlNames.Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TxtFirstName.Text= "";
            TxtLastName.Text = "";

            FormMain.formStartExam.Hide();
            FormMain.formMain.Left = this.Left;
            FormMain.formMain.Top = this.Top;
            FormMain.formMain.Show();            
        }
        private void BtnShowExams_Click(object sender, EventArgs e)
        {
            PnlSelectExam.Visible = true;
            BtnShowExams.Enabled = false;
        }

        private void LblChangeType_Click(object sender, EventArgs e)
        {
            PnlSelectExam.Visible = false;
            PnlSelectedExam.Visible = false;
            BtnShowExams.Enabled = true;

            PnlOptions.Visible = false;
            PnlNames.Visible = false;
        }
        #endregion

        #region Methods
        private bool CrearNuevoAlumno()
        {            
            if (CampoValidos())
            {
                int idAlumno = 0;
                Alumno alumnoExiste = new Alumno
                {
                    nombres = TxtFirstName.Text,
                    apellidos = TxtLastName.Text
                };

                using (ModelContainer conexion = new ModelContainer())
                {
                    alumnoExiste = conexion.Alumnos.Where(p => p.nombres == alumnoExiste.nombres).Where(p => p.apellidos == alumnoExiste.apellidos).FirstOrDefault();                    

                }
                if(alumnoExiste == null)
                {
                    Alumno alumno = new Alumno
                    {
                        nombres = TxtFirstName.Text,
                        apellidos = TxtLastName.Text
                    };
                    using (ModelContainer conexion = new ModelContainer())
                    {
                        conexion.Alumnos.Add(alumno);
                        conexion.SaveChanges();
                    }
                }
                else
                {
                   idAlumno = alumnoExiste.IdAlumno;//significa que no se encontró un alumno con el mismo nombre y apellido
                }

                DateTime today = DateTime.Today;
                Examen examen = new Examen
                {
                    nombreExamen = FormMain.ExamenSeleccionado,
                    //nombreExamen = "Word",
                    fecha = today,
                    avance = 0,

                    alumnoIdAlumno = ObtenerIdAlumno(idAlumno),
                    numeroDePreguntas = ObtenerNumeroDePreguntas(),
                    banderaAleatorio = ChbOrdenPregAle.Checked,
                    banderaCronometro = ChbCronometro.Checked,
                    banderaGuardar = ChbGuardarResultados.Checked,
                    banderaReanudar = false
                };
                using (ModelContainer conexion = new ModelContainer())
                {
                    conexion.Examenes.Add(examen);
                    conexion.SaveChanges();
                }

                DetalleExamen detalleExamen = new DetalleExamen
                {
                    //los tres estados de esta tabla son: CORRECTO, INCORRECTO, NO RESUELTO (indica que el alumno todavía no llegó a esta pregunta)
                    //Inicializaremos las 35 preguntas
                    Pregunta1 = "NO RESUELTO",
                    Pregunta2 = "NO RESUELTO",
                    Pregunta3 = "NO RESUELTO",
                    Pregunta4 = "NO RESUELTO",
                    Pregunta5 = "NO RESUELTO",
                    Pregunta6 = "NO RESUELTO",
                    Pregunta7 = "NO RESUELTO",
                    Pregunta8 = "NO RESUELTO",
                    Pregunta9 = "NO RESUELTO",
                    Pregunta10 = "NO RESUELTO",
                    Pregunta11 = "NO RESUELTO",
                    Pregunta12 = "NO RESUELTO",
                    Pregunta13 = "NO RESUELTO",
                    Pregunta14 = "NO RESUELTO",
                    Pregunta15 = "NO RESUELTO",
                    Pregunta16 = "NO RESUELTO",
                    Pregunta17 = "NO RESUELTO",
                    Pregunta18 = "NO RESUELTO",
                    Pregunta19 = "NO RESUELTO",
                    Pregunta20 = "NO RESUELTO",
                    Pregunta21 = "NO RESUELTO",
                    Pregunta22 = "NO RESUELTO",
                    Pregunta23 = "NO RESUELTO",
                    Pregunta24 = "NO RESUELTO",
                    Pregunta25 = "NO RESUELTO",
                    Pregunta26 = "NO RESUELTO",
                    Pregunta27 = "NO RESUELTO",
                    Pregunta28 = "NO RESUELTO",
                    Pregunta29 = "NO RESUELTO",
                    Pregunta30 = "NO RESUELTO",
                    Pregunta31 = "NO RESUELTO",
                    Pregunta32 = "NO RESUELTO",
                    Pregunta33 = "NO RESUELTO",
                    Pregunta34 = "NO RESUELTO",
                    Pregunta35 = "NO RESUELTO",
                    ExamenIdExamen = ObtenerUltimoIdExamen()
                };

                using (ModelContainer conexion = new ModelContainer())
                {
                    conexion.DetalleExamenes.Add(detalleExamen);
                    conexion.SaveChanges();
                }

                return true;
            }
            return false;
        }

        private void CargarParametros()
        {
                aleatorio = ChbOrdenPregAle.Checked;
                cronometro = ChbCronometro.Checked;
                guardar = ChbGuardarResultados.Checked;
                arrayOrdenDePreguntas = ObteneOrdenDePreguntas(aleatorio); 
            
                ArrayOrdenPreguntas arrayOrdenDePreguntasO = new ArrayOrdenPreguntas
                {
                    p01 = arrayOrdenDePreguntas[0],
                    p02 = arrayOrdenDePreguntas[1],
                    p03 = arrayOrdenDePreguntas[2],
                    p04 = arrayOrdenDePreguntas[3],
                    p05 = arrayOrdenDePreguntas[4],
                    p06 = arrayOrdenDePreguntas[5],
                    p07 = arrayOrdenDePreguntas[6],
                    p08 = arrayOrdenDePreguntas[7],
                    p09 = arrayOrdenDePreguntas[8],
                    p10 = arrayOrdenDePreguntas[9],
                    p11 = arrayOrdenDePreguntas[10],
                    p12 = arrayOrdenDePreguntas[11],
                    p13 = arrayOrdenDePreguntas[12],
                    p14 = arrayOrdenDePreguntas[13],
                    p15 = arrayOrdenDePreguntas[14],
                    p16 = arrayOrdenDePreguntas[15],
                    p17 = arrayOrdenDePreguntas[16],
                    p18 = arrayOrdenDePreguntas[17],
                    p19 = arrayOrdenDePreguntas[18],
                    p20 = arrayOrdenDePreguntas[19],
                    p21 = arrayOrdenDePreguntas[20],
                    p22 = arrayOrdenDePreguntas[21],
                    p23 = arrayOrdenDePreguntas[22],
                    p24 = arrayOrdenDePreguntas[23],
                    p25 = arrayOrdenDePreguntas[24],
                    p26 = arrayOrdenDePreguntas[25],
                    p27 = arrayOrdenDePreguntas[26],
                    p28 = arrayOrdenDePreguntas[27],
                    p29 = arrayOrdenDePreguntas[28],
                    p30 = arrayOrdenDePreguntas[29],
                    p31 = arrayOrdenDePreguntas[30],
                    p32 = arrayOrdenDePreguntas[31],
                    p33 = arrayOrdenDePreguntas[32],
                    p34 = arrayOrdenDePreguntas[33],
                    p35 = arrayOrdenDePreguntas[34],
                    p36 = arrayOrdenDePreguntas[35],
                    p37 = arrayOrdenDePreguntas[36],
                    p38 = arrayOrdenDePreguntas[37],
                    p39 = arrayOrdenDePreguntas[38],
                    p40 = arrayOrdenDePreguntas[39],
                    p41 = arrayOrdenDePreguntas[40],
                    p42 = arrayOrdenDePreguntas[41],
                    p43 = arrayOrdenDePreguntas[42],
                    p44 = arrayOrdenDePreguntas[43],
                    p45 = arrayOrdenDePreguntas[44],
                    p46 = arrayOrdenDePreguntas[45],
                    p47 = arrayOrdenDePreguntas[46],
                    p48 = arrayOrdenDePreguntas[47],
                    p49 = arrayOrdenDePreguntas[48],
                    p50 = arrayOrdenDePreguntas[49],
                    ExamenIdExamen = ObtenerUltimoIdExamen()
                };
                using (ModelContainer conexion = new ModelContainer())
                {
                    conexion.ArrayOrdenPreguntas.Add(arrayOrdenDePreguntasO);
                    conexion.SaveChanges();
                }
        }

        private int[] ObteneOrdenDePreguntas(bool aleatorio) //true = aleatorio; false = no aleatorio
        {
            int[] arrayDeAleatorios = new int[] {0, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0};
            if (!aleatorio)
            {
                arrayDeAleatorios = new int[] {1, 2,  3,  4,  5,  6,  7,  8,  9,  10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50};
            }
            else
            { 
                //Pondremos 5 patrones de números aleatorios hasta el 50. Para preguntas adicionales aumentar los números
                Random r = new Random();
                int rInt = 5;
                switch (rInt)
                {
                    case 1:
                        arrayDeAleatorios = new int[] { 2, 33, 24, 34, 43, 25, 41, 30, 18, 28, 7, 27, 47, 31, 6, 8, 45, 40, 42, 49, 46, 36, 19, 22, 3, 4, 50, 17, 44, 11, 20, 29, 26, 35, 39, 32, 21, 5, 10, 16, 13, 37, 14, 12, 38, 1, 23, 9, 48, 15 };
                        break;
                    case 2:
                        arrayDeAleatorios = new int[] { 15, 20, 33, 45, 11, 26, 17, 6, 9, 37, 27, 25, 8, 4, 47, 36, 14, 39, 42, 22, 49, 24, 29, 7, 5, 34, 31, 28, 38, 3, 41, 2, 21, 35, 13, 23, 40, 19, 50, 18, 10, 1, 12, 32, 46, 44, 43, 16, 48, 30 };
                        break;
                    case 3:
                        arrayDeAleatorios = new int[] { 36, 31, 20, 29, 19, 18, 22, 9, 14, 24, 25, 5, 15, 23, 41, 12, 8, 4, 32, 6, 47, 26, 1, 43, 10, 38, 28, 50, 40, 11, 7, 35, 3, 48, 30, 46, 27, 33, 45, 21, 13, 49, 44, 42, 17, 2, 16, 39, 37, 34 };
                        break;
                    case 4:
                        arrayDeAleatorios = new int[] { 5, 14, 41, 17, 13, 4, 15, 28, 25, 29, 40, 37, 48, 12, 9, 10, 22, 42, 47, 19, 31, 34, 18, 43, 2, 35, 33, 16, 30, 46, 20, 8, 23, 39, 36, 27, 21, 32, 44, 1, 6, 7, 49, 3, 38, 11, 50, 26, 24, 45 };
                        break;
                    case 5:
                        arrayDeAleatorios = new int[] { 19, 41, 15, 33, 8, 7, 21, 5, 14, 49, 17, 31, 46, 20, 22, 27, 40, 11, 39, 37, 38, 48, 36, 25, 18, 3, 6, 32, 42, 28, 26, 34, 29, 9, 30, 24, 43, 12, 10, 1, 4, 44, 45, 47, 13, 2, 35, 23, 50, 16 };
                        break;
                }
            }
            return arrayDeAleatorios;

        }

        private int ObtenerNumeroDePreguntas()
        {
            var num = FormMain.NUMERO_DE_PREGUNTAS;
            return num;
        }
        private bool CampoValidos()
        {
            if (string.IsNullOrEmpty(this.TxtFirstName.Text))
            {
                MessageBox.Show("Ingrese su Nombre");
                return false;
            }
            if (string.IsNullOrEmpty(this.TxtLastName.Text))
            {
                MessageBox.Show("Ingrese su Apellido");
                return false;
            }
            return true;
        }
        private int ObtenerUltimoIdExamen()
        {
            using (ModelContainer conexion = new ModelContainer())
            {
                int id = conexion.Examenes.Max(u => u.IdExamen);
                FormMain.idExamenActual = id;
                return id;
            }
        }

        private int ObtenerUltimoIdAlumno()
        {
            using (ModelContainer conexion = new ModelContainer())
            {
                int id = conexion.Alumnos.Max(u => u.IdAlumno);
                return id;
            }
        }
        private int ObtenerIdAlumno(int idAlumno)
        {
            if(idAlumno != 0)
            {
                return idAlumno;
            }
            else
            {
                idAlumno = ObtenerUltimoIdAlumno();
            }
            return idAlumno;
        }

        private int ObtenerUltimoIdDetalleExamen()
        {
            using (ModelContainer conexion = new ModelContainer())
            {
                int id = conexion.DetalleExamenes.Max(u => u.IdDetalleExamen);
                return id;
            }
        }

        private void FormStartExam_VisibleChanged(object sender, EventArgs e)
        {
            LblChangeType_Click(sender, e);
        }
        #endregion
    }
}
