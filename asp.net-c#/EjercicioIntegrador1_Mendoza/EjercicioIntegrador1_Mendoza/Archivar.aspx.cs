using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioIntegrador1_Mendoza
{
    public partial class Archivar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath(".") + "/log/log1.txt"))
            {
                StreamReader arch = new StreamReader(Server.MapPath(".") + "/log/log1.txt");
                LblMostrarLog.Text = arch.ReadToEnd();
                arch.Close();
            }
            else
            {
                LblMostrarLog.Text = "No existe ningún archivo log.";
            }
        }
    }
}