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
            this.LblPercentage = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblCorrect = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSelectedExam = new System.Windows.Forms.Label();
            this.BtnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnImprimirResultados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlPrint = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
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
            // LblPercentage
            // 
            this.LblPercentage.AutoSize = true;
            this.LblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPercentage.ForeColor = System.Drawing.Color.Khaki;
            this.LblPercentage.Location = new System.Drawing.Point(755, 69);
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
            this.LblTotal.Location = new System.Drawing.Point(476, 68);
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
            this.LblCorrect.Location = new System.Drawing.Point(221, 70);
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
            this.label8.Location = new System.Drawing.Point(612, 65);
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
            this.label5.Location = new System.Drawing.Point(394, 65);
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
            this.label3.Location = new System.Drawing.Point(90, 66);
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
            // BtnImprimirResultados
            // 
            this.BtnImprimirResultados.Activecolor = System.Drawing.Color.Yellow;
            this.BtnImprimirResultados.BackColor = System.Drawing.Color.Yellow;
            this.BtnImprimirResultados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnImprimirResultados.BorderRadius = 0;
            this.BtnImprimirResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnImprimirResultados.ButtonText = "Imprimir Resultados >>";
            this.BtnImprimirResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimirResultados.DisabledColor = System.Drawing.Color.Gray;
            this.BtnImprimirResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirResultados.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnImprimirResultados.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnImprimirResultados.Iconimage")));
            this.BtnImprimirResultados.Iconimage_right = null;
            this.BtnImprimirResultados.Iconimage_right_Selected = null;
            this.BtnImprimirResultados.Iconimage_Selected = null;
            this.BtnImprimirResultados.IconMarginLeft = 0;
            this.BtnImprimirResultados.IconMarginRight = 0;
            this.BtnImprimirResultados.IconRightVisible = false;
            this.BtnImprimirResultados.IconRightZoom = 0D;
            this.BtnImprimirResultados.IconVisible = false;
            this.BtnImprimirResultados.IconZoom = 90D;
            this.BtnImprimirResultados.IsTab = false;
            this.BtnImprimirResultados.Location = new System.Drawing.Point(23, 24);
            this.BtnImprimirResultados.Margin = new System.Windows.Forms.Padding(5);
            this.BtnImprimirResultados.Name = "BtnImprimirResultados";
            this.BtnImprimirResultados.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnImprimirResultados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnImprimirResultados.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnImprimirResultados.selected = false;
            this.BtnImprimirResultados.Size = new System.Drawing.Size(248, 32);
            this.BtnImprimirResultados.TabIndex = 7;
            this.BtnImprimirResultados.Text = "Imprimir Resultados >>";
            this.BtnImprimirResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimirResultados.Textcolor = System.Drawing.Color.Black;
            this.BtnImprimirResultados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PnlPrint
            // 
            this.PnlPrint.Controls.Add(this.bunifuFlatButton1);
            this.PnlPrint.Controls.Add(this.BtnImprimirResultados);
            this.PnlPrint.Location = new System.Drawing.Point(14, 350);
            this.PnlPrint.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPrint.Name = "PnlPrint";
            this.PnlPrint.Size = new System.Drawing.Size(276, 132);
            this.PnlPrint.TabIndex = 27;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "Imprimir Certificado >>";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(23, 84);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(248, 32);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Imprimir Certificado >>";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtResults
            // 
            this.TxtResults.Location = new System.Drawing.Point(331, 236);
            this.TxtResults.Multiline = true;
            this.TxtResults.Name = "TxtResults";
            this.TxtResults.Size = new System.Drawing.Size(743, 391);
            this.TxtResults.TabIndex = 28;
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
            this.Name = "FormExamResult";
            this.Text = "FormExamResult";
            this.Load += new System.EventHandler(this.FormExamResult_Load);
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
        private Bunifu.Framework.UI.BunifuFlatButton BtnImprimirResultados;
        private System.Windows.Forms.Panel PnlPrint;
        private System.Windows.Forms.TextBox TxtResults;
        private System.Windows.Forms.Label LblPercentage;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblCorrect;
        private System.Windows.Forms.Label LblSelectedExam;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}