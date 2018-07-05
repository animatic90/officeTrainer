using Datos;
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
    public partial class FormLogin : Form
    {
        public static string usuario = "";
        public static string nivelDeusuario = "";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using (ModelContainer conexion = new ModelContainer())
            {
                var myUser = conexion.Usuarios
                    .FirstOrDefault(u => u.nombreUsuario == TxtUsuario.Text
                    && u.password == TxtPassword.Text);

                if (myUser != null)
                {
                    usuario = myUser.nombre + " " + myUser.apellidos;
                    nivelDeusuario = myUser.nivelUsuario;
                    this.Hide();

                    FormMain f = new FormMain();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error en el ingreso de datos");
                }
            }
        }
    }
}
