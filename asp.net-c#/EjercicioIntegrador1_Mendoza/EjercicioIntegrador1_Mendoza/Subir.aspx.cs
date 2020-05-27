using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioIntegrador1_Mendoza
{
    public partial class Subir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubir_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Server.MapPath(".") + "/comprobantes/"+FileUpload1.FileName))
                {
                    LblEstado.Text = "Existe un archivo con dicho nombre en el servidor";
                }
                else
                {
                    if (FileUpload1.PostedFile.ContentLength < 2097152 && (FileUpload1.PostedFile.ContentType.ToString() == "image/jpeg"
                        || FileUpload1.PostedFile.ContentType.ToString() == "image/png"))
                    {
                        FileUpload1.SaveAs(Server.MapPath(".") + "/comprobantes/" + FileUpload1.FileName);
                        LblEstado.Text = "Archivo <b>"+ FileUpload1.FileName+"</b> subido";
                    }
                    else if (FileUpload1.FileName == "")
                    {
                        LblEstado.Text = "Debe subir un archivo";
                    }
                    else
                    {
                        LblEstado.Text = "El archivo debe pesar menos de 2 MB";
                    }
                }
                    
            }
            catch (Exception ex)
            {
                LblEstado.Text = ex.Message;
            }
        }
    }
}