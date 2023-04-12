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
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
           Data = new AppData();
        }
        
        public AppData Data;
        public int i;
       

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entradaSalidaDataSet);

        }

        private void AgregarPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'entradaSalidaDataSet.Personas' Puede moverla o quitarla según sea necesario.
            //this.personasTableAdapter.Fill(this.entradaSalidaDataSet.Personas);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enrollmentControl1_OnDelete(object Control, int FingerMask, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if(Data.IsEventHandlerSucceeds)
            {
                Data.Templates[FingerMask - 1] = null; //Clear the finger template
            }
            else
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure; //force a "failture" status
            
        }

        private void enrollmentControl1_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (Data.IsEventHandlerSucceeds)
            {
                Globales.LimpiarHuella(this);
                Data.Templates[FingerMask - 1] = Template; //Store a finger template
                //ListEvents.Items.Insert(0, String.Format("OnEnroll: finger{0}", finger));

            }
            else
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure; //Force a "failture" status
        }

        private void enrollmentControl1_OnEnroll_1(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (Data.IsEventHandlerSucceeds)
            {
                Globales.LimpiarHuella(this);
                Data.Templates[FingerMask - 1] = Template; //Store a finger template
                //ListEvents.Items.Insert(0,String.Format("Enroll: finger{0}", Finger));
            }
            else
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure; //force a "Failture" status
        }

        private void enrollmentControl1_OnStartEnroll(object Control, string ReaderSerialNumber, int Finger)
        {
            this.noDedoTextBox.Text = Finger.ToString();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Abrir archivo";
            this.openFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;.png|All files (*.*|*.*";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.fotoPictureBox1.Image = null;
                this.fotoPictureBox1.Load(openFileDialog1.FileName);
                this.fotoPictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                Bitmap imagen = new Bitmap(new Bitmap(fotoPictureBox1.Image), 184, 184);
                this.fotoPictureBox1.Image = imagen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fotoPictureBox1.Image = null;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cantidadHuellas;
            if(this.fotoPictureBox1.Image == null)
            {
                MessageBox.Show("Por favor seleccione una foto");
                this.btnUploadPhoto.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.cedulaTextBox.Text))
                {
                    MessageBox.Show("Por favor digite el número del documento");
                    this.cedulaTextBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.nombreTextBox.Text))
                    {
                        MessageBox.Show("Por favor digite el nombre");
                        this.nombreTextBox.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.primerApellidoTextBox.Text))
                        {
                            MessageBox.Show("Por favor digite el primer apellido");
                            this.primerApellidoTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.fichaTextBox.Text))
                            {
                                MessageBox.Show("Por favor ingrese el número de la ficha");
                                this.fichaTextBox.Focus();
                            }
                            else
                            {
                                cantidadHuellas = 0;
                                for(int i = 0; i < 10; i++)
                                {
                                    if ((Data.Templates[i] != null))
                                    {
                                        cantidadHuellas++;
                                    }
                                }
                                if((cantidadHuellas == 0) && (this.enrollmentControl1.EnrolledFingerMask == 0))
                                {
                                    MessageBox.Show("No se puede guardar el registro, debe registrar mínimo una huella dactilar.", "Error");
                                    this.cedulaTextBox.Focus();
                                }
                                else
                                {
                                    try
                                    {
                                        cantidadHuellas = 0;
                                        for(i=0; i < 10; i++)
                                        {
                                            if ((Data.Templates[i] != null))
                                            {
                                                cantidadHuellas++;
                                                this.noDedoTextBox.Text = (i + 1).ToString();
                                               // Globales.GuardarPersona(this);
                                            }
                                        }
                                        if(cantidadHuellas==0)
                                        {
                                            if(this.enrollmentControl1.EnrolledFingerMask != 0)
                                            {
                                               // Globales.GuardarPersona(this);
                                            }
                                        }
                                    }
                                    catch(Exception e1)
                                    {
                                        MessageBox.Show("No se puede guardar el registro en la base de datos." + e1.ToString(), "Error");
                                        this.cedulaTextBox.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}


