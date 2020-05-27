using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Aleatorio_Covid_19_Mendoza_Fabian
{
    public partial class Formulario : Form
    {   
        public Formulario()
        {
            InitializeComponent();       
        }
  
        private void Formulario_Load(object sender, EventArgs e)
        {
            btnEnviar.Enabled = false;
        }

        void Enviar_Datos()
        {
            Form1 frmForm1 = new Form1();
            frmForm1.txtRecibirCantSintoma.Text = txtEnviarSintoma.Text;
            frmForm1.txtRecibirCantSalida.Text = txtEnviarSalida.Text;
            frmForm1.txtRecibirCantDirectos.Text = txtEnviarDirecto.Text;
            this.Hide();
            frmForm1.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeclaracion.Checked == true)
            {
                btnEnviar.Enabled = true;
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            btnEnviar.Enabled = false;

            Inicio datos = new Inicio();

            int acumulador = 0;
            int contador = 0;

            if (cmbDolor.Text=="SI")
            {
                contador ++;
            }
            if (cmbAgotamiento.Text == "SI")
            {
                contador ++;
            }
            if (cmbTos.Text == "SI")
            {
                contador ++;
            }

            if (cmbFiebre.Text == "SI" || contador > 1)
            {
                acumulador = Convert.ToInt32(txtEnviarSintoma.Text);
                acumulador = acumulador + 1;
                txtEnviarSintoma.Text = acumulador.ToString();

                Enviar_Datos();

                datos.Solicitar_hisopado(); 
            }
            else
            {
                acumulador = Convert.ToInt32(txtEnviarSalida.Text);
                acumulador = acumulador + 1;
                txtEnviarSalida.Text = acumulador.ToString();

                Enviar_Datos();

                datos.Mostrar_salida();
            }   
        }
    }
}
