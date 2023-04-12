using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEntrada
{
    public partial class EntradaSalida : Form
    {
        public EntradaSalida()
        {
            InitializeComponent();
            Data = new AppData();
        }
        private AppData Data;
        string cedula = string.Empty;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entradaSalidaDataSet);

        }

        private void EntradaSalida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'entradaSalidaDataSet.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.entradaSalidaDataSet.Personas);

        }

        private void verificationControl1_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();
            if(General.conexion.State == ConnectionState.Open)
            {
                General.conexion.Close();
            }
            SqlCommand command = new SqlCommand("Select Cedula, Huella From Personas", new SqlConnection(Datos.ConexionBD.cadenaconexion));

            General.conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            cedula = string.Empty;
            while (reader.Read())
            {
                byte[] Huella = (byte[])reader["Huella"];
                cedula = reader["Cedula"].ToString();
                MemoryStream memoryStream = new MemoryStream(Huella);
                DPFP.Template tmpObj = new DPFP.Template();
                tmpObj.DeSerialize(memoryStream);
                if(tmpObj != null)
                {
                    // compare el conjunto de funciones con una plantilla en particular

                    ver.Verify(FeatureSet, tmpObj, ref res);
                    Data.IsFeatureSetMatched = res.Verified;
                    Data.FalseAcceptRate = res.FARAchieved;
                    if (res.Verified)
                    {
                        //MessageBox.Show("Bien");
                        this.Resultado.Text = cedula;
                        break;
                    }
                }
            }

            if (!res.Verified)
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
                this.personasTableAdapter.BuscarPersonaId(this.entradaSalidaDataSet.Personas, -1); // Limpiar datasource
                this.Resultado.Text = "-1";
                //MessageBox.Show("Mal");
            }
        }

        public void buscar_registro()
        {
            if(!(string.IsNullOrEmpty(this.Resultado.Text)))
            {
                // Traigo los datos de la tabla personas
                this.personasTableAdapter.BuscarPersonaCedula(this.entradaSalidaDataSet.Personas, this.Resultado.Text);
                this.label2.Text = DateTime.Now.ToShortDateString();

            }
            else
            {
                // Usuario no registrado en la tabla registros, porque la cedula no existe
                this.label3.Visible = true;
                this.label3.Text = "Persona No Registrada, no existe en la base de datos";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscar_registro();
        }
    }
}
