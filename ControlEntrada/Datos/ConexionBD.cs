using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class ConexionBD
    {
         public static string cadenaconexion = "Data Source=(Local)\\SQLEXPRESS;Initial Catalog=EntradaSalida;TrustServerCertificate=true;Persist Security Info=True;User ID=EntradaSalida;Password=1234";

        public static SqlConnection conectar()
        {
            SqlConnection connection = new SqlConnection(cadenaconexion);

            try
            {
                connection.Open();

                return connection;
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
           
        }

        public static Boolean desconectar()
        {
            SqlConnection connection = new SqlConnection(cadenaconexion);

            try
            {
                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
