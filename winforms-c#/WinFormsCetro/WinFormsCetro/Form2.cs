using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCetro
{
    public partial class Form2 : Form
    {
        int[] vectoratributos = new int[5];
        public Form2()
        {
            InitializeComponent();
        }

        //Para validar solo numeros
        /*public void validarNumericos()
        {
            string pal;
            pal = txtFuerza.Text;
            for (int x = 0; x < pal.Length; x++)
            {
                if (pal[x] >= '0' && pal[x] <= '9')
                {

                }
                else
                {
                    txtFuerza.Focus();
                    txtFuerza.Text = "";
                }
            }
        }*/
        public bool superatributos(int[] vectoratributos)
        {
            int contador = 0;

            for (int i = 0; i < 5; i++)
            {
                if (vectoratributos[i] > 8)
                {
                    contador = contador + 1;
                }
            }
            if (contador > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool controlarRango(int[] vectoratributos)
        {
            int contador = 0;

            for (int i = 0; i < 5; i++)
            {
                if (vectoratributos[i] > 10 || vectoratributos[i] < 0)
                {
                    contador = 1;
                    break;
                }
            }
            if (contador == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool controlarNumeroVacio(TextBox txt1,TextBox txt2,TextBox txt3, TextBox txt4, TextBox txt5)
        {
            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "" || txt5.Text == "")
            {
                return true;
            }    
            else
            {
                return false;
            }
        }
        public bool controlarTextoVacio(TextBox txtBox)
        {
            
            if (txtBox.Text == "")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            bool miB1, miB2, miB3=true, miB4=true;
        
            miB1 = controlarTextoVacio(txtNombre);
            miB2 = controlarNumeroVacio(txtFuerza,txtValor,txtIngenio,txtInteligencia,txtDedicacion);
            

            if (miB1)
            {
                MessageBox.Show("Debes Ingresar un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();     
            }
            if (miB2)
            {
                MessageBox.Show("Debes completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!miB1 & !miB2)
            {
                vectoratributos[0] = Convert.ToInt32(txtFuerza.Text);
                vectoratributos[1] = Convert.ToInt32(txtValor.Text);
                vectoratributos[2] = Convert.ToInt32(txtIngenio.Text);
                vectoratributos[3] = Convert.ToInt32(txtInteligencia.Text);
                vectoratributos[4] = Convert.ToInt32(txtDedicacion.Text);
                miB3 = controlarRango(vectoratributos);
                miB4 = superatributos(vectoratributos);
                if (miB3)
                {
                    MessageBox.Show("Solo se permiten numeros entre 0 y 10", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFuerza.Focus();
                    txtFuerza.Text = "";
                    txtValor.Text = "";
                    txtInteligencia.Text = "";
                    txtIngenio.Text = "";
                    txtDedicacion.Text = "";
                }
                if (miB4)
                {
                    MessageBox.Show("No puede haber más de dos Superatributos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFuerza.Focus();
                    txtFuerza.Text = "";
                    txtValor.Text = "";
                    txtInteligencia.Text = "";
                    txtIngenio.Text = "";
                    txtDedicacion.Text = "";
                }
            }

            while (!miB1 & !miB2 & !miB3 & !miB4)
            {
                if (Convert.ToInt32(txtFuerza.Text) > 8 && Convert.ToInt32(txtValor.Text) > 8 && Convert.ToInt32(txtIngenio.Text) < 5)
                {
                    lblNombre.Text = txtNombre.Text;
                    lblNombre.Visible = true;
                    lblPerteneces.Visible = true;
                    lblCasa.Text = "Logicus";
                    lblCasa.Visible = true;
                    txtHistoria.Visible = true;
                    txtHistoria.Text = "Los alumnos que pertenecen a Logicus son descritos como valientes y caballerosos, cómo lo dice el Cetro en su canción: “Puedes pertenecer a Logicus, donde habitan los valientes.Su osadía, temple y caballerosidad ponen aparte a los de Logicus”. Los colores de esta casa son el rojo y el dorado, mientras su animal es el león.";
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;

                }
                else
                {
                    if (Convert.ToInt32(txtInteligencia.Text) > 8 && Convert.ToInt32(txtIngenio.Text) > 8)
                    {
                        lblNombre.Text = txtNombre.Text;
                        lblNombre.Visible = true;
                        lblPerteneces.Visible = true;
                        lblCasa.Text = "Creativus";
                        lblCasa.Visible = true;
                        txtHistoria.Visible = true;
                        txtHistoria.Text = "En Creativus se hallan los alumnos más motivados al estudio. Las características de estacasa son la inteligencia, la sabiduría y el aprendizaje, son bastante competitivos cuando se trata de lo académico. El águila es el animal de esta casa y sus colores son el azul y el bronce";
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                    }
                    else
                    {
                        if (Convert.ToInt32(txtInteligencia.Text) > 5 && Convert.ToInt32(txtInteligencia.Text) < 8 && Convert.ToInt32(txtIngenio.Text) > 8)
                        {
                            lblNombre.Text = txtNombre.Text;
                            lblNombre.Visible = true;
                            lblPerteneces.Visible = true;
                            lblCasa.Text = "Innovus";
                            lblCasa.Visible = true;
                            txtHistoria.Visible = true;
                            txtHistoria.Text = "Innovus se caracteriza por tener alumnos ambiciosos e ingeniosos que harían lo necesario para cumplir con sus objetivos. Es bien conocida la rivalidad que hay entre esta casa y Logicus. Sus colores son el verde y el plata, siendo su animal la serpiente";
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = true;
                            pictureBox4.Visible = false;
                        }
                        else
                        {
                            lblNombre.Text = txtNombre.Text;
                            lblNombre.Visible = true;
                            lblPerteneces.Visible = true;
                            lblCasa.Text = "Inventus";
                            lblCasa.Visible = true;
                            txtHistoria.Visible = true;
                            txtHistoria.Text = "Inventus con los colores amarillo y negro, y cuyo animal es el tejón. Es la casa más inclusiva de las cuatro, ya que su fundadora aceptaba a todo estudiante, cómo lo dice el propio Cetro: “La querida Inventus, ella tomó a los demás y les enseñó todo lo que sabía”. Sus estudiantes se caracterizan por ser trabajadores, leales, amigables y honestos";
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = true;
                        }
                    }
                }
                btnSeleccionar.Enabled = false;
                btnReset.Enabled = true;
                miB1 = true;
            }
        }
        
        private void BtnReset_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            txtHistoria.Visible = false;
            lblNombre.Visible = false;
            lblPerteneces.Visible = false;
            lblCasa.Visible = false;
            txtFuerza.Text = "";
            txtValor.Text = "";
            txtInteligencia.Text = "";
            txtIngenio.Text = "";
            txtDedicacion.Text = "";
            txtNombre.Text = "";
            btnSeleccionar.Enabled = true;
            btnReset.Enabled = false;
        }

      
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtFuerza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtInteligencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtIngenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtDedicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
    }
}
