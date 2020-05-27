using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aleatorio_Covid_19_Mendoza_Fabian
{
    class Estadisticas
    {
        public string Obtener_datos()
        {
            string url = "https://profesorcarlosrodriguez.com/json/estadistica.php";

            string cadenaJSON = (new WebClient()).DownloadString(url);

            return cadenaJSON;
        }
    }
}
