using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioIntegrador1_Mendoza
{
    public partial class Calcular1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TBGastosFijos.Focus();
        }
        void Limpiar_TB()
        {
            TBGastosFijos.Text = "";
            TBGastosSueldos.Text = "";
            TBGastosVar.Text = "";
            TBImpuestos.Text = "";
        }
        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal gastosFijos, gastosSueldos, impuestos, gastosVariables, calculoTotal;
            string username = this.Session["usuario"].ToString();

            gastosFijos = Convert.ToDecimal(TBGastosFijos.Text);
            gastosSueldos = Convert.ToDecimal(TBGastosSueldos.Text);
            gastosVariables = Convert.ToDecimal(TBGastosVar.Text);
            impuestos = Convert.ToDecimal(TBImpuestos.Text);

            calculoTotal = (gastosFijos + gastosSueldos + gastosVariables + impuestos) + ((gastosFijos + gastosVariables) * 0.05m);

            if (CheckBox1.Checked == true)
            {
                calculoTotal = (1 - 0.105m) * calculoTotal;
            }

            //calculoTotal = Math.Round(calculoTotal, 2, MidpointRounding.AwayFromZero); //para redondear

            LblResultado.Text = DDLMes.SelectedValue + " - " + DDLAño.SelectedValue + " - " + String.Format(new CultureInfo("en-US"), "{0:C}", calculoTotal);

            StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/log/log1.txt", true);

            arch.WriteLine("<b>GASTOS:</b> " + DDLMes.SelectedValue + " - " + DDLAño.SelectedValue + " - " + LblResultado.Text + " - " + username);// mes - año - gasto - usuario que calculo
            arch.WriteLine("<br>");
            arch.WriteLine("<hr>");
            arch.Close();

            Limpiar_TB();
        }
    }
}