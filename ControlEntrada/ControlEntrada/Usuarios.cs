//using DynamicData.Kernel;
using Logica;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ControlEntrada
{
    public partial class Usuarios : Form
    {

        public object txtDocumento { get; private set; }
        public Usuarios()
        {
            InitializeComponent();
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
            Globales.TipoCrud = 2;
            //Actualizar
            this.Buscar.Text = this.txtDocumento.ToString();
            this.txtContrasena.Text = Encriptar.Descencriptar1(this.txtContrasena.Text);
            this.txtContrasena.PasswordChar = 'º';
            this.groupBox2.Enabled = true;
            this.bindingNavigatorMoveFirstItem.Enabled = false;
            this.bindingNavigatorMovePreviousItem.Enabled = false;
            this.bindingNavigatorPositionItem.Enabled = false;
            this.bindingNavigatorCountItem.Enabled = false;
            this.bindingNavigatorMoveNextItem.Enabled = false;
            this.bindingNavigatorMoveLastItem.Enabled = false;
            this.btnNuevo.Enabled = true;
            this.BGuardar.Enabled = true;
            this.BtnCancelar.Enabled = true;
            this.Buscar.Enabled = false;
            this.BEliminar.Enabled = false;
            this.BBuscar.Enabled = false;
            this.BTodosLosRegistros.Enabled = false;
            this.txtCedula.Focus();
        }

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
    }
}




