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
    [Serializable]

    public partial class Vuelo : Form
    {
        List<Universal> listaVuelos = new List<Universal>();
        string viajeson;

        public Vuelo(ref List<Universal> listaVuelos)
        {
            this.listaVuelos = listaVuelos;
            InitializeComponent();
            CenterToParent();
            foreach(Universal v in listaVuelos)
            {
                seleccionVuelo.Items.Add(v.ToString());
            }
        }
        
        
       public Vuelo() { }


        private void aceptar_Click(object sender, EventArgs e)
        {
            if(seleccionVuelo.SelectedIndex>=0) //universal es Vuelo
            {
                Universal v = listaVuelos[seleccionVuelo.SelectedIndex];
                viajeson = seleccionVuelo.Text.ToString();
                v.vuelo = viajeson;
                DatosPersonales datos = new DatosPersonales(ref v);
                datos.vuelo = viajeson;
                datos.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione un vuelo");
            }

        }

        private void seleccionVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public override string ToString()
        {
            return viajeson;
        }


    }
}
