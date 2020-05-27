using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioIntegrador1_Mendoza
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = this.Session["usuario"].ToString();

            lblUsername.Text = "Bienvenido, "+username;

            switch (username)
            {
                case "Admin":
                    IBArchivar.Visible = true;
                    IBCalcular.Visible = true;
                    IBSubir.Visible = true;
                    break;
                case "User":
                    IBArchivar.Visible = true;
                    IBSubir.Visible = true;
                    break;
                case "Archiver":
                    IBArchivar.Visible = true;
                    break;
                default:
                    break;
            }
        }

        protected void IBCalcular_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("calcular.aspx");
        }

        protected void IBArchivar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("archivar.aspx");
        }

        protected void IBSubir_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("subir.aspx");
        }

        protected void IBLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("bienvenido.aspx");
        }
    }
}