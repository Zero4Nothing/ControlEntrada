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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            Usuarios FormUsers = new Usuarios();
            FormUsers.ShowDialog();
        }

        private void registroButton_Click(object sender, EventArgs e)
        {
            RegistroPersonas RegistroPersonas = new RegistroPersonas();
            RegistroPersonas.ShowDialog();
        }

        private void registroEntSalButton_Click(object sender, EventArgs e)
        {
            RegistroControl RegistroEntradaSalida = new RegistroControl();
            RegistroEntradaSalida.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes Reportes = new Reportes();
            Reportes.ShowDialog();
        }
    }
}
