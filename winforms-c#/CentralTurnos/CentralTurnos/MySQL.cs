using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTurnos
{
    class MySQL
    {

        public string Get_Query_Turno(int nrocliente) 
        {
            string query;
            if (nrocliente == 1)
            {
                query = "SELECT turno FROM clientes ORDER BY turno DESC LIMIT 1";
            }
            else { 
                query = "SELECT turno FROM publico ORDER BY turno DESC LIMIT 1";
            }

            return query;
        }
        public string Get_Query_Insert(int nrocliente, int numero)
        {
            string query;
     
            if (nrocliente == 1)
            {
                query = "INSERT INTO clientes(turno,atendido) VALUES(" + numero + ",'no')";
            }
            else
            {
                query = "INSERT INTO publico(turno,atendido) VALUES(" + numero + ",'no')";
            }

            return query;
        }

        public void Alta_Turno(RichTextBox pantalla, int cliente) 
        {
            int numero;

            string MyConnection2 = "datasource=localhost;database=turnero;port=3307;username=root;password=usbw";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            MyConn2.Open();

            String Query = Get_Query_Turno(cliente);

            MySqlCommand MyCommandConsulta = new MySqlCommand(Query, MyConn2);

            MySqlDataReader registro = MyCommandConsulta.ExecuteReader();

            if (registro.Read())
            {

                numero = Convert.ToInt32(registro["turno"].ToString()) + 1;

            }
            else
            {

                numero = 1;

            }

            MyConn2.Close();

            MyConn2.Open();


            Query = Get_Query_Insert(cliente,numero) ;

            MySqlCommand MyCommandInsert = new MySqlCommand(Query, MyConn2);

            MyCommandInsert.ExecuteNonQuery();


            pantalla.Text = "Turno \n" + numero;

            MyConn2.Close();

        }


    }
}