//using DynamicData.Kernel;
using Logica;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace ControlEntrada
{
    public partial class Usuarios : Form
    {
        // Cadena de conexión a la base de datos
        private string cadenaConexion = "Data Source=(Local)\\SQLEXPRESS;Initial Catalog=EntradaSalida;TrustServerCertificate=true;Persist Security Info=True;User ID=EntradaSalida;Password=1234";


        // Clase para representar un usuario
        private class Usuario
        {
            public int IdUsuario { get; set; }
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string UsuarioName { get; set; }
            public string Contrasena { get; set; }
            public string Rol { get; set; }
            public byte[] Foto { get; set; }
        }
        private Usuario usuarioSeleccionado;

        public object txtDocumento { get; private set; }
        public Usuarios()
        {
            InitializeComponent();
            // Cargar los datos de la tabla "Usuarios" en el DataGridView
            ActualizarTabla();
        }
        private void ActualizarTabla()
        {
            // Realizar la consulta SQL para obtener los datos de la tabla "Usuarios"
            string sql = "SELECT * FROM Usuarios";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, cadenaConexion);
            System.Data.DataTable tabla = new System.Data.DataTable();
            adapter.Fill(tabla);

            // Asignar la tabla al DataGridView
            dgvUsuarios.DataSource = tabla;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.pctbFoto.Image == null)
            {
                MessageBox.Show("Falta la foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pctbFoto.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtCedula.Text))
                {
                    MessageBox.Show("Digite el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCedula.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtNombre.Text))
                    {
                        MessageBox.Show("Digite el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtNombre.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.txtCorreo.Text))
                        {
                            MessageBox.Show("Digite el correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtCorreo.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.txtUsuario.Text))
                            {
                                MessageBox.Show("Digite el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.txtUsuario.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.txtContrasena.Text))
                                {
                                    MessageBox.Show("Digite la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.txtContrasena.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(this.cmbRol.Text))
                                    {
                                        MessageBox.Show("Seleccione el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.cmbRol.Focus();
                                    }
                                    else
                                    {
                                        this.txtContrasena.Text = Encriptar.Encriptar1(this.txtContrasena.Text);
                                        //Para ubicarse en la misma posicion
                                        Globales.GuardarUsuario(this);
                                        if (Globales.TipoCrud == 1)
                                        {
                                            //se desplaza al ultimo registro si es insertar
                                            this.bindingNavigatorMoveLastItem.PerformClick();
                                        }
                                        if (Globales.TipoCrud == 2)
                                        {
                                            //Para que el bindingnavigator se posicione 
                                            this.Buscar.Text = null;
                                            this.bindingNavigatorPositionItem.Focus();
                                        }
                                        groupBox2.Enabled = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Globales.TipoCrud = 1; // Insertar
            this.groupBox2.Enabled = true;
            this.bindingNavigatorMoveFirstItem.Enabled = false;
            this.bindingNavigatorMovePreviousItem.Enabled = false;
            this.bindingNavigatorPositionItem.Enabled = false;
            this.bindingNavigatorCountItem.Enabled = false;
            this.bindingNavigatorMoveNextItem.Enabled = false;
            this.bindingNavigatorMoveLastItem.Enabled = false;
            this.btnNuevo.Enabled = false;
            this.BGuardar.Enabled = true;
            this.BtnCancelar.Enabled = true;
            this.BEditar.Enabled = true;
            this.Buscar.Enabled = true;
            this.BBuscar.Enabled = true;
            this.BEliminar.Enabled = false;
            this.BTodosLosRegistros.Enabled = true;
            //copia de los datos 
            // si decide cancelar la inseccion 
            Globales.Id_Usuario = this.txtIdUsuario.Text;
            if (this.pctbFoto.Image != null)
            {
                Globales.Foto_Usuario = Globales.ImageToByteArray(this.pctbFoto.Image);
            }

            Globales.Cedula_Usuario = this.txtCedula.Text;
            Globales.Nombre_Usuario = this.txtNombre.Text;
            Globales.Correo_Usuario = this.txtCorreo.Text;
            Globales.Usuario = this.txtIdUsuario.Text;
            Globales.Contrasena_Usuario = this.txtContrasena.Text;
            Globales.Rol_Usuario = this.cmbRol.Text;
            //
            this.txtIdUsuario.Text = null;
            this.pctbFoto.Image = null;
            this.txtCedula.Text = null;
            this.txtNombre.Text = null;
            this.txtCorreo.Text = null;
            this.txtUsuario.Text = null;
            this.txtContrasena.Text = null;
            this.cmbRol.Text = null;
        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            this.groupBox2.Left = (Width - groupBox2.Width) / 2;
            groupBox2.Top = (Height - groupBox2.Height) / 2;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            // Verificar si existe registros
            Globales.VerificarRegistrosUsuarios(this);

            if (this.usuariosbindingSource.Count > 0)
            {
                //Integrar los componentes con los binding si existen registros

                this.pctbFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usuariosbindingSource, "Foto", true));
                this.txtIdUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosbindingSource, "IdUsuario", true));
                this.txtCedula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosbindingSource, "Cedula", true));
                this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosbindingSource, "Nombre", true));
                this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosbindingSource, "Correo", true));
                this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosbindingSource, "Usuario", true));
                this.txtContrasena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosbindingSource, "Contrasena", true));
                this.cmbRol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosbindingSource, "Rol", true));
                this.bindingNavigatorMoveFirstItem.PerformClick();
                this.groupBox2.Enabled = true;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.txtIdUsuario.Text = null;
            this.pctbFoto.Image = null;
            this.txtCedula.Text = null;
            this.txtNombre.Text = null;
            this.txtCorreo.Text = null;
            this.txtUsuario.Text = null;
            this.txtContrasena.Text = null;
            this.cmbRol.Text = null;
            //queda en el mismo registro 
            this.Buscar.Text = this.txtCedula.Text;
            this.groupBox2.Enabled = false;
            this.bindingNavigatorMoveFirstItem.Enabled = true;
            this.bindingNavigatorMovePreviousItem.Enabled = true;
            this.bindingNavigatorPositionItem.Enabled = true;
            this.bindingNavigatorCountItem.Enabled = true;
            this.bindingNavigatorMoveNextItem.Enabled = true;
            this.bindingNavigatorMoveLastItem.Enabled = true;
            this.bindingNavigatorMoveFirstItem.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.BGuardar.Enabled = false;
            this.BtnCancelar.Enabled = true;
            this.BEditar.Enabled = true;
            this.Buscar.Enabled = true;
            this.BEliminar.Enabled = false;
            this.BBuscar.Enabled = true;
            this.BTodosLosRegistros.Enabled = true;

            if (!(string.IsNullOrEmpty(this.txtContrasena.Text)))

            {
                this.txtContrasena.Text = Encriptar.Encriptar1(this.txtContrasena.Text);
            }
            // devuelve lo sdatos originales 

            if (Globales.TipoCrud == 1)

            {
                Globales.Id_Usuario = this.txtIdUsuario.Text;
                if (this.pctbFoto.Image != null)
                {
                    Globales.Foto_Usuario = Globales.ImageToByteArray(this.pctbFoto.Image);
                }

                Globales.Cedula_Usuario = this.txtCedula.Text;
                Globales.Nombre_Usuario = this.txtNombre.Text;
                Globales.Correo_Usuario = this.txtCorreo.Text;
                Globales.Usuario = this.txtIdUsuario.Text;
                Globales.Contrasena_Usuario = this.txtContrasena.Text;
                Globales.Rol_Usuario = this.cmbRol.Text;
                //se ubica en la posicion del registro modificado 
                //  this.UsuariosSource1.Position = this.UsuariosSource1.Find("Cedula", this.Buscar.Text);
                //para que le bindign navigator se ubique biem
                this.Buscar.Text = null;
                this.bindingNavigatorPositionItem.Focus();
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (this.pctbFoto.Image == null)
            {
                MessageBox.Show("Falta la foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pctbFoto.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtCedula.Text))
                {
                    MessageBox.Show("Digite el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCedula.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtNombre.Text))
                    {
                        MessageBox.Show("Digite el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtNombre.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.txtCorreo.Text))
                        {
                            MessageBox.Show("Digite el correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtCorreo.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.txtUsuario.Text))
                            {
                                MessageBox.Show("Digite el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.txtUsuario.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.txtContrasena.Text))
                                {
                                    MessageBox.Show("Digite la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.txtContrasena.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(this.cmbRol.Text))
                                    {
                                        MessageBox.Show("Seleccione el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.cmbRol.Focus();
                                    }
                                    else
                                    {
                                        this.txtContrasena.Text = Encriptar.GetSHA256(this.txtContrasena.Text);
                                        //Para ubicarse en la misma posicion
                                        Globales.GuardarUsuario(this);
                                        if (Globales.TipoCrud == 1)
                                        {
                                            //se desplaza al ultimo registro si es insertar
                                            this.bindingNavigatorMoveLastItem.PerformClick();
                                        }
                                        if (Globales.TipoCrud == 2)
                                        {
                                            //Para que el bindingnavigator se posicione 
                                            this.Buscar.Text = null;
                                            this.bindingNavigatorPositionItem.Focus();
                                        }
                                        groupBox2.Enabled = false;

                                        MessageBox.Show("Usuario guardado con éxito, Aviso");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    

        private void btnPhoto_Click(object sender, EventArgs e)
        {
        this.openFileDialog1.Title = "Abrir Archivo";
        this.openFileDialog1.Filter = "Image Files (*.png; *.jpg; *.jpeg)| *.png; *.jpg; *.jpeg";
        if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            this.pctbFoto.Image = null;
            this.pctbFoto.Load(openFileDialog1.FileName);
            this.pctbFoto.Image =
                System.Drawing.Image.FromFile(openFileDialog1.FileName);
            Bitmap imagen = new Bitmap(new Bitmap(pctbFoto.Image), 196, 240);
            this.pctbFoto.Image = imagen;
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            pctbFoto.Image = null;
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un usuario en la tabla
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Deshabilitar el botón de editar para evitar conflictos
            BEditar.Enabled = false;

            // Habilitar los controles necesarios para editar el usuario
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtCorreo.Enabled = true;
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            cmbRol.Enabled = true;
            pctbFoto.Enabled = true;
            btnPhoto.Enabled = true;
            btnEliminarFoto.Enabled = true;

            // Mostrar la foto del usuario en el PictureBox (si tiene)
            if (usuarioSeleccionado.Foto != null)
            {
                MemoryStream ms = new MemoryStream(usuarioSeleccionado.Foto);
                pctbFoto.Image = Image.FromStream(ms);
            }

            // Llenar los controles con los valores del usuario seleccionado
            txtCedula.Text = usuarioSeleccionado.Cedula;
            txtNombre.Text = usuarioSeleccionado.Nombre;
            txtCorreo.Text = usuarioSeleccionado.Correo;
            txtUsuario.Text = usuarioSeleccionado.UsuarioName;
            txtContrasena.Text = usuarioSeleccionado.Contrasena;
            cmbRol.SelectedItem = usuarioSeleccionado.Rol;
        }

      




            //PARTE DEL INST ISAZA.
            //Globales.TipoCrud = 2;
            ////Actualizar
            //this.Buscar.Text = this.txtDocumento.ToString();
            //this.txtContrasena.Text = Encriptar.Descencriptar1(this.txtContrasena.Text);
            //this.txtContrasena.PasswordChar = 'º';
            //this.groupBox2.Enabled = true;
            //this.bindingNavigatorMoveFirstItem.Enabled = false;
            //this.bindingNavigatorMovePreviousItem.Enabled = false;
            //this.bindingNavigatorPositionItem.Enabled = false;
            //this.bindingNavigatorCountItem.Enabled = false;
            //this.bindingNavigatorMoveNextItem.Enabled = false;
            //this.bindingNavigatorMoveLastItem.Enabled = false;
            //this.btnNuevo.Enabled = true;
            //this.BGuardar.Enabled = true;
            //this.BtnCancelar.Enabled = true;
            //this.Buscar.Enabled = false;
            //this.BEliminar.Enabled = false;
            //this.BBuscar.Enabled = false;
            //this.BTodosLosRegistros.Enabled = false;
            //this.txtCedula.Focus();
        

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Eliminar este registro?", "Eliminar Registro",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(this.txtCedula.Text))
                {
                    MessageBox.Show("Este registro no tiene numero de documento", "error");
                }
                else
                {
                    General.VerificarExistenRegistros("Select * From Usuarios Where Cedula = " + "'" + this.txtCedula.Text + "'");
                    if (string.IsNullOrEmpty(General.cadena))
                    {
                        MessageBox.Show("EL numero del documento no existe", "Error");
                        this.Buscar.Focus();
                    }
                    else
                    {
                        General.BuscarRegistros("DELETE FROM Usuarios WHERE Cedula = '" + this.txtCedula.Text + "'");
                        Globales.VerificarRegistrosUsuarios(this);
                        //Se desplaza el ultimo registro 
                        this.bindingNavigatorMoveLastItem.PerformClick();
                    }
                }
            }
        }

        private void cmbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el usuario seleccionado
            int indiceFila = e.RowIndex;
            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[indiceFila];
                int idUsuario = Convert.ToInt32(fila.Cells["IdUsuario"].Value);

                // Realizar la consulta SQL para obtener los datos del usuario seleccionado
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string sql = "SELECT * FROM Usuarios WHERE IdUsuario=@id";
                    SqlCommand command = new SqlCommand(sql, conexion);
                    command.Parameters.AddWithValue("@id", idUsuario);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Rellenar los controles con los datos del usuario seleccionado
                        txtCedula.Text = reader["Cedula"].ToString();
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtCorreo.Text = reader["Correo"].ToString();
                        txtUsuario.Text = reader["Usuario"].ToString();
                        txtContrasena.Text = reader["Contrasena"].ToString();
                        cmbRol.SelectedItem = reader["Rol"].ToString();
                        byte[] foto = reader["Foto"] as byte[];
                        if (foto != null)
                        {
                            MemoryStream ms = new MemoryStream(foto);
                            pctbFoto.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            pctbFoto.Image = null;
                        }

                        // Habilitar los controles para editar el usuario
                        txtCedula.Enabled = true;
                        txtNombre.Enabled = true;
                        txtCorreo.Enabled = true;
                        txtUsuario.Enabled = true;
                        txtContrasena.Enabled = true;
                        cmbRol.Enabled = true;
                        pctbFoto.Enabled = true;
                        btnPhoto.Enabled = true;
                        btnEliminarFoto.Enabled = true;
                        BGuardar.Enabled = true;
                        BtnCancelar.Enabled = true;
                        BEditar.Enabled = false;

                        // Crear un objeto "usuarioSeleccionado" con los datos del usuario seleccionado

                        usuarioSeleccionado = new Usuario()
                        {
                            IdUsuario = idUsuario,
                            Cedula = txtCedula.Text,
                            Nombre = txtNombre.Text,
                            Correo = txtCorreo.Text,
                            UsuarioName = txtUsuario.Text,
                            Contrasena = txtContrasena.Text,
                            Rol = cmbRol.SelectedItem.ToString(),
                            Foto = foto
                        };
                    }
                    reader.Close();
                }
            }
        }

   
    }
}





