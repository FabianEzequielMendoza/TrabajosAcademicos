using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio1_Mendoza
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public void habilitarBotones()
        {

            BtnSuma.Enabled = true;
            BtnResta.Enabled = true;
            BtnMultiplicacion.Enabled = true;
            BtnDivision.Enabled = true;
        }

        public void deshabilitarBotones()
        {

            BtnSuma.Enabled = false;
            BtnResta.Enabled = false;
            BtnMultiplicacion.Enabled = false;
            BtnDivision.Enabled = false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            deshabilitarBotones();
        }
        public int sumar(int a, int b)
        { 
            return a+b;
        }
        public int restar(int a, int b)
        {
            return a - b;
        }
        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public int dividir(int a, int b)
        {
            return a / b;
        }

        //Para validar solo numeros
        public void validarNumericos(TextBox TB)
        {
            string textoIngresado;
            textoIngresado = TB.Text;
            for (int x = 0; x < textoIngresado.Length; x++)
            {
                if (textoIngresado[x] >= '0' && textoIngresado[x] <= '9')
                {
                }
                else
                {
                    TB.Focus();
                    TB.Text = "";
                }
            }
        }

        protected void TBNumero1_TextChanged(object sender, EventArgs e)
        {
            validarNumericos(TBNumero1);
            if (TBNumero1.Text != "" && TBNumero2.Text != "")
            {
                habilitarBotones();
            }
            else
            {
                deshabilitarBotones();
            }
        }

        protected void TBNumero2_TextChanged(object sender, EventArgs e)
        {
            validarNumericos(TBNumero2);
            if (TBNumero2.Text != "" && TBNumero1.Text != "")
            {
                habilitarBotones();
            }
            else
            {
                deshabilitarBotones();
            }
        }

        protected void BtnSuma_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(TBNumero1.Text);
            int b= Convert.ToInt32(TBNumero2.Text);
            LblResultado.Text="a + b= " + Convert.ToString(sumar(a,b));
            habilitarBotones();

        }

        protected void BtnResta_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TBNumero1.Text);
            int b = Convert.ToInt32(TBNumero2.Text);
            LblResultado.Text = "a - b= " + Convert.ToString(restar(a, b));
            habilitarBotones();
        }

        protected void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TBNumero1.Text);
            int b = Convert.ToInt32(TBNumero2.Text);
            LblResultado.Text = "a * b= " + Convert.ToString(multiplicar(a, b));
            habilitarBotones();
        }

        protected void BtnDivision_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TBNumero1.Text);
            int b = Convert.ToInt32(TBNumero2.Text);
            if (b !=0)
            {
                LblResultado.Text = "a / b= " + Convert.ToString(dividir(a, b));
                habilitarBotones();
            }
            else {
                LblResultado.Text = "ERROR, vuelve a digitar un numero != 0";
                habilitarBotones();
            }
            
        }
    }
}