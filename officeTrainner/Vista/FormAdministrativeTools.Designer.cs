namespace Vista
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
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAbrirBD = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.label2.Location = new System.Drawing.Point(4, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "contraseña";
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
            this.PnlOptions.Controls.Add(this.bunifuFlatButton1);
            this.PnlOptions.Controls.Add(this.BtnAbrirBD);
            this.PnlOptions.Location = new System.Drawing.Point(331, 171);
            this.PnlOptions.Margin = new System.Windows.Forms.Padding(4);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(278, 338);
            this.PnlOptions.TabIndex = 33;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "Establecer Contraseña >>";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 96);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(278, 31);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Establecer Contraseña >>";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}