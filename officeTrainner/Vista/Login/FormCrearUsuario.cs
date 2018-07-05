using Datos;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos.Helpers;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace Vista.Login
{
    public partial class FormCrearUsuario : Form
    {
        #region Atributes
        string idusuario = "";
        string nombreusuario = "";        

        string uriGET = "http://localhost:8080/" + "slim/public/index.php/api/usuarios";
        //string uriGET_GetByID = "http://localhost:8080/" + "slim/public/index.php/api/usuarios/";
        string uriGET_GetByUserName = "http://localhost:8080/" + "slim/public/index.php/api/usuarios/usuario/";
        string uriPOST = "http://localhost:8080/" + "slim/public/index.php/api/usuarios/agregar";
        string uriPUT = "http://localhost:8080/" + "slim/public/index.php/api/usuarios/actualizar/";
        string uriDELETE = "http://localhost:8080/" + "slim/public/index.php/api/usuarios/borrar/";

        #endregion

        #region Events
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {
            MostrarListaUsuarios();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnEditar.Enabled = false;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (CampoValidos())
            {
                Usuario usuario = new Usuario();
                usuario.nombre = this.txtNombre.Text;
                usuario.apellidos = this.txtApellidos.Text;
                usuario.nombreUsuario = this.txtUsuario.Text;
                usuario.password = this.txtPassword.Text;
                usuario.nivelUsuario = cmbNivelUsuario.Text;

                if (!BuscarUsuarioDuplicado())
                {
                    if(RbtLoginLocal.Checked == true)
                    {
                        using (ModelContainer conexion = new ModelContainer())
                        {
                            try
                            {
                                conexion.Usuarios.Add(usuario);
                                conexion.SaveChanges();
                                MostrarListaUsuarios();
                                ReiniciarBotonesYCajas(); //reiniciamos solo en el caso de que se haya guardado correctamente
                                MessageBox.Show("Usuario registrado correctamente");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocurrió un error al registrar usuario. Vuelva a intentarlo.");
                            }
                        }
                    }
                    else if (RbtLoginWebService.Checked == true)
                    {
                        try
                        {
                            string data = new JavaScriptSerializer().Serialize(new
                            {
                                nombre = usuario.nombre,
                                apellidos = usuario.apellidos,
                                nombreUsuario = usuario.nombreUsuario,
                                password = usuario.password,
                                nivelUsuario = usuario.nivelUsuario
                            });

                            var strResponse = ApiRest(uriPOST, "POST", data);
                            if (strResponse != "ERROR")
                            {
                                MessageBox.Show("Usuario registrado correctamente");
                            }
                            else
                                MessageBox.Show("Ocurrió un error al registrar usuario. Vuelva a intentarlo.");
                            MostrarListaUsuarios();
                            ReiniciarBotonesYCajas();                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocurrió un error al registrar usuario. Vuelva a intentarlo.");
                        }
                    }
                }
                else
                    MessageBox.Show("Este usuario ya está registrado. Ingrese un usuario deferente.");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar este usuario?",
                "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if(RbtLoginLocal.Checked == true)
                { 
                    using (ModelContainer conexion = new ModelContainer())
                    {
                        if (string.IsNullOrEmpty(this.idusuario))
                        {
                            MessageBox.Show("No se pudo eliminar el usuario.");
                        }
                        else
                        {
                            var id = Convert.ToInt32(this.idusuario);
                            var usuario = conexion.Usuarios
                            .Where(p => p.IdUsuario == id).
                            FirstOrDefault();
                            if (usuario == null)
                            {
                                MessageBox.Show("No se pudo eliminar el usuario. Vuelva a intentarlo.");
                            }
                            else
                            {
                                conexion.Usuarios.Remove(usuario);
                                conexion.SaveChanges();
                                MostrarListaUsuarios();
                                MessageBox.Show("Usuario eliminado correctamente");
                            }
                        }
                        ReiniciarBotonesYCajas();
                    }
                }
                else if(RbtLoginWebService.Checked == true)
                {
                     try
                    {
                        var strResponse = ApiRest(uriDELETE + this.idusuario, "DELETE", "");
                        if (strResponse != "ERROR")
                        {
                            MessageBox.Show("Usuario eliminado correctamente");
                        }
                        else
                            MessageBox.Show("No se pudo eliminar el usuario. Vuelva a intentarlo.");
                        MostrarListaUsuarios();
                        ReiniciarBotonesYCajas();                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo eliminar el usuario. Vuelva a intentarlo.");
                    }
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Pasar datos del datagrid a las cajas de texto
            idusuario = dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidos.Text = dgvUsuarios.CurrentRow.Cells["apellidos"].Value.ToString();
            nombreusuario = txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["nombreUsuario"].Value.ToString();
            txtPassword.Text = dgvUsuarios.CurrentRow.Cells["password"].Value.ToString();
            cmbNivelUsuario.Text = dgvUsuarios.CurrentRow.Cells["nivelUsuario"].Value.ToString();

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnEditar.Enabled = false;
            btnCrear.Enabled = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool modificaNoModifica = false; //false = no modifica
            if (nombreusuario == txtUsuario.Text)
            {
                modificaNoModifica = true;
            }
            else
            {
                modificaNoModifica = !BuscarUsuarioDuplicado();
                if (!modificaNoModifica)
                {
                    MessageBox.Show("Este usuario ya está registrado. Ingrese un usuario deferente.");
                }
            }

            if (modificaNoModifica) //con esto aseguro que verifique sólo si modificó el usuario
            {
                if (MessageBox.Show("¿Seguro que deseas modificar este usuario?",
                    "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    if (CampoValidos())
                    {                        
                        Usuario usuario = new Usuario();
                        usuario.IdUsuario = Convert.ToInt32(this.idusuario);
                        usuario.nombre = this.txtNombre.Text;
                        usuario.apellidos = this.txtApellidos.Text;
                        usuario.nombreUsuario = this.txtUsuario.Text;
                        usuario.password = this.txtPassword.Text;
                        usuario.nivelUsuario = cmbNivelUsuario.Text;

                        if (RbtLoginLocal.Checked == true)
                        {                       
                            using (ModelContainer conexion = new ModelContainer())
                            {
                                    try
                                    {
                                        conexion.SaveChanges();
                                        MostrarListaUsuarios();
                                        ReiniciarBotonesYCajas();
                                        MessageBox.Show("Usuario modificado con éxito.");
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Ocurrió un error al modificar usuario. Vuelva a intentarlo.");
                                    }                                
                            }//final de Local Update
                        }
                        else if(RbtLoginWebService.Checked == true)
                        {
                            try
                            {
                                string data = new JavaScriptSerializer().Serialize(new
                                {
                                    nombre = usuario.nombre,
                                    apellidos = usuario.apellidos,
                                    nombreUsuario = usuario.nombreUsuario,
                                    password = usuario.password,
                                    nivelUsuario = usuario.nivelUsuario
                                });

                                var strResponse = ApiRest(uriPUT+ usuario.IdUsuario, "PUT", data);
                                if (strResponse != "ERROR")
                                {
                                    MessageBox.Show("Usuario modificado con éxito.");
                                }
                                else
                                    MessageBox.Show("Ocurrió un error al modificar usuario. Vuelva a intentarlo.");
                                MostrarListaUsuarios();
                                ReiniciarBotonesYCajas();
                                
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocurrió un error al modificar usuario. Vuelva a intentarlo.");
                            }
                        }
                    }    
                }
            }
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarListaUsuarios();
            FiltrarEstudiantes();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString()))
            {
                btnEditar.Enabled = true;
                btnCrear.Enabled = false;
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReiniciarBotonesYCajas();
        }
        private void RbtLoginLocal_CheckedChanged(object sender, EventArgs e)
        {
            ReiniciarBotonesYCajas();
            MostrarListaUsuarios();
        }
        private void RbtLoginWebService_CheckedChanged(object sender, EventArgs e)
        {
            ReiniciarBotonesYCajas();
            MostrarListaUsuarios();
        }
        #endregion

        #region Methods

        private void MostrarListaUsuarios()
        {
            if(RbtLoginLocal.Checked==true)
            using (ModelContainer conexion = new ModelContainer())
            {
                this.dgvUsuarios.DataSource = conexion.Usuarios.ToList();
            }
            else if(RbtLoginWebService.Checked == true)
            {
                ApiRest(uriGET, "GET", "");
            }
        }
        private bool BuscarUsuarioDuplicado()
        {
            bool exists = true;
            //En este punto, tenemos la seguridad de que hay escrito un usuario en el textbox
            if(RbtLoginLocal.Checked==true)
            {
                using (ModelContainer conexion = new ModelContainer())
                {
                    var user = conexion.Usuarios
                        .Where(p => p.nombreUsuario == txtUsuario.Text).
                        FirstOrDefault();
                    if (user == null)                    
                        exists = false;//no existe un usuario igual                                                          
                    else
                        exists = true;
                }
            }
            else if(RbtLoginWebService.Checked == true)
            {
                var user = ApiRest_GetByUserName(uriGET_GetByUserName + txtUsuario.Text);
                if (user == "true")
                    exists = true;
                else if(user == "false")
                    exists = false;
            }
            return exists;
        }
        private bool CampoValidos()
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Ingrese Nombre");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtApellidos.Text))
            {
                MessageBox.Show("Ingrese Apellidos");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Ingrese Usuario");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Ingrese Contraseña");
                return false;
            }
            if (string.IsNullOrEmpty(this.cmbNivelUsuario.Text))
            {
                MessageBox.Show("Ingrese Nivel del Usuario");
                return false;
            }
            return true;
        }
        private void FiltrarEstudiantes()
        {
            if (!string.IsNullOrEmpty(txtBusqueda.Text) &&
                (cmbBusqueda.Text == "nombre" ||
                cmbBusqueda.Text == "apellidos" ||
                cmbBusqueda.Text == "usuario"))
            {
                var cmbBusquedaSelected = cmbBusqueda.Text;
                if (cmbBusquedaSelected == "usuario")
                    cmbBusquedaSelected = "nombreUsuario";
                MostrarListaUsuarios();
                DataTable dt = new DataTable();
                dt.Columns.Add("IdUsuario");
                dt.Columns.Add("nombre");
                dt.Columns.Add("apellidos");
                dt.Columns.Add("nombreUsuario");
                dt.Columns.Add("password");
                dt.Columns.Add("nivelUsuario");

                foreach (DataGridViewRow row in dgvUsuarios.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["IdUsuario"] = row.Cells[0].Value;
                    dr["nombre"] = row.Cells[1].Value;
                    dr["apellidos"] = row.Cells[2].Value;
                    dr["nombreUsuario"] = row.Cells[3].Value;
                    dr["password"] = row.Cells[4].Value;
                    dr["nivelUsuario"] = row.Cells[5].Value;
                    dt.Rows.Add(dr);
                }

                StringBuilder filter = new StringBuilder();
                if (!(string.IsNullOrEmpty(txtBusqueda.Text)))
                    filter.Append(cmbBusquedaSelected + " Like '%" + txtBusqueda.Text + "%'");

                dt.DefaultView.RowFilter = filter.ToString();
                dgvUsuarios.DataSource = dt;
            }
            else
                MostrarListaUsuarios();
        }
        private void ReiniciarBotonesYCajas()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnEditar.Enabled = false;
            btnCrear.Enabled = true;

            this.txtNombre.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.cmbNivelUsuario.Text = "Usuario normal";
            idusuario = "";
        }
        private string ApiRest(string url, string method, string data) //en Data van datos para POST y PUT 
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = url;

            switch (method)
            {
                case "POST":
                    rClient.httpMethod = httpVerb.POST;
                    rClient.postJSON = data;
                    break;
                case "PUT":
                    rClient.httpMethod = httpVerb.PUT;
                    rClient.postJSON = data;
                    break;
                case "GET":
                    rClient.httpMethod = httpVerb.GET;
                    break;
                case "DELETE":
                    rClient.httpMethod = httpVerb.DELETE;
                    break;
            }
            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();
            if (strResponse != "ERROR")
            {
                if (rClient.httpMethod == httpVerb.GET)
                {
                    dgvUsuarios.DataSource = JsonConvert.DeserializeObject(strResponse, typeof(DataTable));
                }                
            }            
            return strResponse;
        }
        private string ApiRest_GetByUserName(string url)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = url;
            rClient.httpMethod = httpVerb.GET;

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest_GetByUserName();
            return strResponse;
        }
        #endregion
    }
}
