using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Aleatorio_Covid_19_Mendoza_Fabian
{
    class Inicio
    {
        Random aleatorio = new Random();

        public int Sortear() {

            return aleatorio.Next(0, 9);
        }

        public void Solicitar_hisopado() {

            Hisopado formHisopado = new Hisopado();

            formHisopado.Show();
        }

        public void Mostrar_salida()
        {

            Salida formSalida = new Salida();

            formSalida.Show();
        }

        public void Mostrar_formulario()
        {

            Formulario formFormulario = new Formulario();

            formFormulario.Show();
        }



    }
}
