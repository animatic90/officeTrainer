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
            this.PnlOptions = new System.Windows.Forms.Panel();
            this.BtnAcept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RbFinishQuestions = new System.Windows.Forms.RadioButton();
            this.RbContineLatter = new System.Windows.Forms.RadioButton();
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
            this.LblQuestions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTitleOfQuestion = new System.Windows.Forms.Label();
            this.LblNumberOfQuestion = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.PnlOptions.SuspendLayout();
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
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1579, 194);
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
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 186);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.PnlOptions);
            this.panel7.Controls.Add(this.TxtQuestion);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(115, 32);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(778, 100);
            this.panel7.TabIndex = 5;
            // 
            // PnlOptions
            // 
            this.PnlOptions.Controls.Add(this.BtnAcept);
            this.PnlOptions.Controls.Add(this.RbFinishQuestions);
            this.PnlOptions.Controls.Add(this.RbContineLatter);
            this.PnlOptions.Location = new System.Drawing.Point(7, 7);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(764, 86);
            this.PnlOptions.TabIndex = 0;
            this.PnlOptions.Visible = false;
            // 
            // BtnAcept
            // 
            this.BtnAcept.Activecolor = System.Drawing.Color.Yellow;
            this.BtnAcept.BackColor = System.Drawing.Color.Yellow;
            this.BtnAcept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAcept.BorderRadius = 0;
            this.BtnAcept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnAcept.ButtonText = "Aceptar";
            this.BtnAcept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcept.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcept.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAcept.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAcept.Iconimage")));
            this.BtnAcept.Iconimage_right = null;
            this.BtnAcept.Iconimage_right_Selected = null;
            this.BtnAcept.Iconimage_Selected = null;
            this.BtnAcept.IconMarginLeft = 0;
            this.BtnAcept.IconMarginRight = 0;
            this.BtnAcept.IconRightVisible = false;
            this.BtnAcept.IconRightZoom = 0D;
            this.BtnAcept.IconVisible = false;
            this.BtnAcept.IconZoom = 90D;
            this.BtnAcept.IsTab = false;
            this.BtnAcept.Location = new System.Drawing.Point(630, 54);
            this.BtnAcept.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAcept.Name = "BtnAcept";
            this.BtnAcept.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnAcept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAcept.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAcept.selected = false;
            this.BtnAcept.Size = new System.Drawing.Size(86, 27);
            this.BtnAcept.TabIndex = 8;
            this.BtnAcept.Text = "Aceptar";
            this.BtnAcept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcept.Textcolor = System.Drawing.Color.Black;
            this.BtnAcept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcept.Click += new System.EventHandler(this.BtnAcept_Click);
            // 
            // RbFinishQuestions
            // 
            this.RbFinishQuestions.AutoSize = true;
            this.RbFinishQuestions.ForeColor = System.Drawing.SystemColors.Control;
            this.RbFinishQuestions.Location = new System.Drawing.Point(271, 21);
            this.RbFinishQuestions.Name = "RbFinishQuestions";
            this.RbFinishQuestions.Size = new System.Drawing.Size(449, 21);
            this.RbFinishQuestions.TabIndex = 1;
            this.RbFinishQuestions.Text = "Ir directamente a resultados sin responder las preguntas restantes";
            this.RbFinishQuestions.UseVisualStyleBackColor = true;
            // 
            // RbContineLatter
            // 
            this.RbContineLatter.AutoSize = true;
            this.RbContineLatter.Checked = true;
            this.RbContineLatter.ForeColor = System.Drawing.SystemColors.Control;
            this.RbContineLatter.Location = new System.Drawing.Point(41, 21);
            this.RbContineLatter.Name = "RbContineLatter";
            this.RbContineLatter.Size = new System.Drawing.Size(150, 21);
            this.RbContineLatter.TabIndex = 0;
            this.RbContineLatter.TabStop = true;
            this.RbContineLatter.Text = "Continuar Despues";
            this.RbContineLatter.UseVisualStyleBackColor = true;
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestion.Location = new System.Drawing.Point(0, 0);
            this.TxtQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtQuestion.Multiline = true;
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.ReadOnly = true;
            this.TxtQuestion.ShortcutsEnabled = false;
            this.TxtQuestion.Size = new System.Drawing.Size(778, 100);
            this.TxtQuestion.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(893, 32);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 100);
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
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(204, 100);
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
            this.BtnOptions.Location = new System.Drawing.Point(25, 71);
            this.BtnOptions.Margin = new System.Windows.Forms.Padding(5);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnOptions.OnHovercolor = System.Drawing.Color.DimGray;
            this.BtnOptions.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnOptions.selected = false;
            this.BtnOptions.Size = new System.Drawing.Size(153, 24);
            this.BtnOptions.TabIndex = 2;
            this.BtnOptions.Text = "Opciones";
            this.BtnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOptions.Textcolor = System.Drawing.Color.White;
            this.BtnOptions.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
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
            this.BtnReset.Location = new System.Drawing.Point(25, 38);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Normalcolor = System.Drawing.Color.Yellow;
            this.BtnReset.OnHovercolor = System.Drawing.Color.DimGray;
            this.BtnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnReset.selected = false;
            this.BtnReset.Size = new System.Drawing.Size(153, 23);
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
            this.BtNext.Location = new System.Drawing.Point(25, 5);
            this.BtNext.Margin = new System.Windows.Forms.Padding(5);
            this.BtNext.Name = "BtNext";
            this.BtNext.Normalcolor = System.Drawing.Color.Yellow;
            this.BtNext.OnHovercolor = System.Drawing.Color.DimGray;
            this.BtNext.OnHoverTextColor = System.Drawing.Color.White;
            this.BtNext.selected = false;
            this.BtNext.Size = new System.Drawing.Size(153, 23);
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
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 100);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(151, -123);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 66);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1097, 54);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.LblQuestions);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LblTitleOfQuestion);
            this.panel2.Controls.Add(this.LblNumberOfQuestion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 32);
            this.panel2.TabIndex = 0;
            // 
            // LblQuestions
            // 
            this.LblQuestions.AutoSize = true;
            this.LblQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestions.ForeColor = System.Drawing.Color.White;
            this.LblQuestions.Location = new System.Drawing.Point(139, 6);
            this.LblQuestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblQuestions.Name = "LblQuestions";
            this.LblQuestions.Size = new System.Drawing.Size(27, 20);
            this.LblQuestions.TabIndex = 6;
            this.LblQuestions.Text = "99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pregunta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(247, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(832, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DDC Testing Center";
            // 
            // LblTitleOfQuestion
            // 
            this.LblTitleOfQuestion.AutoSize = true;
            this.LblTitleOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleOfQuestion.ForeColor = System.Drawing.Color.White;
            this.LblTitleOfQuestion.Location = new System.Drawing.Point(293, 7);
            this.LblTitleOfQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitleOfQuestion.Name = "LblTitleOfQuestion";
            this.LblTitleOfQuestion.Size = new System.Drawing.Size(143, 20);
            this.LblTitleOfQuestion.TabIndex = 1;
            this.LblTitleOfQuestion.Text = "Título de pregunta";
            // 
            // LblNumberOfQuestion
            // 
            this.LblNumberOfQuestion.AutoSize = true;
            this.LblNumberOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfQuestion.ForeColor = System.Drawing.Color.White;
            this.LblNumberOfQuestion.Location = new System.Drawing.Point(90, 7);
            this.LblNumberOfQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumberOfQuestion.Name = "LblNumberOfQuestion";
            this.LblNumberOfQuestion.Size = new System.Drawing.Size(27, 20);
            this.LblNumberOfQuestion.TabIndex = 0;
            this.LblNumberOfQuestion.Text = "00";
            // 
            // FormQuestionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 194);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuestionsPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuestionsPanel";
            this.Load += new System.EventHandler(this.FormQuestionsPanel_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.PnlOptions.ResumeLayout(false);
            this.PnlOptions.PerformLayout();
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
        private System.Windows.Forms.Label LblQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlOptions;
        private System.Windows.Forms.RadioButton RbFinishQuestions;
        private System.Windows.Forms.RadioButton RbContineLatter;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAcept;
    }
}