using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEntrada
{
    public partial class Usuarios : Form
    {
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
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string rol = txtRol.Text;


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {

        }

        //private void groupBox2_Resize(object sender, EventArgs e)
        //{
        //    groupBox2.Left = (Width - groupBox2.Width) / 2;
        //    groupBox2.Top = (Height - groupBox2.Height) / 2;
        //}

        private void BNuevo_Click(object sender, EventArgs e)
        {
            //this.btnNuevo.Enabled = true;
            //this.BGuardar.Enabled = true;
            //this.BtnCancelar.Enabled = true;
            //this.BEliminar.Enabled = true;
            //this.BEditar.Enabled = true;
            // this.groupBox2.Enabled = true;

            groupBox2.Enabled = true;

            foreach(ToolStripItem item in bindingNavigator.Items)
            {
                if(item is ToolStripButton button)
                {
                   // button.Enabled = true;
                    BtnCancelar.Enabled = true;
                    BGuardar.Enabled = true;
                }
            }
           

        }
       
        private void Usuarios_Load(object sender, EventArgs e)
        {


            groupBox2.Enabled = false;
            btnNuevo.Enabled = true;

            // Verificar si existe registros
            Globales.VerificarRegistros(this);

            if (this.usuariosbindingSource.Count > 0)
            {
                //Integrar los componentes con los binding si existen registros

                this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usuariosbindingSource, "Foto", true));
                this.txtIdUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "IdUsuario", true));
                this.txtCedula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Cedula", true));
                this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nombre", true));
                this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Correo", true));
                this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Usuario", true));
                this.txtContrasena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Contrasena", true));
                this.txtRol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Rol", true));
                this.bindingNavigatorMoveFirstItem.PerformClick();


            }

            //foreach(ToolStripItem item in usuariosNavigator.Items)
            //{
            //    if(item is ToolStripButton button)
            //    {
            //        button.Enabled = button.Name == "addnewuser";
            //    }
            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = string.Empty;
                }
                if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
            }


            // txtCedula.Text = string.Empty;
            // txt
        }

        private void BGuardar_Click_1(object sender, EventArgs e)
        {
            foreach(Control control in groupBox2.Controls)
            {
                if(control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos", "Notificación");
                    return;
                }
               
                
            }
        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            groupBox2.Left = (Width - groupBox2.Width) / 2;
            groupBox2.Top = (Height - groupBox2.Height) / 2;
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            
                // Abrir el cuadro de diálogo para seleccionar una imagen
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog1.Title = "Seleccione una imagen";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen seleccionada en el PictureBox
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                pictureBox1.Image = null;
            

        }
    }
}
