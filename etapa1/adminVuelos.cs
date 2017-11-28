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
    public partial class adminVuelos : Form
    {
        Grafo g;
        List<Universal> listaVuelos;
        public adminVuelos(ref List<Universal> listaVuelos, ref Grafo g)
        {
            this.g = g;
            this.listaVuelos = listaVuelos;
            InitializeComponent();
            CenterToParent();
            actualizarListView();
        }


        private void actualizarListView()
        {
            foreach (Universal v in listaVuelos)
            {
                string[] arrString = new string[4];
                arrString[0] = v.getOrigen().ToString();
                arrString[1] = v.getDestino().ToString(); ;
                arrString[2] = "$" + v.getCosto().ToString();
                arrString[3] = v.getTiempo().ToString() + " minutos";

                ListViewItem item = new ListViewItem(arrString);
                ListViewVuelo.Items.Add(item);
            }
        }

        //ordenados de origen | destino | costo
        private void actualizarListViewOrigen()
        {
            ordenamientoVuelos listaOrdenable = new ordenamientoVuelos();
            foreach (Universal v in listaVuelos)
            {
                listaOrdenable.Add(v);
            }
            if (listaOrdenable.Count > 0)
            {
                listaOrdenable.quicksortOrigen(0, listaOrdenable.Count - 1);
            }

            foreach (Universal v in listaOrdenable)
            {
                string[] arrString = new string[4];
                arrString[0] = v.getOrigen().ToString();
                arrString[1] = v.getDestino().ToString(); ;
                arrString[2] = "$" + v.getCosto().ToString();
                arrString[3] = v.getTiempo().ToString() + " minutos";

                ListViewItem item = new ListViewItem(arrString);
                ListViewVuelo.Items.Add(item);
            }
        }

        private void actualizarListViewDestino()
        {
            ordenamientoVuelos listaOrdenable = new ordenamientoVuelos();
            foreach (Universal v in listaVuelos)
            {
                listaOrdenable.Add(v);
            }
            if (listaOrdenable.Count > 0)
            {
                listaOrdenable.quicksortDestino(0, listaOrdenable.Count - 1);
            }

            foreach (Universal v in listaOrdenable)
            {
                string[] arrString = new string[4];
                arrString[0] = v.getOrigen().ToString();
                arrString[1] = v.getDestino().ToString(); ;
                arrString[2] = "$" + v.getCosto().ToString();
                arrString[3] = v.getTiempo().ToString() + " minutos";

                ListViewItem item = new ListViewItem(arrString);
                ListViewVuelo.Items.Add(item);
            }
        }

        private void actualizarListViewCosto()
        {
            ordenamientoVuelos listaOrdenable = new ordenamientoVuelos();
            foreach (Universal v in listaVuelos)
            {
                listaOrdenable.Add(v);
            }
            if (listaOrdenable.Count > 0)
            {
                listaOrdenable.quicksortCosto(0, listaOrdenable.Count - 1);
            }

            foreach (Universal v in listaOrdenable)
            {
                string[] arrString = new string[4];
                arrString[0] = v.getOrigen().ToString();
                arrString[1] = v.getDestino().ToString(); ;
                arrString[2] = "$" + v.getCosto().ToString();
                arrString[3] = v.getTiempo().ToString() + " minutos";

                ListViewItem item = new ListViewItem(arrString);
                ListViewVuelo.Items.Add(item);
            }
        }

        private void actualizarListView(ref List<Universal> lv)
        {
            foreach (Universal v in lv)
            {
                string[] arrString = new string[4];
                arrString[0] = v.getOrigen().ToString();
                arrString[1] = v.getDestino().ToString(); ;
                arrString[2] = "$" + v.getCosto().ToString();
                arrString[3] = v.getTiempo().ToString() + " minutos";

                ListViewItem item = new ListViewItem(arrString);
                ListViewVuelo.Items.Add(item);
            }
        }

        private void adminVuelos_Load(object sender, EventArgs e)
        {
        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
            if (comboOrigen.Text != "" && comboDestino.Text != "" &&
               textBoxTiempo.Text != "" && textBoxCosto.Text != ""
               && comboOrigen.Text != comboDestino.Text)
            {
                string o = comboOrigen.Text.ToString();
                string d = comboDestino.Text.ToString();
                string ruta = "SK1" + o + d;
                bool agregable = true;

                foreach (Universal v in listaVuelos)
                {
                    if (ruta == v.ToString())
                    {
                        agregable = false;
                        break;
                    }
                }

                if (agregable)
                {
                    char origen = Convert.ToChar(comboOrigen.Text.ToString());
                    char destino = Convert.ToChar(comboDestino.Text.ToString());
                    int tiempo = Convert.ToInt32(textBoxTiempo.Text.ToString());
                    int costo = Convert.ToInt32(textBoxCosto.Text.ToString());
                    Universal nuevo = new Universal(origen, destino, tiempo, costo);
                    listaVuelos.Add(nuevo);
                    g.insertarVertice(origen);
                    g.insertarVertice(destino);
                    g.insertarArista(costo, tiempo, origen, destino);
                    ListViewVuelo.Items.Clear();
                    actualizarListView();
                    MessageBox.Show("Vuelo SK1" + comboOrigen.Text + comboDestino.Text + " Agregado Correctamente");
                }
                else
                {
                    MessageBox.Show("El Vuelo que desea agregar ya existe.");
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos y verifique los datos.");
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    string s = ListViewVuelo.FocusedItem.SubItems[0].Text.ToString();
                    string s2 = ListViewVuelo.FocusedItem.SubItems[1].Text.ToString();
                    string seleccionado = "SK1" + s + s2;
                    int cont = 0;
                    foreach (Universal v in listaVuelos)
                    {
                        if (seleccionado == v.ToString())
                        {
                            listaVuelos.RemoveAt(cont);
                            g.eliminarVertice(Convert.ToChar(s)); //verificar si sigue siendo desitino
                            g.eliminarVertice(Convert.ToChar(s2));
                            g.eliminarArista(Convert.ToChar(s), Convert.ToChar(s2));
                            ListViewVuelo.Items.Clear();
                            actualizarListView();
                            MessageBox.Show("Vuelo Eliminado Correctamente.");
                            textBoxBuscar.Clear();
                            break;
                        }
                        cont++;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un elemento");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seleccione un elemento");
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            ListViewVuelo.Items.Clear();
            List<Universal> lv = new List<Universal>();
            int cont = 0;

            if (comboFiltroVuelos.Text.ToString() == "Origen")
            {
                foreach (Universal v in listaVuelos)
                {
                    string origen = textBoxBuscar.Text.ToString();
                    string ruta = "";
                    bool iguales = false;

                    origen = "SK1" + origen.ToUpper();
                    ruta = "SK1" + v.ToString()[3];

                    if (origen == ruta)
                    {
                        iguales = true;
                    }
                    else
                    {
                        iguales = false;
                    }
                    if (iguales)
                    {
                        lv.Add(listaVuelos[cont]);
                    }
                    cont++;
                }

                actualizarListView(ref lv);
                if (textBoxBuscar.Text.ToString() == "")
                {
                    actualizarListView();
                }
            }

            else if (comboFiltroVuelos.Text.ToString() == "Destino")
            {
                foreach (Universal v in listaVuelos)
                {
                    string destino = textBoxBuscar.Text.ToString();
                    string ruta = "";
                    bool iguales = false;

                    destino = destino.ToUpper();
                    ruta = v.ToString()[4].ToString();

                    if (destino == ruta)
                    {
                        iguales = true;
                    }
                    else
                    {
                        iguales = false;
                    }
                    if (iguales)
                    {
                        lv.Add(listaVuelos[cont]);
                    }
                    cont++;
                }

                actualizarListView(ref lv);
                if (textBoxBuscar.Text.ToString() == "")
                {
                    actualizarListView();
                }
            }

            else
            {
                foreach (Universal v in listaVuelos)
                {
                    string buscable = "";
                    string ruta = "";
                    bool iguales = false;

                    for (int j = 0; j < textBoxBuscar.Text.Length; ++j)
                    {
                        buscable = buscable + textBoxBuscar.Text[j].ToString().ToUpper();
                        ruta = ruta + v.ToString()[j];

                        if (buscable == ruta)
                        {
                            iguales = true;
                        }
                        else
                        {
                            iguales = false;
                        }
                    }
                    if (iguales)
                    {
                        lv.Add(listaVuelos[cont]);
                    }
                    cont++;
                }
                actualizarListView(ref lv);
                if (textBoxBuscar.Text.ToString() == "")
                {
                    actualizarListView();
                }
            }
        }

        private void ListViewVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewVuelo_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //string m = ListViewVuelo.Columns[i].ToString();
            //MessageBox.Show("Hola prro " + c);
        }

        private void comboVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVuelo.SelectedIndex >= 0)
            {
                if (comboVuelo.Text.ToString() == "Origen")
                {
                    ListViewVuelo.Items.Clear();
                    actualizarListViewOrigen();
                }
                if (comboVuelo.Text.ToString() == "Destino")
                {
                    ListViewVuelo.Items.Clear();
                    actualizarListViewDestino();
                }
                if (comboVuelo.Text.ToString() == "Costo")
                {
                    ListViewVuelo.Items.Clear();
                    actualizarListViewCosto();
                }
            }
        }

        private void comboFiltroVuelos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = Enabled;
        }
    }
}
