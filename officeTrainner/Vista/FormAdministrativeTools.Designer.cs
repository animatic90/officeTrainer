﻿namespace Vista
{
    partial class FormAdministrativeTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrativeTools));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlSelectExam = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlOptions = new System.Windows.Forms.Panel();
            this.BtnGestionarUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAbrirBD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConfigurarParametros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlSelectExam.SuspendLayout();
            this.PnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 164);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            this.BtnBack.Location = new System.Drawing.Point(26, 551);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBack.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBack.selected = false;
            this.BtnBack.Size = new System.Drawing.Size(140, 60);
            this.BtnBack.TabIndex = 31;
            this.BtnBack.Text = "<< VOLVER";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Textcolor = System.Drawing.Color.White;
            this.BtnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PnlSelectExam
            // 
            this.PnlSelectExam.Controls.Add(this.label3);
            this.PnlSelectExam.Controls.Add(this.label2);
            this.PnlSelectExam.Controls.Add(this.label1);
            this.PnlSelectExam.Location = new System.Drawing.Point(631, 182);
            this.PnlSelectExam.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSelectExam.Name = "PnlSelectExam";
            this.PnlSelectExam.Size = new System.Drawing.Size(290, 327);
            this.PnlSelectExam.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(4, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crea / Modifica / Elimina\r\nUsuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abre los resultados de\r\ntodos los examenes";
            // 
            // PnlOptions
            // 
            this.PnlOptions.Controls.Add(this.BtnConfigurarParametros);
            this.PnlOptions.Controls.Add(this.BtnGestionarUsuarios);
            this.PnlOptions.Controls.Add(this.BtnAbrirBD);
            this.PnlOptions.Location = new System.Drawing.Point(331, 171);
            this.PnlOptions.Margin = new System.Windows.Forms.Padding(4);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(278, 338);
            this.PnlOptions.TabIndex = 33;
            // 
            // BtnGestionarUsuarios
            // 
            this.BtnGestionarUsuarios.Activecolor = System.Drawing.Color.Yellow;
            this.BtnGestionarUsuarios.BackColor = System.Drawing.Color.Yellow;
            this.BtnGestionarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGestionarUsuarios.BorderRadius = 0;
            this.BtnGestionarUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnGestionarUsuarios.ButtonText = "Gestionar Usuarios >>";
            this.BtnGestionarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGestionarUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGestionarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionarUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGestionarUsuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGestionarUsuarios.Iconimage")));
            this.BtnGestionarUsuarios.Iconimage_right = null;
            this.BtnGestionarUsuarios.Iconimage_right_Selected = null;
            this.BtnGestionarUsuarios.Iconimage_Selected = null;
            this.BtnGestionarUsuarios.IconMarginLeft = 0;
            this.BtnGestionarUsuarios.IconMarginRight = 0;
            this.BtnGestionarUsuarios.IconRightVisible = false;
            this.BtnGestionarUsuarios.IconRightZoom = 0D;
            this.BtnGestionarUsuarios.IconVisible = false;
            this.BtnGestionarUsuarios.IconZoom = 90D;
            this.BtnGestionarUsuarios.IsTab = false;
            this.BtnGestionarUsuarios.Location = new System.Drawing.Point(0, 123);
            this.BtnGestionarUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGestionarUsuarios.Name = "BtnGestionarUsuarios";
            this.BtnGestionarUsuarios.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnGestionarUsuarios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnGestionarUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGestionarUsuarios.selected = false;
            this.BtnGestionarUsuarios.Size = new System.Drawing.Size(278, 31);
            this.BtnGestionarUsuarios.TabIndex = 8;
            this.BtnGestionarUsuarios.Text = "Gestionar Usuarios >>";
            this.BtnGestionarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestionarUsuarios.Textcolor = System.Drawing.Color.Black;
            this.BtnGestionarUsuarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionarUsuarios.Click += new System.EventHandler(this.BtnGestionarUsuarios_Click);
            // 
            // BtnAbrirBD
            // 
            this.BtnAbrirBD.Activecolor = System.Drawing.Color.Yellow;
            this.BtnAbrirBD.BackColor = System.Drawing.Color.Yellow;
            this.BtnAbrirBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAbrirBD.BorderRadius = 0;
            this.BtnAbrirBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnAbrirBD.ButtonText = "Abrir Base de Datos >>";
            this.BtnAbrirBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrirBD.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAbrirBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirBD.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAbrirBD.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAbrirBD.Iconimage")));
            this.BtnAbrirBD.Iconimage_right = null;
            this.BtnAbrirBD.Iconimage_right_Selected = null;
            this.BtnAbrirBD.Iconimage_Selected = null;
            this.BtnAbrirBD.IconMarginLeft = 0;
            this.BtnAbrirBD.IconMarginRight = 0;
            this.BtnAbrirBD.IconRightVisible = false;
            this.BtnAbrirBD.IconRightZoom = 0D;
            this.BtnAbrirBD.IconVisible = false;
            this.BtnAbrirBD.IconZoom = 90D;
            this.BtnAbrirBD.IsTab = false;
            this.BtnAbrirBD.Location = new System.Drawing.Point(0, 25);
            this.BtnAbrirBD.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAbrirBD.Name = "BtnAbrirBD";
            this.BtnAbrirBD.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnAbrirBD.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAbrirBD.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAbrirBD.selected = false;
            this.BtnAbrirBD.Size = new System.Drawing.Size(278, 31);
            this.BtnAbrirBD.TabIndex = 7;
            this.BtnAbrirBD.Text = "Abrir Base de Datos >>";
            this.BtnAbrirBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrirBD.Textcolor = System.Drawing.Color.Black;
            this.BtnAbrirBD.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirBD.Click += new System.EventHandler(this.BtnAbrirBD_Click);
            // 
            // BtnConfigurarParametros
            // 
            this.BtnConfigurarParametros.Activecolor = System.Drawing.Color.Yellow;
            this.BtnConfigurarParametros.BackColor = System.Drawing.Color.Yellow;
            this.BtnConfigurarParametros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfigurarParametros.BorderRadius = 0;
            this.BtnConfigurarParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnConfigurarParametros.ButtonText = "Configurar Parametros >>";
            this.BtnConfigurarParametros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfigurarParametros.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConfigurarParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfigurarParametros.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConfigurarParametros.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConfigurarParametros.Iconimage")));
            this.BtnConfigurarParametros.Iconimage_right = null;
            this.BtnConfigurarParametros.Iconimage_right_Selected = null;
            this.BtnConfigurarParametros.Iconimage_Selected = null;
            this.BtnConfigurarParametros.IconMarginLeft = 0;
            this.BtnConfigurarParametros.IconMarginRight = 0;
            this.BtnConfigurarParametros.IconRightVisible = false;
            this.BtnConfigurarParametros.IconRightZoom = 0D;
            this.BtnConfigurarParametros.IconVisible = false;
            this.BtnConfigurarParametros.IconZoom = 90D;
            this.BtnConfigurarParametros.IsTab = false;
            this.BtnConfigurarParametros.Location = new System.Drawing.Point(0, 228);
            this.BtnConfigurarParametros.Margin = new System.Windows.Forms.Padding(5);
            this.BtnConfigurarParametros.Name = "BtnConfigurarParametros";
            this.BtnConfigurarParametros.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnConfigurarParametros.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnConfigurarParametros.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnConfigurarParametros.selected = false;
            this.BtnConfigurarParametros.Size = new System.Drawing.Size(278, 31);
            this.BtnConfigurarParametros.TabIndex = 9;
            this.BtnConfigurarParametros.Text = "Configurar Parametros >>";
            this.BtnConfigurarParametros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfigurarParametros.Textcolor = System.Drawing.Color.Black;
            this.BtnConfigurarParametros.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(4, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Establece parametros\r\nde conexión";
            // 
            // FormAdministrativeTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PnlSelectExam);
            this.Controls.Add(this.PnlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdministrativeTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Herramientas Administrativas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlSelectExam.ResumeLayout(false);
            this.PnlSelectExam.PerformLayout();
            this.PnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBack;
        private System.Windows.Forms.Panel PnlSelectExam;
        private System.Windows.Forms.Panel PnlOptions;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAbrirBD;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGestionarUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConfigurarParametros;
    }
}