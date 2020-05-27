using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioIntegrador1_Mendoza
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TBUsuario.Focus();
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            string[,] matrizUserPass = new string[3, 2] { { "Admin", "admin" }, { "User", "user" }, { "Archiver", "archiver" } };
            bool miB = false;

            for (int i = 0; i < 3; i++)
            {
                if (TBUsuario.Text == matrizUserPass[i,0] && TBContraseña.Text == matrizUserPass[i, 1])
                {
                    Session["usuario"] =matrizUserPass[i,0];
                    miB = true;    
                    break;
                }
            }
            if (miB)
            {
                Response.Redirect("Bienvenido.aspx");
            }
            else
            {
                Label1.Text = "El usuario/contraseña no es correcto.";
                TBUsuario.Text = "";
                TBUsuario.Focus();
            }

        }
    }
}