namespace Vista
{
    partial class FormContinueToExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContinueToExam));
            this.BtnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlNames = new System.Windows.Forms.Panel();
            this.RbLastName = new System.Windows.Forms.RadioButton();
            this.RbFirstName = new System.Windows.Forms.RadioButton();
            this.BtnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvAlumnos = new System.Windows.Forms.DataGridView();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvExams = new System.Windows.Forms.DataGridView();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nombreExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExams)).BeginInit();
            this.SuspendLayout();
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
            this.BtnBack.Location = new System.Drawing.Point(13, 618);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBack.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBack.selected = false;
            this.BtnBack.Size = new System.Drawing.Size(105, 50);
            this.BtnBack.TabIndex = 22;
            this.BtnBack.Text = "<< VOLVER";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Textcolor = System.Drawing.Color.White;
            this.BtnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PnlNames
            // 
            this.PnlNames.Controls.Add(this.RbLastName);
            this.PnlNames.Controls.Add(this.RbFirstName);
            this.PnlNames.Controls.Add(this.BtnSearch);
            this.PnlNames.Controls.Add(this.TxtSearch);
            this.PnlNames.Controls.Add(this.label6);
            this.PnlNames.Location = new System.Drawing.Point(366, 147);
            this.PnlNames.Name = "PnlNames";
            this.PnlNames.Size = new System.Drawing.Size(535, 107);
            this.PnlNames.TabIndex = 21;
            // 
            // RbLastName
            // 
            this.RbLastName.AutoSize = true;
            this.RbLastName.ForeColor = System.Drawing.Color.White;
            this.RbLastName.Location = new System.Drawing.Point(228, 77);
            this.RbLastName.Name = "RbLastName";
            this.RbLastName.Size = new System.Drawing.Size(62, 17);
            this.RbLastName.TabIndex = 20;
            this.RbLastName.TabStop = true;
            this.RbLastName.Text = "Apellido";
            this.RbLastName.UseVisualStyleBackColor = true;
            // 
            // RbFirstName
            // 
            this.RbFirstName.AutoSize = true;
            this.RbFirstName.ForeColor = System.Drawing.Color.White;
            this.RbFirstName.Location = new System.Drawing.Point(72, 77);
            this.RbFirstName.Name = "RbFirstName";
            this.RbFirstName.Size = new System.Drawing.Size(62, 17);
            this.RbFirstName.TabIndex = 19;
            this.RbFirstName.TabStop = true;
            this.RbFirstName.Text = "Nombre";
            this.RbFirstName.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSearch.BackColor = System.Drawing.Color.Yellow;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearch.BorderRadius = 0;
            this.BtnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnSearch.ButtonText = "BUSCAR";
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Iconimage")));
            this.BtnSearch.Iconimage_right = null;
            this.BtnSearch.Iconimage_right_Selected = null;
            this.BtnSearch.Iconimage_Selected = null;
            this.BtnSearch.IconMarginLeft = 0;
            this.BtnSearch.IconMarginRight = 0;
            this.BtnSearch.IconRightVisible = false;
            this.BtnSearch.IconRightZoom = 0D;
            this.BtnSearch.IconVisible = false;
            this.BtnSearch.IconZoom = 90D;
            this.BtnSearch.IsTab = false;
            this.BtnSearch.Location = new System.Drawing.Point(421, 33);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSearch.selected = false;
            this.BtnSearch.Size = new System.Drawing.Size(82, 29);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "BUSCAR";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Textcolor = System.Drawing.Color.Black;
            this.BtnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSearch.Location = new System.Drawing.Point(18, 42);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(351, 20);
            this.TxtSearch.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(14, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ingrese sus datos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 183);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // DgvAlumnos
            // 
            this.DgvAlumnos.AllowUserToAddRows = false;
            this.DgvAlumnos.AllowUserToDeleteRows = false;
            this.DgvAlumnos.AllowUserToResizeColumns = false;
            this.DgvAlumnos.AllowUserToResizeRows = false;
            this.DgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombres,
            this.apellidos,
            this.idAlumno});
            this.DgvAlumnos.Location = new System.Drawing.Point(253, 279);
            this.DgvAlumnos.Name = "DgvAlumnos";
            this.DgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAlumnos.Size = new System.Drawing.Size(289, 292);
            this.DgvAlumnos.TabIndex = 24;
            this.DgvAlumnos.Visible = false;
            this.DgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlumnos_CellClick);
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "nombres";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "idAlumno";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.Visible = false;
            // 
            // DgvExams
            // 
            this.DgvExams.AllowUserToAddRows = false;
            this.DgvExams.AllowUserToDeleteRows = false;
            this.DgvExams.AllowUserToResizeColumns = false;
            this.DgvExams.AllowUserToResizeRows = false;
            this.DgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreExamen,
            this.fecha,
            this.idExamen});
            this.DgvExams.Location = new System.Drawing.Point(603, 279);
            this.DgvExams.Name = "DgvExams";
            this.DgvExams.Size = new System.Drawing.Size(358, 292);
            this.DgvExams.TabIndex = 25;
            this.DgvExams.Visible = false;
            this.DgvExams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExams_CellClick);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "IR A EXAMEN >>";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1028, 618);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(143, 50);
            this.bunifuFlatButton1.TabIndex = 26;
            this.bunifuFlatButton1.Text = "IR A EXAMEN >>";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // nombreExamen
            // 
            this.nombreExamen.DataPropertyName = "nombreExamen";
            this.nombreExamen.HeaderText = "nombreExamen";
            this.nombreExamen.Name = "nombreExamen";
            this.nombreExamen.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // idExamen
            // 
            this.idExamen.DataPropertyName = "idExamen";
            this.idExamen.HeaderText = "idExamen";
            this.idExamen.Name = "idExamen";
            this.idExamen.ReadOnly = true;
            // 
            // FormContinueToExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.DgvExams);
            this.Controls.Add(this.DgvAlumnos);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PnlNames);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormContinueToExam";
            this.Text = "FormContinueToExam";
            this.Load += new System.EventHandler(this.FormContinueToExam_Load);
            this.PnlNames.ResumeLayout(false);
            this.PnlNames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnBack;
        private System.Windows.Forms.Panel PnlNames;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSearch;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RbLastName;
        private System.Windows.Forms.RadioButton RbFirstName;
        private System.Windows.Forms.DataGridView DgvExams;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridView DgvAlumnos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExamen;
    }
}