using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio2_Mendoza_Manejo_de_IO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String fechaIngresada;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btnAgendar_Click(object sender, EventArgs e)
        {
            this.fechaIngresada = Calendar1.SelectedDate.Day.ToString() + Calendar1.SelectedDate.Month.ToString() + Calendar1.SelectedDate.Year.ToString();

            StreamWriter archEscribir = new StreamWriter(Server.MapPath(".") + "/Calendario/" + this.fechaIngresada + ".text", true);
            archEscribir.WriteLine("<b>Título: </b>" + txtTitulo.Text + "- Hora: " + txtHora.Text);
            archEscribir.WriteLine("<br>");
            archEscribir.WriteLine("Descripción: " + txtDescripcion.Text);
            archEscribir.WriteLine("<br>");
            archEscribir.WriteLine("<hr>");
            archEscribir.Close();



            if (File.Exists(Server.MapPath(".") + "/Calendario/" + this.fechaIngresada + ".text")) {
                StreamReader archLeer = new StreamReader(Server.MapPath(".") + "/Calendario/" + this.fechaIngresada + ".text");
                lblMostrar.Text = archLeer.ReadToEnd();
                archLeer.Close();
                
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            this.fechaIngresada = Calendar1.SelectedDate.Day.ToString() + Calendar1.SelectedDate.Month.ToString() + Calendar1.SelectedDate.Year.ToString();
            if (File.Exists(Server.MapPath(".") + "/Calendario/" + this.fechaIngresada + ".text"))
            {
                StreamReader archLeer = new StreamReader(Server.MapPath(".") + "/Calendario/" + this.fechaIngresada + ".text");
                lblMostrar.Text = archLeer.ReadToEnd();
                archLeer.Close();

            }
            else
            {
                lblMostrar.Text ="[]";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "[]";
            txtDescripcion.Text = "";
            txtHora.Text = "";
            txtTitulo.Text = "";
        }
    }
}