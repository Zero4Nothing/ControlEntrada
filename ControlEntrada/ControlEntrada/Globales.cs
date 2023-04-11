using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ControlEntrada
{
    public class Globales
    {
        #region Variables

        public static int TipoCrud;
        public static string Ced;
        public static int PosicionRegistro;
        //
        public static string Id_Usuario;
        public static byte[] Foto_Usuario;
        public static string Cedula_Usuario;
        public static string Nombre_Usuario;
        public static string Correo_Usuario;
        public static string Usuario;
        public static string Contrasena_Usuario;
        public static string Rol_Usuario;

        #endregion

        #region Usuarios

        public static void VerificarRegistrosUsuarios(Usuarios u)
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
          //  byte[] image = ImageToByteArray(u.pctbFoto.Image);
            if (TipoCrud == 1) // Insertar
            {
                General.InsertarActualizarUsuarios("INSERT INTO Usuarios VALUES ( @Foto, @Cedula,@Nombre,@Correo,@Usuario, @Contrasena,@Rol)",
                    u.pctbFoto.Image,
                    u.txtCedula.Text,
                    u.txtNombre.Text,
                    u.txtCorreo.Text,
                    u.txtUsuario.Text,
                    u.txtContrasena.Text,
                    u.cmbRol.Text, TipoCrud);
                    VerificarRegistrosUsuarios(u);
            }

            if (TipoCrud == 2) // Actualizar
            {
                General.InsertarActualizarUsuarios("UPDATE Usuarios Set Foto = @Foto, " + 
                    "Cedula = @Cedula, " + 
                    "Nombre = @Nombre," + 
                    "Correo = @Correo," + 
                    "Usuario = @Usuario," + 
                    "Contrasena = @Contrasena" + 
                    "Rol = @Rol " +
                    "Where IdUsuario = " + "'" + Convert.ToInt32(u.txtIdUsuario.Text) + "'",
                    u.pctbFoto.Image,
                    u.txtCedula.Text,
                    u.txtNombre.Text,
                    u.txtCorreo.Text,
                    u.txtUsuario.Text,
                    u.txtContrasena.Text,
                    u.cmbRol.Text, TipoCrud);
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
            for (int i = 0; i < General.temporal.Rows.Count; i++)
            {
                //llenamos la imagen y los textbox
                u.pctbFoto.Image = Globales.byteArrayToImage((Byte[])(General.temporal.Rows[i]["Foto"]));
                u.txtIdUsuario.Text = General.temporal.Rows[i]["IdUsuario"].ToString();
                u.txtCedula.Text = General.temporal.Rows[i]["Cedula"].ToString();
                u.txtNombre.Text = General.temporal.Rows[i]["Nombre"].ToString();
                u.txtCorreo.Text = General.temporal.Rows[i]["Correo"].ToString();
                u.txtUsuario.Text = General.temporal.Rows[i]["Usuario"].ToString();
                u.txtContrasena.Text = General.temporal.Rows[i]["Contrasena"].ToString();
                u.cmbRol.Text = General.temporal.Rows[i]["Rol"].ToString();
            }
            // u.usuariosbindingSource.DataSource = General.temporal;
        }

        #endregion

        #region Personas

//        public static void GuardarPersona(Personas u)
//        {
//            if (TipoCrud == 1) // Insertar
//            {
//                General.InsertarActualizarPersonas("INSERT INTO Personas VALUES (@Foto, @Cedula, @Nombre, @PrimerApellido, @SegundoApellido, @Ficha, @Huella, @NoDedo)",
//                   ImageToByteArray(u.fotoPictureBox1.Image),
//                    u.cedulaTextBox.Text,
//                    u.nombreTextBox.Text,
//                    u.primerApellidoTextBox.Text,
//                    u.segundoApellidoTextBox.Text,
//                    u.fichaTextBox.Text;
////Pendiente terminar
//              //  VerificarRegistrosPersonas(u);
//            }

//            if (TipoCrud == 2) // Actualizar
//            {
//                General.InsertarActualizarPersonas("UPDATE Personas Set Foto = @Foto, " + "Cedula = @Cedula, " + "Nombre = @Nombre," + "PrimerApellido = @PrimerApellido," + "SegundoApellido = @SegundoApellido," + "Ficha = @Ficha," + "Huella = @Huella, Where IdUsuario = " + "'" + Convert.ToInt32(u.txtIdUsuario.Text) + "'",
//                    ImageToByteArray(u.fotoPictureBox1.Image),
//                    u.cedulaTextBox.Text,
//                    u.nombreTextBox.Text,
//                    u.primerApellidoTextBox.Text,
//                    u.segundoApellidoTextBox.Text,
//                    u.fichaTextBox.Text, TipoCrud);
//                //
//            }
//        }


        #endregion

        #region Imagenes


        public static byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        //Convertir array de bytes en imagen
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returImage = Image.FromStream(ms);
            return returImage;
        }

        #endregion

        #region Huella

        public static void LimpiarHuella(Personas x)
        {
            for (int i = 0; i < 10; i++)
            {
                x.Data.Templates[i] = null;
            }
            x.noDedoTextBox.Text = "0";
        }

        public static void SeleccionarDedo(Personas x)
        {
            if (string.IsNullOrEmpty(x.noDedoTextBox.Text))
            {
                x.noDedoTextBox.Text = "0";
            }
            switch (Convert.ToInt32(x.noDedoTextBox.Text))
            {
                case 1:
                    x.enrollmentControl1.EnrolledFingerMask = 32;
                    break;

                case 2:
                    x.enrollmentControl1.EnrolledFingerMask = 64;
                    break;

                case 3:
                    x.enrollmentControl1.EnrolledFingerMask = 128;
                    break;

                case 4:
                    x.enrollmentControl1.EnrolledFingerMask = 256;
                    break;

                case 5:
                    x.enrollmentControl1.EnrolledFingerMask = 512;
                    break;

                case 6:
                    x.enrollmentControl1.EnrolledFingerMask = 16;
                    break;

                case 7:
                    x.enrollmentControl1.EnrolledFingerMask = 8;
                    break;

                case 8:
                    x.enrollmentControl1.EnrolledFingerMask = 4;
                    break;

                case 9:
                    x.enrollmentControl1.EnrolledFingerMask = 2;
                    break;

                case 10:
                    x.enrollmentControl1.EnrolledFingerMask = 1;
                    break; 

                default:
                    x.enrollmentControl1.EnrolledFingerMask = 0;
                    break;

            }
        }
    }

    #endregion
}

