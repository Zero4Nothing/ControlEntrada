using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public static class General
    {
        //sqlconnection se utiliza para conectarnos con la bd
        public static SqlConnection conexion = new SqlConnection(Datos.ConexionBD.cadenaconexion);
        //sqlcommand; realizar consultas
        public static SqlCommand consulta = conexion.CreateCommand();
        //sqldatareader, para leer flujos de filas;
        //el signo de interrogacion representa un parametro
        //que luego sea reemplazado
        public static SqlDataReader LeerVariosRegistros;
        //SqlTransaction, confirmar o anular una transaccion
        //el signo ? significa que puede aceptar valores null
        public static SqlTransaction Mytransaction;
        //sqlDataadapter, se utiliza para rellenar un dataset
        public static SqlDataAdapter da = new SqlDataAdapter();
        //datatable, representa una tabla de datos de memoria
        public static DataTable temporal = new DataTable();
        public static string cadena;

        public static void Consulta_Cadena(string texto)
        {
            string cadena = string.Empty;
            try
            {
                conexion.Open();
                Mytransaction = conexion.BeginTransaction();
                consulta.Transaction = Mytransaction;
                consulta.CommandText = texto;

                if (Information.IsDBNull(consulta.ExecuteScalar()))
                {
                    cadena = string.Empty;

                }
                else
                {
                    cadena = consulta.ExecuteScalar().ToString();
                    Mytransaction.Commit();
                }
            }
            catch (Exception)
            {
                Mytransaction?.Rollback();
            }
            finally
            {
                conexion.Close();
            }

        }

        public static void InsertarActualizar(string texto, byte[] foto, string cedula, string nombre, string usuario, string correo, string contraseña, string rol, int tipoCrud)
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Open();
                Mytransaction = conexion.BeginTransaction();
                consulta.Transaction = Mytransaction;
                consulta.CommandText = texto;
                int TipoCrud = 0;
                //1 = insertar, 2 = Actualizar
                //3 = eliminar
                if (TipoCrud == 1 || TipoCrud == 2)
                {
                    consulta.Parameters.AddWithValue("@Foto", foto);
                    consulta.Parameters.AddWithValue("@Cedula", cedula);
                    consulta.Parameters.AddWithValue("@Nombre", nombre);
                    consulta.Parameters.AddWithValue("@Correo", correo);
                    consulta.Parameters.AddWithValue("@Usuario", usuario);
                    consulta.Parameters.AddWithValue("@Contraseña", contraseña);
                    consulta.Parameters.AddWithValue("@Rol", rol);
                }
            }

            catch (Exception e)
            {
                Mytransaction?.Rollback();
                MessageBox.Show("No se puede realizar la operacion" + e.Message);
            }
            finally
            {
                consulta.Parameters.Clear();
                conexion.Close();
            }
        }

        public static void VerificarExistenRegistros(string texto)
        {
            try
            {
                conexion.Open();
                Mytransaction = conexion.BeginTransaction();
                consulta.Transaction = Mytransaction;
                consulta.CommandText = texto;

                if (Information.IsDBNull(consulta.ExecuteScalar()))
                {
                    cadena = string.Empty;
                }
                else
                {
                    cadena = consulta.ExecuteScalar().ToString();
                    Mytransaction.Commit();
                }
            }

            catch (Exception)
            {
                Mytransaction?.Rollback();
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void BuscarRegistros(string texto)
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            conexion.Open();
            consulta.CommandText = texto;
            da = new SqlDataAdapter(consulta);
            temporal.Clear();
            da.Fill(temporal);
            conexion.Close();
        }
    }
}
