﻿namespace Vista
{
    partial class FormStartExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartExam));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblChangeType = new System.Windows.Forms.Label();
            this.PnlSelectExam = new System.Windows.Forms.Panel();
            this.BtnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnPowerPoint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnWord = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnShowExams = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlSelectedExam = new System.Windows.Forms.Panel();
            this.LblChangeExam = new System.Windows.Forms.Label();
            this.BtnSelectedExam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlNames = new System.Windows.Forms.Panel();
            this.TxtFirstName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtLastName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChbOrdenPregAle = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label222 = new System.Windows.Forms.Label();
            this.ChbCronometro = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label8 = new System.Windows.Forms.Label();
            this.ChbGuardarResultados = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label11 = new System.Windows.Forms.Label();
            this.ChbEntrenamiento = new Bunifu.Framework.UI.BunifuCheckbox();
            this.PnlOptions = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnComenzarExamen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LblNumeroPregunta = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlSelectExam.SuspendLayout();
            this.PnlSelectedExam.SuspendLayout();
            this.PnlNames.SuspendLayout();
            this.PnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 237);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(399, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una categoría de examen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elija un examen:";
            // 
            // LblChangeType
            // 
            this.LblChangeType.AutoSize = true;
            this.LblChangeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangeType.ForeColor = System.Drawing.Color.Silver;
            this.LblChangeType.Location = new System.Drawing.Point(660, 238);
            this.LblChangeType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblChangeType.Name = "LblChangeType";
            this.LblChangeType.Size = new System.Drawing.Size(161, 20);
            this.LblChangeType.TabIndex = 9;
            this.LblChangeType.Text = "(Click para cambiar)";
            this.LblChangeType.Click += new System.EventHandler(this.LblChangeType_Click);
            // 
            // PnlSelectExam
            // 
            this.PnlSelectExam.Controls.Add(this.BtnExcel);
            this.PnlSelectExam.Controls.Add(this.BtnPowerPoint);
            this.PnlSelectExam.Controls.Add(this.BtnWord);
            this.PnlSelectExam.Controls.Add(this.label2);
            this.PnlSelectExam.Location = new System.Drawing.Point(837, 110);
            this.PnlSelectExam.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSelectExam.Name = "PnlSelectExam";
            this.PnlSelectExam.Size = new System.Drawing.Size(434, 327);
            this.PnlSelectExam.TabIndex = 10;
            this.PnlSelectExam.Visible = false;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnExcel.BackColor = System.Drawing.Color.Navy;
            this.BtnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExcel.BorderRadius = 0;
            this.BtnExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnExcel.ButtonText = "Excel";
            this.BtnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcel.DisabledColor = System.Drawing.Color.Gray;
            this.BtnExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnExcel.Iconimage")));
            this.BtnExcel.Iconimage_right = null;
            this.BtnExcel.Iconimage_right_Selected = null;
            this.BtnExcel.Iconimage_Selected = null;
            this.BtnExcel.IconMarginLeft = 0;
            this.BtnExcel.IconMarginRight = 0;
            this.BtnExcel.IconRightVisible = false;
            this.BtnExcel.IconRightZoom = 0D;
            this.BtnExcel.IconVisible = false;
            this.BtnExcel.IconZoom = 90D;
            this.BtnExcel.IsTab = false;
            this.BtnExcel.Location = new System.Drawing.Point(35, 241);
            this.BtnExcel.Margin = new System.Windows.Forms.Padding(5);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Normalcolor = System.Drawing.Color.Navy;
            this.BtnExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnExcel.selected = false;
            this.BtnExcel.Size = new System.Drawing.Size(268, 50);
            this.BtnExcel.TabIndex = 2;
            this.BtnExcel.Text = "Excel";
            this.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcel.Textcolor = System.Drawing.Color.White;
            this.BtnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnPowerPoint
            // 
            this.BtnPowerPoint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnPowerPoint.BackColor = System.Drawing.Color.Navy;
            this.BtnPowerPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPowerPoint.BorderRadius = 0;
            this.BtnPowerPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnPowerPoint.ButtonText = "Power Point";
            this.BtnPowerPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPowerPoint.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPowerPoint.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPowerPoint.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnPowerPoint.Iconimage")));
            this.BtnPowerPoint.Iconimage_right = null;
            this.BtnPowerPoint.Iconimage_right_Selected = null;
            this.BtnPowerPoint.Iconimage_Selected = null;
            this.BtnPowerPoint.IconMarginLeft = 0;
            this.BtnPowerPoint.IconMarginRight = 0;
            this.BtnPowerPoint.IconRightVisible = false;
            this.BtnPowerPoint.IconRightZoom = 0D;
            this.BtnPowerPoint.IconVisible = false;
            this.BtnPowerPoint.IconZoom = 90D;
            this.BtnPowerPoint.IsTab = false;
            this.BtnPowerPoint.Location = new System.Drawing.Point(35, 183);
            this.BtnPowerPoint.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPowerPoint.Name = "BtnPowerPoint";
            this.BtnPowerPoint.Normalcolor = System.Drawing.Color.Navy;
            this.BtnPowerPoint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnPowerPoint.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPowerPoint.selected = false;
            this.BtnPowerPoint.Size = new System.Drawing.Size(268, 50);
            this.BtnPowerPoint.TabIndex = 1;
            this.BtnPowerPoint.Text = "Power Point";
            this.BtnPowerPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPowerPoint.Textcolor = System.Drawing.Color.White;
            this.BtnPowerPoint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPowerPoint.Click += new System.EventHandler(this.BtnPowerPoint_Click);
            // 
            // BtnWord
            // 
            this.BtnWord.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnWord.BackColor = System.Drawing.Color.Navy;
            this.BtnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnWord.BorderRadius = 0;
            this.BtnWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnWord.ButtonText = "Word";
            this.BtnWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWord.DisabledColor = System.Drawing.Color.Gray;
            this.BtnWord.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnWord.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnWord.Iconimage")));
            this.BtnWord.Iconimage_right = null;
            this.BtnWord.Iconimage_right_Selected = null;
            this.BtnWord.Iconimage_Selected = null;
            this.BtnWord.IconMarginLeft = 0;
            this.BtnWord.IconMarginRight = 0;
            this.BtnWord.IconRightVisible = false;
            this.BtnWord.IconRightZoom = 0D;
            this.BtnWord.IconVisible = false;
            this.BtnWord.IconZoom = 90D;
            this.BtnWord.IsTab = false;
            this.BtnWord.Location = new System.Drawing.Point(35, 126);
            this.BtnWord.Margin = new System.Windows.Forms.Padding(5);
            this.BtnWord.Name = "BtnWord";
            this.BtnWord.Normalcolor = System.Drawing.Color.Navy;
            this.BtnWord.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnWord.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnWord.selected = false;
            this.BtnWord.Size = new System.Drawing.Size(268, 50);
            this.BtnWord.TabIndex = 0;
            this.BtnWord.Text = "Word";
            this.BtnWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWord.Textcolor = System.Drawing.Color.White;
            this.BtnWord.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWord.Click += new System.EventHandler(this.BtnWord_Click);
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
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "<< VOLVER";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Textcolor = System.Drawing.Color.White;
            this.BtnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnShowExams
            // 
            this.BtnShowExams.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnShowExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnShowExams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnShowExams.BorderRadius = 0;
            this.BtnShowExams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnShowExams.ButtonText = "Examenes para Ms Office";
            this.BtnShowExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowExams.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnShowExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowExams.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnShowExams.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnShowExams.Iconimage")));
            this.BtnShowExams.Iconimage_right = null;
            this.BtnShowExams.Iconimage_right_Selected = null;
            this.BtnShowExams.Iconimage_Selected = null;
            this.BtnShowExams.IconMarginLeft = 0;
            this.BtnShowExams.IconMarginRight = 0;
            this.BtnShowExams.IconRightVisible = false;
            this.BtnShowExams.IconRightZoom = 0D;
            this.BtnShowExams.IconVisible = false;
            this.BtnShowExams.IconZoom = 90D;
            this.BtnShowExams.IsTab = false;
            this.BtnShowExams.Location = new System.Drawing.Point(373, 172);
            this.BtnShowExams.Margin = new System.Windows.Forms.Padding(5);
            this.BtnShowExams.Name = "BtnShowExams";
            this.BtnShowExams.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnShowExams.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnShowExams.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnShowExams.selected = false;
            this.BtnShowExams.Size = new System.Drawing.Size(458, 61);
            this.BtnShowExams.TabIndex = 12;
            this.BtnShowExams.Text = "Examenes para Ms Office";
            this.BtnShowExams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShowExams.Textcolor = System.Drawing.Color.White;
            this.BtnShowExams.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowExams.Click += new System.EventHandler(this.BtnShowExams_Click);
            // 
            // PnlSelectedExam
            // 
            this.PnlSelectedExam.Controls.Add(this.LblChangeExam);
            this.PnlSelectedExam.Controls.Add(this.BtnSelectedExam);
            this.PnlSelectedExam.Controls.Add(this.label4);
            this.PnlSelectedExam.Location = new System.Drawing.Point(840, 98);
            this.PnlSelectedExam.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSelectedExam.Name = "PnlSelectedExam";
            this.PnlSelectedExam.Size = new System.Drawing.Size(529, 219);
            this.PnlSelectedExam.TabIndex = 14;
            this.PnlSelectedExam.Visible = false;
            // 
            // LblChangeExam
            // 
            this.LblChangeExam.AutoSize = true;
            this.LblChangeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangeExam.ForeColor = System.Drawing.Color.Silver;
            this.LblChangeExam.Location = new System.Drawing.Point(205, 140);
            this.LblChangeExam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblChangeExam.Name = "LblChangeExam";
            this.LblChangeExam.Size = new System.Drawing.Size(161, 20);
            this.LblChangeExam.TabIndex = 15;
            this.LblChangeExam.Text = "(Click para cambiar)";
            this.LblChangeExam.Click += new System.EventHandler(this.LblCambiar_Click);
            // 
            // BtnSelectedExam
            // 
            this.BtnSelectedExam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSelectedExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSelectedExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelectedExam.BorderRadius = 0;
            this.BtnSelectedExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnSelectedExam.ButtonText = "";
            this.BtnSelectedExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectedExam.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSelectedExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectedExam.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSelectedExam.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSelectedExam.Iconimage")));
            this.BtnSelectedExam.Iconimage_right = null;
            this.BtnSelectedExam.Iconimage_right_Selected = null;
            this.BtnSelectedExam.Iconimage_Selected = null;
            this.BtnSelectedExam.IconMarginLeft = 0;
            this.BtnSelectedExam.IconMarginRight = 0;
            this.BtnSelectedExam.IconRightVisible = false;
            this.BtnSelectedExam.IconRightZoom = 0D;
            this.BtnSelectedExam.IconVisible = false;
            this.BtnSelectedExam.IconZoom = 90D;
            this.BtnSelectedExam.IsTab = false;
            this.BtnSelectedExam.Location = new System.Drawing.Point(12, 74);
            this.BtnSelectedExam.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSelectedExam.Name = "BtnSelectedExam";
            this.BtnSelectedExam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSelectedExam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSelectedExam.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSelectedExam.selected = false;
            this.BtnSelectedExam.Size = new System.Drawing.Size(354, 61);
            this.BtnSelectedExam.TabIndex = 13;
            this.BtnSelectedExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelectedExam.Textcolor = System.Drawing.Color.White;
            this.BtnSelectedExam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(26, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Elija un examen:";
            // 
            // PnlNames
            // 
            this.PnlNames.Controls.Add(this.TxtFirstName);
            this.PnlNames.Controls.Add(this.TxtLastName);
            this.PnlNames.Controls.Add(this.label7);
            this.PnlNames.Controls.Add(this.label6);
            this.PnlNames.Location = new System.Drawing.Point(258, 258);
            this.PnlNames.Margin = new System.Windows.Forms.Padding(4);
            this.PnlNames.Name = "PnlNames";
            this.PnlNames.Size = new System.Drawing.Size(713, 112);
            this.PnlNames.TabIndex = 15;
            this.PnlNames.Visible = false;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtFirstName.Location = new System.Drawing.Point(24, 73);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(309, 22);
            this.TxtFirstName.TabIndex = 1;
            this.TxtFirstName.Text = "asd";
            // 
            // TxtLastName
            // 
            this.TxtLastName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtLastName.Location = new System.Drawing.Point(383, 73);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(309, 22);
            this.TxtLastName.TabIndex = 2;
            this.TxtLastName.Text = "asd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(377, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombres:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(61, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Orden de preguntas aleatorio";
            // 
            // ChbOrdenPregAle
            // 
            this.ChbOrdenPregAle.BackColor = System.Drawing.Color.Transparent;
            this.ChbOrdenPregAle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChbOrdenPregAle.ChechedOffColor = System.Drawing.Color.Transparent;
            this.ChbOrdenPregAle.Checked = false;
            this.ChbOrdenPregAle.CheckedOnColor = System.Drawing.Color.Transparent;
            this.ChbOrdenPregAle.ForeColor = System.Drawing.Color.White;
            this.ChbOrdenPregAle.Location = new System.Drawing.Point(27, 25);
            this.ChbOrdenPregAle.Margin = new System.Windows.Forms.Padding(5);
            this.ChbOrdenPregAle.Name = "ChbOrdenPregAle";
            this.ChbOrdenPregAle.Size = new System.Drawing.Size(20, 20);
            this.ChbOrdenPregAle.TabIndex = 3;
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Enabled = false;
            this.label222.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label222.ForeColor = System.Drawing.Color.White;
            this.label222.Location = new System.Drawing.Point(61, 60);
            this.label222.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(190, 25);
            this.label222.TabIndex = 19;
            this.label222.Text = "Habilitar Cronómetro";
            // 
            // ChbCronometro
            // 
            this.ChbCronometro.BackColor = System.Drawing.Color.Transparent;
            this.ChbCronometro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChbCronometro.ChechedOffColor = System.Drawing.Color.Transparent;
            this.ChbCronometro.Checked = false;
            this.ChbCronometro.CheckedOnColor = System.Drawing.Color.Transparent;
            this.ChbCronometro.ForeColor = System.Drawing.Color.White;
            this.ChbCronometro.Location = new System.Drawing.Point(27, 60);
            this.ChbCronometro.Margin = new System.Windows.Forms.Padding(5);
            this.ChbCronometro.Name = "ChbCronometro";
            this.ChbCronometro.Size = new System.Drawing.Size(20, 20);
            this.ChbCronometro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(417, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Guardar resultados";
            // 
            // ChbGuardarResultados
            // 
            this.ChbGuardarResultados.BackColor = System.Drawing.Color.Transparent;
            this.ChbGuardarResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChbGuardarResultados.ChechedOffColor = System.Drawing.Color.Transparent;
            this.ChbGuardarResultados.Checked = false;
            this.ChbGuardarResultados.CheckedOnColor = System.Drawing.Color.Transparent;
            this.ChbGuardarResultados.ForeColor = System.Drawing.Color.White;
            this.ChbGuardarResultados.Location = new System.Drawing.Point(383, 60);
            this.ChbGuardarResultados.Margin = new System.Windows.Forms.Padding(5);
            this.ChbGuardarResultados.Name = "ChbGuardarResultados";
            this.ChbGuardarResultados.Size = new System.Drawing.Size(20, 20);
            this.ChbGuardarResultados.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(417, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Habilitar Entrenamiento";
            // 
            // ChbEntrenamiento
            // 
            this.ChbEntrenamiento.BackColor = System.Drawing.Color.Transparent;
            this.ChbEntrenamiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChbEntrenamiento.ChechedOffColor = System.Drawing.Color.Transparent;
            this.ChbEntrenamiento.Checked = false;
            this.ChbEntrenamiento.CheckedOnColor = System.Drawing.Color.Transparent;
            this.ChbEntrenamiento.Enabled = false;
            this.ChbEntrenamiento.ForeColor = System.Drawing.Color.White;
            this.ChbEntrenamiento.Location = new System.Drawing.Point(383, 25);
            this.ChbEntrenamiento.Margin = new System.Windows.Forms.Padding(5);
            this.ChbEntrenamiento.Name = "ChbEntrenamiento";
            this.ChbEntrenamiento.Size = new System.Drawing.Size(20, 20);
            this.ChbEntrenamiento.TabIndex = 4;
            // 
            // PnlOptions
            // 
            this.PnlOptions.Controls.Add(this.bunifuFlatButton2);
            this.PnlOptions.Controls.Add(this.label13);
            this.PnlOptions.Controls.Add(this.label12);
            this.PnlOptions.Controls.Add(this.BtnComenzarExamen);
            this.PnlOptions.Controls.Add(this.label8);
            this.PnlOptions.Controls.Add(this.ChbOrdenPregAle);
            this.PnlOptions.Controls.Add(this.ChbGuardarResultados);
            this.PnlOptions.Controls.Add(this.label9);
            this.PnlOptions.Controls.Add(this.label11);
            this.PnlOptions.Controls.Add(this.ChbCronometro);
            this.PnlOptions.Controls.Add(this.ChbEntrenamiento);
            this.PnlOptions.Controls.Add(this.label222);
            this.PnlOptions.Location = new System.Drawing.Point(258, 357);
            this.PnlOptions.Margin = new System.Windows.Forms.Padding(4);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(713, 276);
            this.PnlOptions.TabIndex = 16;
            this.PnlOptions.Visible = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton2.ButtonText = "Personalizar Examen >>";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Enabled = false;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(225, 224);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(247, 27);
            this.bunifuFlatButton2.TabIndex = 26;
            this.bunifuFlatButton2.Text = "Personalizar Examen >>";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(61, 194);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "haga click debajo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(61, 170);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(470, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Para crear un examen con preguntas personalizadas";
            // 
            // BtnComenzarExamen
            // 
            this.BtnComenzarExamen.Activecolor = System.Drawing.Color.Yellow;
            this.BtnComenzarExamen.BackColor = System.Drawing.Color.Yellow;
            this.BtnComenzarExamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnComenzarExamen.BorderRadius = 0;
            this.BtnComenzarExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnComenzarExamen.ButtonText = "Comenzar Examen >>";
            this.BtnComenzarExamen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComenzarExamen.DisabledColor = System.Drawing.Color.Gray;
            this.BtnComenzarExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComenzarExamen.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnComenzarExamen.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnComenzarExamen.Iconimage")));
            this.BtnComenzarExamen.Iconimage_right = null;
            this.BtnComenzarExamen.Iconimage_right_Selected = null;
            this.BtnComenzarExamen.Iconimage_Selected = null;
            this.BtnComenzarExamen.IconMarginLeft = 0;
            this.BtnComenzarExamen.IconMarginRight = 0;
            this.BtnComenzarExamen.IconRightVisible = false;
            this.BtnComenzarExamen.IconRightZoom = 0D;
            this.BtnComenzarExamen.IconVisible = false;
            this.BtnComenzarExamen.IconZoom = 90D;
            this.BtnComenzarExamen.IsTab = false;
            this.BtnComenzarExamen.Location = new System.Drawing.Point(225, 112);
            this.BtnComenzarExamen.Margin = new System.Windows.Forms.Padding(5);
            this.BtnComenzarExamen.Name = "BtnComenzarExamen";
            this.BtnComenzarExamen.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnComenzarExamen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnComenzarExamen.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnComenzarExamen.selected = false;
            this.BtnComenzarExamen.Size = new System.Drawing.Size(247, 27);
            this.BtnComenzarExamen.TabIndex = 7;
            this.BtnComenzarExamen.Text = "Comenzar Examen >>";
            this.BtnComenzarExamen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComenzarExamen.Textcolor = System.Drawing.Color.Black;
            this.BtnComenzarExamen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComenzarExamen.Click += new System.EventHandler(this.BtnComenzarExamen_Click);
            // 
            // LblNumeroPregunta
            // 
            this.LblNumeroPregunta.BorderColor = System.Drawing.Color.SeaGreen;
            this.LblNumeroPregunta.Location = new System.Drawing.Point(40, 321);
            this.LblNumeroPregunta.Margin = new System.Windows.Forms.Padding(4);
            this.LblNumeroPregunta.Name = "LblNumeroPregunta";
            this.LblNumeroPregunta.Size = new System.Drawing.Size(27, 22);
            this.LblNumeroPregunta.TabIndex = 0;
            this.LblNumeroPregunta.Text = "0";
            this.LblNumeroPregunta.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 297);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ir a Prgnta:";
            // 
            // FormStartExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.PnlNames);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblNumeroPregunta);
            this.Controls.Add(this.PnlOptions);
            this.Controls.Add(this.PnlSelectedExam);
            this.Controls.Add(this.BtnShowExams);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PnlSelectExam);
            this.Controls.Add(this.LblChangeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStartExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Start Exam";
            this.Load += new System.EventHandler(this.FormStartExam_Load);
            this.VisibleChanged += new System.EventHandler(this.FormStartExam_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlSelectExam.ResumeLayout(false);
            this.PnlSelectExam.PerformLayout();
            this.PnlSelectedExam.ResumeLayout(false);
            this.PnlSelectedExam.PerformLayout();
            this.PnlNames.ResumeLayout(false);
            this.PnlNames.PerformLayout();
            this.PnlOptions.ResumeLayout(false);
            this.PnlOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblChangeType;
        private System.Windows.Forms.Panel PnlSelectExam;
        private Bunifu.Framework.UI.BunifuFlatButton BtnWord;
        private Bunifu.Framework.UI.BunifuFlatButton BtnExcel;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPowerPoint;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBack;
        private Bunifu.Framework.UI.BunifuFlatButton BtnShowExams;
        private System.Windows.Forms.Panel PnlSelectedExam;
        private System.Windows.Forms.Label LblChangeExam;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSelectedExam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlNames;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtFirstName;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCheckbox ChbOrdenPregAle;
        private System.Windows.Forms.Label label222;
        private Bunifu.Framework.UI.BunifuCheckbox ChbCronometro;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCheckbox ChbGuardarResultados;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCheckbox ChbEntrenamiento;
        private System.Windows.Forms.Panel PnlOptions;
        private Bunifu.Framework.UI.BunifuFlatButton BtnComenzarExamen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox LblNumeroPregunta;
        private System.Windows.Forms.Label label10;
    }
}