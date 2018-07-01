namespace Vista
{
    partial class FormDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBase));
            this.BtnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlSelectExam = new System.Windows.Forms.Panel();
            this.BtnThisMonth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnThisWeek = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnToday = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDetailsAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDetailsByCandidate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnTotalTrouble = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnTotalCumulative = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvPuntuacion = new System.Windows.Forms.DataGridView();
            this.DgvDetalleAlumno = new System.Windows.Forms.DataGridView();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDetalleExamen = new System.Windows.Forms.DataGridView();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.GbScore = new System.Windows.Forms.GroupBox();
            this.GbDetailByCandidate = new System.Windows.Forms.GroupBox();
            this.GbDetailAll = new System.Windows.Forms.GroupBox();
            this.DgvTodoDetalle = new System.Windows.Forms.DataGridView();
            this.DgvTodoExamen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlSelectExam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuntuacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleExamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.GbScore.SuspendLayout();
            this.GbDetailByCandidate.SuspendLayout();
            this.GbDetailAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodoExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrint
            // 
            this.BtnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnPrint.BackColor = System.Drawing.Color.Yellow;
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrint.BorderRadius = 0;
            this.BtnPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnPrint.ButtonText = "IMPRIMIR >>";
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnPrint.Enabled = false;
            this.BtnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Iconimage")));
            this.BtnPrint.Iconimage_right = null;
            this.BtnPrint.Iconimage_right_Selected = null;
            this.BtnPrint.Iconimage_Selected = null;
            this.BtnPrint.IconMarginLeft = 0;
            this.BtnPrint.IconMarginRight = 0;
            this.BtnPrint.IconRightVisible = false;
            this.BtnPrint.IconRightZoom = 0D;
            this.BtnPrint.IconVisible = false;
            this.BtnPrint.IconZoom = 90D;
            this.BtnPrint.IsTab = false;
            this.BtnPrint.Location = new System.Drawing.Point(1058, 559);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnPrint.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPrint.selected = false;
            this.BtnPrint.Size = new System.Drawing.Size(183, 60);
            this.BtnPrint.TabIndex = 32;
            this.BtnPrint.Text = "IMPRIMIR >>";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Textcolor = System.Drawing.Color.Black;
            this.BtnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBack.BorderRadius = 0;
            this.BtnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnBack.ButtonText = "<< VOLVER";
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.DisabledColor = System.Drawing.Color.Gray;
            this.BtnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnBack.Iconimage")));
            this.BtnBack.Iconimage_right = null;
            this.BtnBack.Iconimage_right_Selected = null;
            this.BtnBack.Iconimage_Selected = null;
            this.BtnBack.IconMarginLeft = 0;
            this.BtnBack.IconMarginRight = 0;
            this.BtnBack.IconRightVisible = false;
            this.BtnBack.IconRightZoom = 0D;
            this.BtnBack.IconVisible = false;
            this.BtnBack.IconZoom = 90D;
            this.BtnBack.IsTab = false;
            this.BtnBack.Location = new System.Drawing.Point(14, 559);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBack.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBack.selected = false;
            this.BtnBack.Size = new System.Drawing.Size(140, 60);
            this.BtnBack.TabIndex = 28;
            this.BtnBack.Text = "<< VOLVER";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Textcolor = System.Drawing.Color.White;
            this.BtnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 225);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // PnlSelectExam
            // 
            this.PnlSelectExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSelectExam.Controls.Add(this.BtnThisMonth);
            this.PnlSelectExam.Controls.Add(this.BtnThisWeek);
            this.PnlSelectExam.Controls.Add(this.BtnToday);
            this.PnlSelectExam.Controls.Add(this.label2);
            this.PnlSelectExam.Location = new System.Drawing.Point(163, 105);
            this.PnlSelectExam.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSelectExam.Name = "PnlSelectExam";
            this.PnlSelectExam.Size = new System.Drawing.Size(293, 175);
            this.PnlSelectExam.TabIndex = 33;
            // 
            // BtnThisMonth
            // 
            this.BtnThisMonth.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnThisMonth.BackColor = System.Drawing.Color.Navy;
            this.BtnThisMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnThisMonth.BorderRadius = 0;
            this.BtnThisMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnThisMonth.ButtonText = "Este mes";
            this.BtnThisMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnThisMonth.DisabledColor = System.Drawing.Color.Gray;
            this.BtnThisMonth.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnThisMonth.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnThisMonth.Iconimage")));
            this.BtnThisMonth.Iconimage_right = null;
            this.BtnThisMonth.Iconimage_right_Selected = null;
            this.BtnThisMonth.Iconimage_Selected = null;
            this.BtnThisMonth.IconMarginLeft = 0;
            this.BtnThisMonth.IconMarginRight = 0;
            this.BtnThisMonth.IconRightVisible = false;
            this.BtnThisMonth.IconRightZoom = 0D;
            this.BtnThisMonth.IconVisible = false;
            this.BtnThisMonth.IconZoom = 90D;
            this.BtnThisMonth.IsTab = false;
            this.BtnThisMonth.Location = new System.Drawing.Point(26, 121);
            this.BtnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.BtnThisMonth.Name = "BtnThisMonth";
            this.BtnThisMonth.Normalcolor = System.Drawing.Color.Navy;
            this.BtnThisMonth.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnThisMonth.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnThisMonth.selected = false;
            this.BtnThisMonth.Size = new System.Drawing.Size(242, 37);
            this.BtnThisMonth.TabIndex = 2;
            this.BtnThisMonth.Text = "Este mes";
            this.BtnThisMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThisMonth.Textcolor = System.Drawing.Color.White;
            this.BtnThisMonth.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThisMonth.Click += new System.EventHandler(this.BtnThisMonth_Click);
            // 
            // BtnThisWeek
            // 
            this.BtnThisWeek.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnThisWeek.BackColor = System.Drawing.Color.Navy;
            this.BtnThisWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnThisWeek.BorderRadius = 0;
            this.BtnThisWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnThisWeek.ButtonText = "Esta semana";
            this.BtnThisWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnThisWeek.DisabledColor = System.Drawing.Color.Gray;
            this.BtnThisWeek.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnThisWeek.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnThisWeek.Iconimage")));
            this.BtnThisWeek.Iconimage_right = null;
            this.BtnThisWeek.Iconimage_right_Selected = null;
            this.BtnThisWeek.Iconimage_Selected = null;
            this.BtnThisWeek.IconMarginLeft = 0;
            this.BtnThisWeek.IconMarginRight = 0;
            this.BtnThisWeek.IconRightVisible = false;
            this.BtnThisWeek.IconRightZoom = 0D;
            this.BtnThisWeek.IconVisible = false;
            this.BtnThisWeek.IconZoom = 90D;
            this.BtnThisWeek.IsTab = false;
            this.BtnThisWeek.Location = new System.Drawing.Point(26, 83);
            this.BtnThisWeek.Margin = new System.Windows.Forms.Padding(5);
            this.BtnThisWeek.Name = "BtnThisWeek";
            this.BtnThisWeek.Normalcolor = System.Drawing.Color.Navy;
            this.BtnThisWeek.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnThisWeek.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnThisWeek.selected = false;
            this.BtnThisWeek.Size = new System.Drawing.Size(242, 37);
            this.BtnThisWeek.TabIndex = 1;
            this.BtnThisWeek.Text = "Esta semana";
            this.BtnThisWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThisWeek.Textcolor = System.Drawing.Color.White;
            this.BtnThisWeek.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThisWeek.Click += new System.EventHandler(this.BtnThisWeek_Click);
            // 
            // BtnToday
            // 
            this.BtnToday.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnToday.BackColor = System.Drawing.Color.Navy;
            this.BtnToday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnToday.BorderRadius = 0;
            this.BtnToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnToday.ButtonText = "Hoy";
            this.BtnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToday.DisabledColor = System.Drawing.Color.Gray;
            this.BtnToday.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnToday.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnToday.Iconimage")));
            this.BtnToday.Iconimage_right = null;
            this.BtnToday.Iconimage_right_Selected = null;
            this.BtnToday.Iconimage_Selected = null;
            this.BtnToday.IconMarginLeft = 0;
            this.BtnToday.IconMarginRight = 0;
            this.BtnToday.IconRightVisible = false;
            this.BtnToday.IconRightZoom = 0D;
            this.BtnToday.IconVisible = false;
            this.BtnToday.IconZoom = 90D;
            this.BtnToday.IsTab = false;
            this.BtnToday.Location = new System.Drawing.Point(27, 44);
            this.BtnToday.Margin = new System.Windows.Forms.Padding(5);
            this.BtnToday.Name = "BtnToday";
            this.BtnToday.Normalcolor = System.Drawing.Color.Navy;
            this.BtnToday.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnToday.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnToday.selected = false;
            this.BtnToday.Size = new System.Drawing.Size(242, 37);
            this.BtnToday.TabIndex = 0;
            this.BtnToday.Text = "Hoy";
            this.BtnToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnToday.Textcolor = System.Drawing.Color.White;
            this.BtnToday.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puntuación de Examen:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnDetailsAll);
            this.panel1.Controls.Add(this.BtnDetailsByCandidate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(163, 289);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 136);
            this.panel1.TabIndex = 34;
            // 
            // BtnDetailsAll
            // 
            this.BtnDetailsAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnDetailsAll.BackColor = System.Drawing.Color.Navy;
            this.BtnDetailsAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDetailsAll.BorderRadius = 0;
            this.BtnDetailsAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnDetailsAll.ButtonText = "Todos los examenes";
            this.BtnDetailsAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetailsAll.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDetailsAll.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDetailsAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDetailsAll.Iconimage")));
            this.BtnDetailsAll.Iconimage_right = null;
            this.BtnDetailsAll.Iconimage_right_Selected = null;
            this.BtnDetailsAll.Iconimage_Selected = null;
            this.BtnDetailsAll.IconMarginLeft = 0;
            this.BtnDetailsAll.IconMarginRight = 0;
            this.BtnDetailsAll.IconRightVisible = false;
            this.BtnDetailsAll.IconRightZoom = 0D;
            this.BtnDetailsAll.IconVisible = false;
            this.BtnDetailsAll.IconZoom = 90D;
            this.BtnDetailsAll.IsTab = false;
            this.BtnDetailsAll.Location = new System.Drawing.Point(26, 83);
            this.BtnDetailsAll.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDetailsAll.Name = "BtnDetailsAll";
            this.BtnDetailsAll.Normalcolor = System.Drawing.Color.Navy;
            this.BtnDetailsAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnDetailsAll.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDetailsAll.selected = false;
            this.BtnDetailsAll.Size = new System.Drawing.Size(242, 37);
            this.BtnDetailsAll.TabIndex = 1;
            this.BtnDetailsAll.Text = "Todos los examenes";
            this.BtnDetailsAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDetailsAll.Textcolor = System.Drawing.Color.White;
            this.BtnDetailsAll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetailsAll.Click += new System.EventHandler(this.BtnDetailsAll_Click);
            // 
            // BtnDetailsByCandidate
            // 
            this.BtnDetailsByCandidate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnDetailsByCandidate.BackColor = System.Drawing.Color.Navy;
            this.BtnDetailsByCandidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDetailsByCandidate.BorderRadius = 0;
            this.BtnDetailsByCandidate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnDetailsByCandidate.ButtonText = "Examen por candidato";
            this.BtnDetailsByCandidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetailsByCandidate.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDetailsByCandidate.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDetailsByCandidate.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDetailsByCandidate.Iconimage")));
            this.BtnDetailsByCandidate.Iconimage_right = null;
            this.BtnDetailsByCandidate.Iconimage_right_Selected = null;
            this.BtnDetailsByCandidate.Iconimage_Selected = null;
            this.BtnDetailsByCandidate.IconMarginLeft = 0;
            this.BtnDetailsByCandidate.IconMarginRight = 0;
            this.BtnDetailsByCandidate.IconRightVisible = false;
            this.BtnDetailsByCandidate.IconRightZoom = 0D;
            this.BtnDetailsByCandidate.IconVisible = false;
            this.BtnDetailsByCandidate.IconZoom = 90D;
            this.BtnDetailsByCandidate.IsTab = false;
            this.BtnDetailsByCandidate.Location = new System.Drawing.Point(27, 44);
            this.BtnDetailsByCandidate.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDetailsByCandidate.Name = "BtnDetailsByCandidate";
            this.BtnDetailsByCandidate.Normalcolor = System.Drawing.Color.Navy;
            this.BtnDetailsByCandidate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnDetailsByCandidate.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDetailsByCandidate.selected = false;
            this.BtnDetailsByCandidate.Size = new System.Drawing.Size(242, 37);
            this.BtnDetailsByCandidate.TabIndex = 0;
            this.BtnDetailsByCandidate.Text = "Examen por candidato";
            this.BtnDetailsByCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDetailsByCandidate.Textcolor = System.Drawing.Color.White;
            this.BtnDetailsByCandidate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetailsByCandidate.Click += new System.EventHandler(this.BtnDetailsByCandidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detalle de Examen:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnTotalTrouble);
            this.panel2.Controls.Add(this.BtnTotalCumulative);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(163, 436);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 132);
            this.panel2.TabIndex = 35;
            // 
            // BtnTotalTrouble
            // 
            this.BtnTotalTrouble.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTotalTrouble.BackColor = System.Drawing.Color.Navy;
            this.BtnTotalTrouble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTotalTrouble.BorderRadius = 0;
            this.BtnTotalTrouble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnTotalTrouble.ButtonText = "Preguntas problemáticas";
            this.BtnTotalTrouble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTotalTrouble.DisabledColor = System.Drawing.Color.Gray;
            this.BtnTotalTrouble.Enabled = false;
            this.BtnTotalTrouble.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnTotalTrouble.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnTotalTrouble.Iconimage")));
            this.BtnTotalTrouble.Iconimage_right = null;
            this.BtnTotalTrouble.Iconimage_right_Selected = null;
            this.BtnTotalTrouble.Iconimage_Selected = null;
            this.BtnTotalTrouble.IconMarginLeft = 0;
            this.BtnTotalTrouble.IconMarginRight = 0;
            this.BtnTotalTrouble.IconRightVisible = false;
            this.BtnTotalTrouble.IconRightZoom = 0D;
            this.BtnTotalTrouble.IconVisible = false;
            this.BtnTotalTrouble.IconZoom = 90D;
            this.BtnTotalTrouble.IsTab = false;
            this.BtnTotalTrouble.Location = new System.Drawing.Point(26, 83);
            this.BtnTotalTrouble.Margin = new System.Windows.Forms.Padding(5);
            this.BtnTotalTrouble.Name = "BtnTotalTrouble";
            this.BtnTotalTrouble.Normalcolor = System.Drawing.Color.Navy;
            this.BtnTotalTrouble.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTotalTrouble.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnTotalTrouble.selected = false;
            this.BtnTotalTrouble.Size = new System.Drawing.Size(242, 37);
            this.BtnTotalTrouble.TabIndex = 1;
            this.BtnTotalTrouble.Text = "Preguntas problemáticas";
            this.BtnTotalTrouble.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTotalTrouble.Textcolor = System.Drawing.Color.White;
            this.BtnTotalTrouble.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTotalTrouble.Click += new System.EventHandler(this.BtnTotalTrouble_Click);
            // 
            // BtnTotalCumulative
            // 
            this.BtnTotalCumulative.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTotalCumulative.BackColor = System.Drawing.Color.Navy;
            this.BtnTotalCumulative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTotalCumulative.BorderRadius = 0;
            this.BtnTotalCumulative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnTotalCumulative.ButtonText = "Puntuación acumulada";
            this.BtnTotalCumulative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTotalCumulative.DisabledColor = System.Drawing.Color.Gray;
            this.BtnTotalCumulative.Enabled = false;
            this.BtnTotalCumulative.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnTotalCumulative.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnTotalCumulative.Iconimage")));
            this.BtnTotalCumulative.Iconimage_right = null;
            this.BtnTotalCumulative.Iconimage_right_Selected = null;
            this.BtnTotalCumulative.Iconimage_Selected = null;
            this.BtnTotalCumulative.IconMarginLeft = 0;
            this.BtnTotalCumulative.IconMarginRight = 0;
            this.BtnTotalCumulative.IconRightVisible = false;
            this.BtnTotalCumulative.IconRightZoom = 0D;
            this.BtnTotalCumulative.IconVisible = false;
            this.BtnTotalCumulative.IconZoom = 90D;
            this.BtnTotalCumulative.IsTab = false;
            this.BtnTotalCumulative.Location = new System.Drawing.Point(27, 44);
            this.BtnTotalCumulative.Margin = new System.Windows.Forms.Padding(5);
            this.BtnTotalCumulative.Name = "BtnTotalCumulative";
            this.BtnTotalCumulative.Normalcolor = System.Drawing.Color.Navy;
            this.BtnTotalCumulative.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTotalCumulative.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnTotalCumulative.selected = false;
            this.BtnTotalCumulative.Size = new System.Drawing.Size(242, 37);
            this.BtnTotalCumulative.TabIndex = 0;
            this.BtnTotalCumulative.Text = "Puntuación acumulada";
            this.BtnTotalCumulative.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTotalCumulative.Textcolor = System.Drawing.Color.White;
            this.BtnTotalCumulative.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Totales";
            // 
            // DgvPuntuacion
            // 
            this.DgvPuntuacion.AllowUserToAddRows = false;
            this.DgvPuntuacion.AllowUserToDeleteRows = false;
            this.DgvPuntuacion.AllowUserToResizeRows = false;
            this.DgvPuntuacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPuntuacion.Location = new System.Drawing.Point(6, 17);
            this.DgvPuntuacion.Name = "DgvPuntuacion";
            this.DgvPuntuacion.ReadOnly = true;
            this.DgvPuntuacion.RowHeadersVisible = false;
            this.DgvPuntuacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvPuntuacion.RowTemplate.Height = 24;
            this.DgvPuntuacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPuntuacion.Size = new System.Drawing.Size(730, 406);
            this.DgvPuntuacion.TabIndex = 36;
            // 
            // DgvDetalleAlumno
            // 
            this.DgvDetalleAlumno.AllowUserToAddRows = false;
            this.DgvDetalleAlumno.AllowUserToDeleteRows = false;
            this.DgvDetalleAlumno.AllowUserToResizeRows = false;
            this.DgvDetalleAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetalleAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres,
            this.Apellidos,
            this.IdAlumno});
            this.DgvDetalleAlumno.Location = new System.Drawing.Point(6, 12);
            this.DgvDetalleAlumno.Name = "DgvDetalleAlumno";
            this.DgvDetalleAlumno.ReadOnly = true;
            this.DgvDetalleAlumno.RowHeadersVisible = false;
            this.DgvDetalleAlumno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvDetalleAlumno.RowTemplate.Height = 24;
            this.DgvDetalleAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalleAlumno.Size = new System.Drawing.Size(205, 406);
            this.DgvDetalleAlumno.TabIndex = 37;
            this.DgvDetalleAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleAlumno_CellClick);
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // IdAlumno
            // 
            this.IdAlumno.DataPropertyName = "IdAlumno";
            this.IdAlumno.HeaderText = "IdAlumno";
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.ReadOnly = true;
            this.IdAlumno.Visible = false;
            // 
            // DgvDetalleExamen
            // 
            this.DgvDetalleExamen.AllowUserToAddRows = false;
            this.DgvDetalleExamen.AllowUserToDeleteRows = false;
            this.DgvDetalleExamen.AllowUserToResizeRows = false;
            this.DgvDetalleExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetalleExamen.Location = new System.Drawing.Point(224, 12);
            this.DgvDetalleExamen.Name = "DgvDetalleExamen";
            this.DgvDetalleExamen.ReadOnly = true;
            this.DgvDetalleExamen.RowHeadersVisible = false;
            this.DgvDetalleExamen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvDetalleExamen.RowTemplate.Height = 24;
            this.DgvDetalleExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalleExamen.Size = new System.Drawing.Size(525, 224);
            this.DgvDetalleExamen.TabIndex = 38;
            this.DgvDetalleExamen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleExamen_CellClick);
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.AllowUserToDeleteRows = false;
            this.DgvDetalle.AllowUserToResizeRows = false;
            this.DgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetalle.Location = new System.Drawing.Point(224, 242);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.ReadOnly = true;
            this.DgvDetalle.RowHeadersVisible = false;
            this.DgvDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvDetalle.RowTemplate.Height = 24;
            this.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalle.Size = new System.Drawing.Size(525, 176);
            this.DgvDetalle.TabIndex = 39;
            // 
            // GbScore
            // 
            this.GbScore.Controls.Add(this.DgvPuntuacion);
            this.GbScore.Location = new System.Drawing.Point(492, 121);
            this.GbScore.Name = "GbScore";
            this.GbScore.Size = new System.Drawing.Size(749, 429);
            this.GbScore.TabIndex = 40;
            this.GbScore.TabStop = false;
            this.GbScore.Text = "groupBox1";
            this.GbScore.Visible = false;
            // 
            // GbDetailByCandidate
            // 
            this.GbDetailByCandidate.Controls.Add(this.DgvDetalleAlumno);
            this.GbDetailByCandidate.Controls.Add(this.DgvDetalleExamen);
            this.GbDetailByCandidate.Controls.Add(this.DgvDetalle);
            this.GbDetailByCandidate.Location = new System.Drawing.Point(475, 126);
            this.GbDetailByCandidate.Name = "GbDetailByCandidate";
            this.GbDetailByCandidate.Size = new System.Drawing.Size(760, 424);
            this.GbDetailByCandidate.TabIndex = 41;
            this.GbDetailByCandidate.TabStop = false;
            this.GbDetailByCandidate.Text = "groupBox1";
            this.GbDetailByCandidate.Visible = false;
            // 
            // GbDetailAll
            // 
            this.GbDetailAll.BackColor = System.Drawing.Color.Transparent;
            this.GbDetailAll.Controls.Add(this.DgvTodoDetalle);
            this.GbDetailAll.Controls.Add(this.DgvTodoExamen);
            this.GbDetailAll.Location = new System.Drawing.Point(492, 122);
            this.GbDetailAll.Name = "GbDetailAll";
            this.GbDetailAll.Size = new System.Drawing.Size(749, 428);
            this.GbDetailAll.TabIndex = 41;
            this.GbDetailAll.TabStop = false;
            this.GbDetailAll.Text = "groupBox1";
            this.GbDetailAll.Visible = false;
            // 
            // DgvTodoDetalle
            // 
            this.DgvTodoDetalle.AllowUserToAddRows = false;
            this.DgvTodoDetalle.AllowUserToDeleteRows = false;
            this.DgvTodoDetalle.AllowUserToResizeRows = false;
            this.DgvTodoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTodoDetalle.Location = new System.Drawing.Point(7, 225);
            this.DgvTodoDetalle.Name = "DgvTodoDetalle";
            this.DgvTodoDetalle.ReadOnly = true;
            this.DgvTodoDetalle.RowHeadersVisible = false;
            this.DgvTodoDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvTodoDetalle.RowTemplate.Height = 24;
            this.DgvTodoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTodoDetalle.Size = new System.Drawing.Size(729, 197);
            this.DgvTodoDetalle.TabIndex = 40;
            // 
            // DgvTodoExamen
            // 
            this.DgvTodoExamen.AllowUserToAddRows = false;
            this.DgvTodoExamen.AllowUserToDeleteRows = false;
            this.DgvTodoExamen.AllowUserToResizeRows = false;
            this.DgvTodoExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTodoExamen.Location = new System.Drawing.Point(7, 17);
            this.DgvTodoExamen.Name = "DgvTodoExamen";
            this.DgvTodoExamen.ReadOnly = true;
            this.DgvTodoExamen.RowHeadersVisible = false;
            this.DgvTodoExamen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvTodoExamen.RowTemplate.Height = 24;
            this.DgvTodoExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTodoExamen.Size = new System.Drawing.Size(730, 202);
            this.DgvTodoExamen.TabIndex = 36;
            this.DgvTodoExamen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTodoExamen_CellClick);
            // 
            // FormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlSelectExam);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.GbScore);
            this.Controls.Add(this.GbDetailAll);
            this.Controls.Add(this.GbDetailByCandidate);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Data Base";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlSelectExam.ResumeLayout(false);
            this.PnlSelectExam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuntuacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleExamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.GbScore.ResumeLayout(false);
            this.GbDetailByCandidate.ResumeLayout(false);
            this.GbDetailAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodoExamen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlSelectExam;
        private Bunifu.Framework.UI.BunifuFlatButton BtnThisMonth;
        private Bunifu.Framework.UI.BunifuFlatButton BtnThisWeek;
        private Bunifu.Framework.UI.BunifuFlatButton BtnToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDetailsAll;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDetailsByCandidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnTotalTrouble;
        private Bunifu.Framework.UI.BunifuFlatButton BtnTotalCumulative;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvPuntuacion;
        private System.Windows.Forms.DataGridView DgvDetalleAlumno;
        private System.Windows.Forms.DataGridView DgvDetalleExamen;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.GroupBox GbScore;
        private System.Windows.Forms.GroupBox GbDetailByCandidate;
        private System.Windows.Forms.GroupBox GbDetailAll;
        private System.Windows.Forms.DataGridView DgvTodoExamen;
        private System.Windows.Forms.DataGridView DgvTodoDetalle;
    }
}