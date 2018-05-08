namespace Vista
{   
        partial class FormQuestionsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestionsPanel));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOptions = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTitleOfQuestion = new System.Windows.Forms.Label();
            this.LblNumberOfQuestion = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1184, 158);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 152);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TxtQuestion);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(86, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(583, 82);
            this.panel7.TabIndex = 5;
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestion.Location = new System.Drawing.Point(0, 0);
            this.TxtQuestion.Multiline = true;
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(583, 82);
            this.TxtQuestion.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(669, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 82);
            this.panel6.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.BtnOptions, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnReset, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtNext, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(153, 82);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnOptions
            // 
            this.BtnOptions.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.BtnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOptions.BorderRadius = 0;
            this.BtnOptions.ButtonText = "Opciones";
            this.BtnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOptions.DisabledColor = System.Drawing.Color.Gray;
            this.BtnOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOptions.ForeColor = System.Drawing.Color.Black;
            this.BtnOptions.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnOptions.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnOptions.Iconimage")));
            this.BtnOptions.Iconimage_right = null;
            this.BtnOptions.Iconimage_right_Selected = null;
            this.BtnOptions.Iconimage_Selected = null;
            this.BtnOptions.IconMarginLeft = 0;
            this.BtnOptions.IconMarginRight = 0;
            this.BtnOptions.IconRightVisible = true;
            this.BtnOptions.IconRightZoom = 0D;
            this.BtnOptions.IconVisible = false;
            this.BtnOptions.IconZoom = 90D;
            this.BtnOptions.IsTab = false;
            this.BtnOptions.Location = new System.Drawing.Point(18, 57);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnOptions.OnHovercolor = System.Drawing.Color.DimGray;
            this.BtnOptions.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnOptions.selected = false;
            this.BtnOptions.Size = new System.Drawing.Size(116, 22);
            this.BtnOptions.TabIndex = 2;
            this.BtnOptions.Text = "Opciones";
            this.BtnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOptions.Textcolor = System.Drawing.Color.White;
            this.BtnOptions.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnReset
            // 
            this.BtnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.BtnReset.BackColor = System.Drawing.Color.Yellow;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReset.BorderRadius = 0;
            this.BtnReset.ButtonText = "Reiniciar";
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.DisabledColor = System.Drawing.Color.Gray;
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReset.ForeColor = System.Drawing.Color.Black;
            this.BtnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnReset.Iconimage")));
            this.BtnReset.Iconimage_right = null;
            this.BtnReset.Iconimage_right_Selected = null;
            this.BtnReset.Iconimage_Selected = null;
            this.BtnReset.IconMarginLeft = 0;
            this.BtnReset.IconMarginRight = 0;
            this.BtnReset.IconRightVisible = true;
            this.BtnReset.IconRightZoom = 0D;
            this.BtnReset.IconVisible = false;
            this.BtnReset.IconZoom = 90D;
            this.BtnReset.IsTab = false;
            this.BtnReset.Location = new System.Drawing.Point(18, 30);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnReset.OnHovercolor = System.Drawing.Color.DimGray;
            this.BtnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnReset.selected = false;
            this.BtnReset.Size = new System.Drawing.Size(116, 21);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reiniciar";
            this.BtnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReset.Textcolor = System.Drawing.Color.Black;
            this.BtnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtNext
            // 
            this.BtNext.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.BtNext.BackColor = System.Drawing.Color.Yellow;
            this.BtNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtNext.BorderRadius = 0;
            this.BtNext.ButtonText = "Siguiente";
            this.BtNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtNext.DisabledColor = System.Drawing.Color.Gray;
            this.BtNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtNext.ForeColor = System.Drawing.Color.Black;
            this.BtNext.Iconcolor = System.Drawing.Color.Transparent;
            this.BtNext.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtNext.Iconimage")));
            this.BtNext.Iconimage_right = null;
            this.BtNext.Iconimage_right_Selected = null;
            this.BtNext.Iconimage_Selected = null;
            this.BtNext.IconMarginLeft = 0;
            this.BtNext.IconMarginRight = 0;
            this.BtNext.IconRightVisible = true;
            this.BtNext.IconRightZoom = 0D;
            this.BtNext.IconVisible = false;
            this.BtNext.IconZoom = 90D;
            this.BtNext.IsTab = false;
            this.BtNext.Location = new System.Drawing.Point(18, 3);
            this.BtNext.Name = "BtNext";
            this.BtNext.Normalcolor = System.Drawing.Color.Yellow;
            this.BtNext.OnHovercolor = System.Drawing.Color.DimGray;
            this.BtNext.OnHoverTextColor = System.Drawing.Color.White;
            this.BtNext.selected = false;
            this.BtNext.Size = new System.Drawing.Size(116, 21);
            this.BtNext.TabIndex = 0;
            this.BtNext.Text = "Siguiente";
            this.BtNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtNext.Textcolor = System.Drawing.Color.Black;
            this.BtNext.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(86, 82);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(113, -100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 54);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 44);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LblTitleOfQuestion);
            this.panel2.Controls.Add(this.LblNumberOfQuestion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 26);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(185, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(624, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DDC Testing Center";
            // 
            // LblTitleOfQuestion
            // 
            this.LblTitleOfQuestion.AutoSize = true;
            this.LblTitleOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleOfQuestion.ForeColor = System.Drawing.Color.White;
            this.LblTitleOfQuestion.Location = new System.Drawing.Point(220, 6);
            this.LblTitleOfQuestion.Name = "LblTitleOfQuestion";
            this.LblTitleOfQuestion.Size = new System.Drawing.Size(116, 16);
            this.LblTitleOfQuestion.TabIndex = 1;
            this.LblTitleOfQuestion.Text = "Título de pregunta";
            // 
            // LblNumberOfQuestion
            // 
            this.LblNumberOfQuestion.AutoSize = true;
            this.LblNumberOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfQuestion.ForeColor = System.Drawing.Color.White;
            this.LblNumberOfQuestion.Location = new System.Drawing.Point(57, 6);
            this.LblNumberOfQuestion.Name = "LblNumberOfQuestion";
            this.LblNumberOfQuestion.Size = new System.Drawing.Size(101, 16);
            this.LblNumberOfQuestion.TabIndex = 0;
            this.LblNumberOfQuestion.Text = "Pregunta 0 de 0";
            // 
            // FormQuestionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 158);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuestionsPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuestionsPanel";
            this.Load += new System.EventHandler(this.FormQuestionsPanel_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtQuestion;
        private Bunifu.Framework.UI.BunifuFlatButton BtNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnOptions;
        private Bunifu.Framework.UI.BunifuFlatButton BtnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTitleOfQuestion;
        private System.Windows.Forms.Label LblNumberOfQuestion;
        private System.Windows.Forms.Label label4;


    }
}