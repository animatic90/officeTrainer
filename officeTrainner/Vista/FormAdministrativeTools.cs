using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAdministrativeTools : Form
    {
        public static  FormDataBase formDataBase = new FormDataBase();

        public FormAdministrativeTools()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
            FormMain.formMain.Left = this.Left;
            FormMain.formMain.Top = this.Top;
            FormMain.formAdministrativeTools.Hide();
            FormMain.formMain.Show();
        }

        private void BtnAbrirBD_Click(object sender, EventArgs e)
        {
            formDataBase.Left = this.Left;
            formDataBase.Top = this.Top;
            formDataBase.Show();
            this.Hide();
        }
    }
}
