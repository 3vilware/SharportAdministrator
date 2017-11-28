using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etapa1
{
    public partial class DatosPersonales : Form
    {
        public string vuelo;
        string name, lastname, age;
        int asientoSeleccionado;
        Universal v;

        public DatosPersonales(ref Universal v)
        {
            this.v = v; 
            InitializeComponent();
            this.CenterToScreen();
        }

        public DatosPersonales()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void atras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aceptardatos_Click(object sender, EventArgs e)
        {
            if(nombre.Text!="" && apellido1.Text!="" && apellido2.Text!="" 
                && edad.Text!="" && v.confirmable) 
            {
                name = this.nombre.Text.ToString().ToUpper();
                lastname = this.apellido1.Text.ToString().ToUpper();
                age = this.edad.Text.ToString();
                int ageint;
                ageint = Convert.ToInt32(age);
                asientoSeleccionado = v.getNumeroAsiento()+1;
                vuelo = v.ToString(); //tostring sobrecargado

                Pasajero p = new Pasajero(name, lastname, ageint, 
                                          asientoSeleccionado, vuelo);
                v.setPasajero(p);

                foreach (int num_asiento in v.AO)
                {
                    v.setAsientoOcupado(true, num_asiento);
                    v.setAsientosDisponibles(v.getAsientos() - 1);
                }
                v.confirmable = false;


                Close();
            }
            else
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS Y SELECCIONE UN ASIENTO");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asientos asientos = new Asientos(ref v);
            asientos.SetRutaVuelo(vuelo);
            this.Hide();
            asientos.ShowDialog();
            this.Show();
        }

        private void DatosPersonales_Load(object sender, EventArgs e)
        {

        }

        private void DatosPersonales_Shown(object sender, EventArgs e)
        {
            rutaVuelo.Text = vuelo;
            numeroasientos.Text = v.getAsientos().ToString();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
        }

        private void rutaVuelo_Click(object sender, EventArgs e)
        {
        }
    }
}
