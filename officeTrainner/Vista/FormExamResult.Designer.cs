namespace Vista
{
    partial class FormExamResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExamResult));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlScoreExam = new System.Windows.Forms.Panel();
            this.LblAlumno = new System.Windows.Forms.Label();
            this.LblPercentage = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblCorrect = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSelectedExam = new System.Windows.Forms.Label();
            this.BtnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnImprResultados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlPrint = new System.Windows.Forms.Panel();
            this.BtnImprCertificado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtResults = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlScoreExam.SuspendLayout();
            this.PnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(230, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "MS OFFICE   - ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 237);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // PnlScoreExam
            // 
            this.PnlScoreExam.Controls.Add(this.LblAlumno);
            this.PnlScoreExam.Controls.Add(this.LblPercentage);
            this.PnlScoreExam.Controls.Add(this.LblTotal);
            this.PnlScoreExam.Controls.Add(this.LblCorrect);
            this.PnlScoreExam.Controls.Add(this.label8);
            this.PnlScoreExam.Controls.Add(this.label5);
            this.PnlScoreExam.Controls.Add(this.label3);
            this.PnlScoreExam.Controls.Add(this.label1);
            this.PnlScoreExam.Controls.Add(this.LblSelectedExam);
            this.PnlScoreExam.Location = new System.Drawing.Point(234, 121);
            this.PnlScoreExam.Margin = new System.Windows.Forms.Padding(4);
            this.PnlScoreExam.Name = "PnlScoreExam";
            this.PnlScoreExam.Size = new System.Drawing.Size(862, 139);
            this.PnlScoreExam.TabIndex = 25;
            // 
            // LblAlumno
            // 
            this.LblAlumno.AutoSize = true;
            this.LblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlumno.ForeColor = System.Drawing.Color.Silver;
            this.LblAlumno.Location = new System.Drawing.Point(230, 49);
            this.LblAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAlumno.Name = "LblAlumno";
            this.LblAlumno.Size = new System.Drawing.Size(213, 29);
            this.LblAlumno.TabIndex = 32;
            this.LblAlumno.Text = "nombres apellidos";
            // 
            // LblPercentage
            // 
            this.LblPercentage.AutoSize = true;
            this.LblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPercentage.ForeColor = System.Drawing.Color.Khaki;
            this.LblPercentage.Location = new System.Drawing.Point(761, 110);
            this.LblPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPercentage.Name = "LblPercentage";
            this.LblPercentage.Size = new System.Drawing.Size(85, 25);
            this.LblPercentage.TabIndex = 31;
            this.LblPercentage.Text = "99,99%";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Khaki;
            this.LblTotal.Location = new System.Drawing.Point(467, 109);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(36, 25);
            this.LblTotal.TabIndex = 30;
            this.LblTotal.Text = "99";
            // 
            // LblCorrect
            // 
            this.LblCorrect.AutoSize = true;
            this.LblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorrect.ForeColor = System.Drawing.Color.Khaki;
            this.LblCorrect.Location = new System.Drawing.Point(221, 111);
            this.LblCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCorrect.Name = "LblCorrect";
            this.LblCorrect.Size = new System.Drawing.Size(36, 25);
            this.LblCorrect.TabIndex = 29;
            this.LblCorrect.Text = "99";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(619, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Porcentaje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(389, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Correctas:";
            // 
            // LblSelectedExam
            // 
            this.LblSelectedExam.AutoSize = true;
            this.LblSelectedExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectedExam.ForeColor = System.Drawing.Color.Silver;
            this.LblSelectedExam.Location = new System.Drawing.Point(422, 0);
            this.LblSelectedExam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSelectedExam.Name = "LblSelectedExam";
            this.LblSelectedExam.Size = new System.Drawing.Size(248, 29);
            this.LblSelectedExam.TabIndex = 2;
            this.LblSelectedExam.Text = "examen seleccionado";
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
            this.BtnBack.Location = new System.Drawing.Point(14, 567);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBack.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBack.selected = false;
            this.BtnBack.Size = new System.Drawing.Size(140, 60);
            this.BtnBack.TabIndex = 23;
            this.BtnBack.Text = "<< VOLVER";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Textcolor = System.Drawing.Color.White;
            this.BtnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnImprResultados
            // 
            this.BtnImprResultados.Activecolor = System.Drawing.Color.Yellow;
            this.BtnImprResultados.BackColor = System.Drawing.Color.Yellow;
            this.BtnImprResultados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnImprResultados.BorderRadius = 0;
            this.BtnImprResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnImprResultados.ButtonText = "Imprimir Resultados >>";
            this.BtnImprResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprResultados.DisabledColor = System.Drawing.Color.Gray;
            this.BtnImprResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprResultados.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnImprResultados.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnImprResultados.Iconimage")));
            this.BtnImprResultados.Iconimage_right = null;
            this.BtnImprResultados.Iconimage_right_Selected = null;
            this.BtnImprResultados.Iconimage_Selected = null;
            this.BtnImprResultados.IconMarginLeft = 0;
            this.BtnImprResultados.IconMarginRight = 0;
            this.BtnImprResultados.IconRightVisible = false;
            this.BtnImprResultados.IconRightZoom = 0D;
            this.BtnImprResultados.IconVisible = false;
            this.BtnImprResultados.IconZoom = 90D;
            this.BtnImprResultados.IsTab = false;
            this.BtnImprResultados.Location = new System.Drawing.Point(23, 24);
            this.BtnImprResultados.Margin = new System.Windows.Forms.Padding(5);
            this.BtnImprResultados.Name = "BtnImprResultados";
            this.BtnImprResultados.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnImprResultados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnImprResultados.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnImprResultados.selected = false;
            this.BtnImprResultados.Size = new System.Drawing.Size(248, 32);
            this.BtnImprResultados.TabIndex = 7;
            this.BtnImprResultados.Text = "Imprimir Resultados >>";
            this.BtnImprResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprResultados.Textcolor = System.Drawing.Color.Black;
            this.BtnImprResultados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprResultados.Click += new System.EventHandler(this.BtnImprResultados_Click);
            // 
            // PnlPrint
            // 
            this.PnlPrint.Controls.Add(this.BtnImprCertificado);
            this.PnlPrint.Controls.Add(this.BtnImprResultados);
            this.PnlPrint.Location = new System.Drawing.Point(14, 350);
            this.PnlPrint.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPrint.Name = "PnlPrint";
            this.PnlPrint.Size = new System.Drawing.Size(276, 132);
            this.PnlPrint.TabIndex = 27;
            // 
            // BtnImprCertificado
            // 
            this.BtnImprCertificado.Activecolor = System.Drawing.Color.Yellow;
            this.BtnImprCertificado.BackColor = System.Drawing.Color.Yellow;
            this.BtnImprCertificado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnImprCertificado.BorderRadius = 0;
            this.BtnImprCertificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnImprCertificado.ButtonText = "Imprimir Certificado >>";
            this.BtnImprCertificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprCertificado.DisabledColor = System.Drawing.Color.Gray;
            this.BtnImprCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprCertificado.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnImprCertificado.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnImprCertificado.Iconimage")));
            this.BtnImprCertificado.Iconimage_right = null;
            this.BtnImprCertificado.Iconimage_right_Selected = null;
            this.BtnImprCertificado.Iconimage_Selected = null;
            this.BtnImprCertificado.IconMarginLeft = 0;
            this.BtnImprCertificado.IconMarginRight = 0;
            this.BtnImprCertificado.IconRightVisible = false;
            this.BtnImprCertificado.IconRightZoom = 0D;
            this.BtnImprCertificado.IconVisible = false;
            this.BtnImprCertificado.IconZoom = 90D;
            this.BtnImprCertificado.IsTab = false;
            this.BtnImprCertificado.Location = new System.Drawing.Point(23, 84);
            this.BtnImprCertificado.Margin = new System.Windows.Forms.Padding(5);
            this.BtnImprCertificado.Name = "BtnImprCertificado";
            this.BtnImprCertificado.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnImprCertificado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnImprCertificado.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnImprCertificado.selected = false;
            this.BtnImprCertificado.Size = new System.Drawing.Size(248, 32);
            this.BtnImprCertificado.TabIndex = 8;
            this.BtnImprCertificado.Text = "Imprimir Certificado >>";
            this.BtnImprCertificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprCertificado.Textcolor = System.Drawing.Color.Black;
            this.BtnImprCertificado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprCertificado.Click += new System.EventHandler(this.BtnImprCertificado_Click);
            // 
            // TxtResults
            // 
            this.TxtResults.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResults.Location = new System.Drawing.Point(331, 267);
            this.TxtResults.Multiline = true;
            this.TxtResults.Name = "TxtResults";
            this.TxtResults.ReadOnly = true;
            this.TxtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResults.Size = new System.Drawing.Size(743, 360);
            this.TxtResults.TabIndex = 28;
            this.TxtResults.WordWrap = false;
            // 
            // FormExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.TxtResults);
            this.Controls.Add(this.PnlPrint);
            this.Controls.Add(this.PnlScoreExam);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormExamResult";
            this.Text = "FormExamResult";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExamResult_FormClosing);
            this.Load += new System.EventHandler(this.FormExamResult_Load);
            this.VisibleChanged += new System.EventHandler(this.FormExamResult_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlScoreExam.ResumeLayout(false);
            this.PnlScoreExam.PerformLayout();
            this.PnlPrint.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlScoreExam;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton BtnImprResultados;
        private System.Windows.Forms.Panel PnlPrint;
        private System.Windows.Forms.TextBox TxtResults;
        private System.Windows.Forms.Label LblPercentage;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblCorrect;
        private System.Windows.Forms.Label LblSelectedExam;
        private Bunifu.Framework.UI.BunifuFlatButton BtnImprCertificado;
        private System.Windows.Forms.Label LblAlumno;
    }
}