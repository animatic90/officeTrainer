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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.nombreExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGoToExam = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.BtnBack.Location = new System.Drawing.Point(14, 565);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBack.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBack.selected = false;
            this.BtnBack.Size = new System.Drawing.Size(140, 60);
            this.BtnBack.TabIndex = 22;
            this.BtnBack.Text = "<< VOLVER";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Textcolor = System.Drawing.Color.White;
            this.BtnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PnlNames
            // 
            this.PnlNames.Controls.Add(this.RbLastName);
            this.PnlNames.Controls.Add(this.RbFirstName);
            this.PnlNames.Controls.Add(this.BtnSearch);
            this.PnlNames.Controls.Add(this.TxtSearch);
            this.PnlNames.Controls.Add(this.label6);
            this.PnlNames.Location = new System.Drawing.Point(271, 103);
            this.PnlNames.Margin = new System.Windows.Forms.Padding(4);
            this.PnlNames.Name = "PnlNames";
            this.PnlNames.Size = new System.Drawing.Size(713, 132);
            this.PnlNames.TabIndex = 21;
            // 
            // RbLastName
            // 
            this.RbLastName.AutoSize = true;
            this.RbLastName.ForeColor = System.Drawing.Color.White;
            this.RbLastName.Location = new System.Drawing.Point(304, 95);
            this.RbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.RbLastName.Name = "RbLastName";
            this.RbLastName.Size = new System.Drawing.Size(79, 21);
            this.RbLastName.TabIndex = 20;
            this.RbLastName.Text = "Apellido";
            this.RbLastName.UseVisualStyleBackColor = true;
            // 
            // RbFirstName
            // 
            this.RbFirstName.AutoSize = true;
            this.RbFirstName.Checked = true;
            this.RbFirstName.ForeColor = System.Drawing.Color.White;
            this.RbFirstName.Location = new System.Drawing.Point(96, 95);
            this.RbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.RbFirstName.Name = "RbFirstName";
            this.RbFirstName.Size = new System.Drawing.Size(79, 21);
            this.RbFirstName.TabIndex = 19;
            this.RbFirstName.TabStop = true;
            this.RbFirstName.Text = "Nombre";
            this.RbFirstName.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Activecolor = System.Drawing.Color.Yellow;
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
            this.BtnSearch.Location = new System.Drawing.Point(561, 41);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSearch.selected = false;
            this.BtnSearch.Size = new System.Drawing.Size(109, 35);
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
            this.TxtSearch.Location = new System.Drawing.Point(24, 52);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(467, 22);
            this.TxtSearch.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(19, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ingrese sus datos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-21, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1270, 225);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombres,
            this.apellidos,
            this.idAlumno});
            this.DgvAlumnos.Location = new System.Drawing.Point(181, 243);
            this.DgvAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvAlumnos.MultiSelect = false;
            this.DgvAlumnos.Name = "DgvAlumnos";
            this.DgvAlumnos.RowHeadersVisible = false;
            this.DgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAlumnos.Size = new System.Drawing.Size(388, 359);
            this.DgvAlumnos.TabIndex = 24;
            this.DgvAlumnos.Visible = false;
            this.DgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlumnos_CellClick);
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "Nombres";
            this.nombres.MinimumWidth = 2;
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "Apellidos";
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
            this.DgvExams.ColumnHeadersVisible = false;
            this.DgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreExamen,
            this.fecha,
            this.idExamen});
            this.DgvExams.Location = new System.Drawing.Point(620, 268);
            this.DgvExams.Margin = new System.Windows.Forms.Padding(4);
            this.DgvExams.MultiSelect = false;
            this.DgvExams.Name = "DgvExams";
            this.DgvExams.ReadOnly = true;
            this.DgvExams.RowHeadersVisible = false;
            this.DgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvExams.Size = new System.Drawing.Size(388, 334);
            this.DgvExams.TabIndex = 25;
            this.DgvExams.Visible = false;
            this.DgvExams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExams_CellClick);
            // 
            // nombreExamen
            // 
            this.nombreExamen.DataPropertyName = "nombreExamen";
            this.nombreExamen.HeaderText = "Examen";
            this.nombreExamen.Name = "nombreExamen";
            this.nombreExamen.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // idExamen
            // 
            this.idExamen.DataPropertyName = "idExamen";
            this.idExamen.HeaderText = "idExamen";
            this.idExamen.Name = "idExamen";
            this.idExamen.ReadOnly = true;
            this.idExamen.Visible = false;
            // 
            // BtnGoToExam
            // 
            this.BtnGoToExam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnGoToExam.BackColor = System.Drawing.Color.Yellow;
            this.BtnGoToExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGoToExam.BorderRadius = 0;
            this.BtnGoToExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnGoToExam.ButtonText = "IR A EXAMEN >>";
            this.BtnGoToExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGoToExam.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnGoToExam.Enabled = false;
            this.BtnGoToExam.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGoToExam.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGoToExam.Iconimage")));
            this.BtnGoToExam.Iconimage_right = null;
            this.BtnGoToExam.Iconimage_right_Selected = null;
            this.BtnGoToExam.Iconimage_Selected = null;
            this.BtnGoToExam.IconMarginLeft = 0;
            this.BtnGoToExam.IconMarginRight = 0;
            this.BtnGoToExam.IconRightVisible = false;
            this.BtnGoToExam.IconRightZoom = 0D;
            this.BtnGoToExam.IconVisible = false;
            this.BtnGoToExam.IconZoom = 90D;
            this.BtnGoToExam.IsTab = false;
            this.BtnGoToExam.Location = new System.Drawing.Point(1036, 564);
            this.BtnGoToExam.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGoToExam.Name = "BtnGoToExam";
            this.BtnGoToExam.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnGoToExam.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnGoToExam.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGoToExam.selected = false;
            this.BtnGoToExam.Size = new System.Drawing.Size(190, 61);
            this.BtnGoToExam.TabIndex = 26;
            this.BtnGoToExam.Text = "IR A EXAMEN >>";
            this.BtnGoToExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGoToExam.Textcolor = System.Drawing.Color.Black;
            this.BtnGoToExam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoToExam.Click += new System.EventHandler(this.BtnGoToExam_Click);
            // 
            // FormContinueToExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.BtnGoToExam);
            this.Controls.Add(this.DgvExams);
            this.Controls.Add(this.DgvAlumnos);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PnlNames);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContinueToExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Continue Exam";
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
        private System.Windows.Forms.DataGridView DgvAlumnos;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGoToExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExamen;
    }
}