using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEntrada
{
    public class Globales
    {
        #region Variables

        public static int TipoCrud;
        public static string Ced;
        public static int PosicionRegistro;
        //
        public static string Id_usuario;
        public static byte[] Foto_usuario;
        public static string cedula_usuario;
        public static string Nombre_usuario;
        public static string correo_usuario;
        public static string usuario_usuario;
        public static string contrasena_usuario;
        public static string rol_usuario;

        #endregion

        #region Usuarios

        public static void VerificarRegistros(Usuarios u)
        {
            General.VerificarExistenRegistros("Select Count(*) FROM Usuarios");
            if (Convert.ToInt32(General.cadena) > 0)
            { 
                General.BuscarRegistros("Select * From Usuarios");
                LeerRegistrosUsuarios(u);
                u.groupBox2.Enabled = false;
                u.bindingNavigatorMoveFirstItem.Enabled = true;
                u.bindingNavigatorMovePreviousItem.Enabled = true;
                u.bindingNavigatorPositionItem.Enabled = true;
                u.bindingNavigatorCountItem.Enabled = true;
                u.bindingNavigatorMoveNextItem.Enabled=true;
                u.bindingNavigatorMoveLastItem.Enabled=true;
                u.bindingNavigatorMoveFirstItem.Enabled=true;
                u.btnNuevo.Enabled=true;
                u.BGuardar.Enabled = false;
                u.BtnCancelar.Enabled = false;
                u.BEditar.Enabled = true;
                u.Buscar.Enabled = true;
                u.BEliminar.Enabled = true;
                u.BBuscar.Enabled = true;
                u.BTodosLosRegistros.Enabled = true;

            }
            else
            {
                u.groupBox2.Enabled = false;
                u.bindingNavigatorMoveFirstItem.Enabled = true;
                u.bindingNavigatorMovePreviousItem.Enabled = true;
                u.bindingNavigatorPositionItem.Enabled = true;
                u.bindingNavigatorCountItem.Enabled = true;
                u.bindingNavigatorMoveNextItem.Enabled = true;
                u.bindingNavigatorMoveLastItem.Enabled = true;
                u.bindingNavigatorMoveFirstItem.Enabled = true;
                u.btnNuevo.Enabled = true;
                u.BGuardar.Enabled = false;
                u.BtnCancelar.Enabled = false;
                u.BEditar.Enabled = true;
                u.Buscar.Enabled = true;
                u.BEliminar.Enabled = true;
                u.BBuscar.Enabled = true;
                u.BTodosLosRegistros.Enabled = true;

            }
        }

        public static void GuardarUsuario(Usuarios u)
        {
            if(TipoCrud == 1) // Insertar
            {
                General.InsertarActualizar("INSERT INTO Usuarios VALUES (@Foto, @Cedula, @Nombre, @Correo, @Usuario, @Contrasena, @Rol)",
                   Convertir_Imagen_Bytes(u.pictureBox1.Image),
                    u.txtCedula.Text,
                    u.txtNombre.Text,
                    u.txtCorreo.Text,
                    u.txtUsuario.Text,
                    u.txtContrasena.Text,
                    u.txtRol.Text, TipoCrud);
                VerificarRegistros(u);
            }

            if(TipoCrud == 2) // Actualizar
            {
                General.InsertarActualizar("UPDATE Usuarios Set Foto = @Foto, " + "Cedula = @Cedula, " + "Nombre = @Nombre," + "Correo = @Correo," + "Usuario = @Usuario,"+ "Contrasena = @Contrasena"+"Rol = @Rol Where IdUsuario = " + "'"+ Convert.ToInt32(u.txtIdUsuario.Text)+ "'",
                    Convertir_Imagen_Bytes(u.pictureBox1.Image),
                    u.txtCedula.Text,
                    u.txtNombre.Text,
                    u.txtCorreo.Text,
                    u.txtUsuario.Text,
                    u.txtContrasena.Text,
                    u.txtRol.Text, TipoCrud);
                //
                u.groupBox2.Enabled = false;
                u.bindingNavigatorMoveFirstItem.Enabled = true;
                u.bindingNavigatorMovePreviousItem.Enabled = true;
                u.bindingNavigatorPositionItem.Enabled = true;
                u.bindingNavigatorCountItem.Enabled = true;
                u.bindingNavigatorMoveNextItem.Enabled = true;
                u.bindingNavigatorMoveLastItem.Enabled = true;
                u.bindingNavigatorMoveFirstItem.Enabled = true;
                u.btnNuevo.Enabled = true;
                u.BGuardar.Enabled = false;
                u.BtnCancelar.Enabled = false;
                u.BEditar.Enabled = true;
                u.Buscar.Enabled = true;
                u.BEliminar.Enabled = true;
                u.BBuscar.Enabled = true;
                u.BTodosLosRegistros.Enabled = true;
            }
        }

        public static void LeerRegistrosUsuarios(Usuarios u)
        {
            //Recorrer la tabla
            for (int i = 0; i< General.temporal.Rows.Count; i++)
            {
                //llenamos la imagen y los textbox
                u.pictureBox1.Image = Globales.Convertir_Bytes_Imagen((Byte[])(General.temporal.Rows[i]["Foto"]));
                u.txtIdUsuario.Text = General.temporal.Rows[i]["IdUsuario"].ToString();
                u.txtCedula.Text = General.temporal.Rows[i]["Cedula"].ToString();
                u.txtNombre.Text = General.temporal.Rows[i]["Nombre"].ToString();
                u.txtCorreo.Text = General.temporal.Rows[i]["Correo"].ToString();
                u.txtUsuario.Text = General.temporal.Rows[i]["Usuario"].ToString();
                u.txtContrasena.Text = General.temporal.Rows[i]["Contrasena"].ToString();
                u.txtRol.Text = General.temporal.Rows[i]["Rol"].ToString();
            }
            // u.usuariosbindingSource.DataSource = General.temporal;
        }

        #endregion

        #region Imagenes

        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        public static Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }

        #endregion
    }
}
