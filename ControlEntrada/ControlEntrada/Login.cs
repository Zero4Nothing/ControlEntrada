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
            string encript = Encriptar.GetSHA256(contrasena);


            try
            {
               
                //Traer contraseña



                //Desencriptar password




                SqlCommand command = new SqlCommand("SELECT Usuario FROM Usuarios WHERE Usuario=@Usuario AND Contrasena = @Contrasena", ConexionBD.conectar());

                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contrasena", encript);


                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                if (dt.Rows.Count != 0)
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
