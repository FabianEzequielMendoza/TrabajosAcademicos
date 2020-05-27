using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTurnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            MySQL alta = new MySQL();

            alta.Alta_Turno(this.pantalla,1);

        }

        private void BtnAtencionPublico_Click(object sender, EventArgs e)
        {
            MySQL alta = new MySQL();

            alta.Alta_Turno(this.pantalla, 2);

        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
