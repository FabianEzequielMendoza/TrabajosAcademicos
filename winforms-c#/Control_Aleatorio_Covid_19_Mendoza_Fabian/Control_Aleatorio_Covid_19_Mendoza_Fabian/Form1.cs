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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        void Enviar_Datos()
        {
            Formulario frmFormulario = new Formulario();

            frmFormulario.txtEnviarDirecto.Text = txtRecibirCantDirectos.Text;
            frmFormulario.txtEnviarSalida.Text = txtRecibirCantSalida.Text;
            frmFormulario.txtEnviarSintoma.Text = txtRecibirCantSintoma.Text;
            this.Hide();
            frmFormulario.Show();
        }
        private void BtnPulsarBotón_Click(object sender, EventArgs e)
        {
            int acumulador=0;

            Inicio sorteo = new Inicio();
            int resultado = sorteo.Sortear();

            if (resultado == 4)
            {
                acumulador = Convert.ToInt32(txtRecibirCantDirectos.Text);
                acumulador =acumulador+1;

                txtRecibirCantDirectos.Text = acumulador.ToString();
                
                sorteo.Solicitar_hisopado();

            }
            else if (resultado == 5)
            {
                Enviar_Datos();
            }
            else
            {
                acumulador = Convert.ToInt32(txtRecibirCantSalida.Text);
                acumulador = acumulador + 1;

                txtRecibirCantSalida.Text = acumulador.ToString();

                sorteo.Mostrar_salida();
            }
        }

        private void BtnLocal_Click(object sender, EventArgs e)
        {
            txtHisopadoDirecto.Text = txtRecibirCantDirectos.Text;
            txtHisopadoSintoma.Text = txtRecibirCantSintoma.Text;
            txtCantidadPersonas.Text = (Convert.ToInt32(txtRecibirCantSalida.Text) +
                Convert.ToInt32(txtRecibirCantSintoma.Text) + Convert.ToInt32(txtRecibirCantDirectos.Text)).ToString();
        }

        private void BtnOnline_Click(object sender, EventArgs e)
        {
            DatosJSON informe = new DatosJSON();
            Estadisticas estadistica = new Estadisticas();

            informe = Newtonsoft.Json.JsonConvert.DeserializeObject<DatosJSON>(estadistica.Obtener_datos());

            txtCantidadPersonas.Text = informe.personas.ToString();
            txtHisopadoSintoma.Text = informe.formularios.ToString();
            txtHisopadoDirecto.Text = informe.hisopados.ToString();

        }
    }
}
