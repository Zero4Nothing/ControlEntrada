using Datos;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEntrada
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
     
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            try {
                SqlCommand command = new SqlCommand("SELECT * FROM usuarios WHERE Usuario = @pepito AND Contrasena = @Contrasena", ConexionBD.conectar());
                command.Parameters.AddWithValue("@pepito", usuario);
                command.Parameters.AddWithValue("@Contrasena", contrasena);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    this.Hide();
                    Menu menuPrincipal = new Menu();
                    menuPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Usuario y/o contraseña incorrectos.");
                }

                ConexionBD.desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar ingresar " + ex.ToString());
            }

            
        }
        
    }
}
