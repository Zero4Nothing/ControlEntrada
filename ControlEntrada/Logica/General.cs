using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        public static void InsertarActualizarUsuarios(string texto, byte Foto, string Cedula, string Nombre, string Usuario, string Correo, string Contrasena, string Rol, int TipoCrud)
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

                //1 = insertar, 2 = Actualizar
                //3 = eliminar
                if (TipoCrud == 1 || TipoCrud == 2)
                {
                    byte[] fotoBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Foto.Save(ms, ImageFormat.Jpeg);
                        fotoBytes = ms.ToArray();
                    }
                    SqlParameter paramFoto = new SqlParameter("@Foto", SqlDbType.VarBinary, fotoBytes.Length);
                    paramFoto.Value = fotoBytes;
                    consulta.Parameters.Add(paramFoto);
                    consulta.Parameters.AddWithValue("@Cedula", Cedula);
                    consulta.Parameters.AddWithValue("@Nombre", Nombre);
                    consulta.Parameters.AddWithValue("@Correo", Correo);
                    consulta.Parameters.AddWithValue("@Usuario", Usuario);
                    consulta.Parameters.AddWithValue("@Contrasena", Contrasena);
                    consulta.Parameters.AddWithValue("@Rol", Rol);
                }
                consulta.ExecuteNonQuery();
                Mytransaction.Commit();
            }
            catch (Exception e)
            {
                Mytransaction?.Rollback();
                MessageBox.Show("No se puede realizar la operacion ;( " + e.Message);
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
