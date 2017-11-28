using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace etapa1
{

    public partial class adminPasajeros : Form
    {
        List<Universal> listaVuelos;
        public adminPasajeros(ref List<Universal> listaVuelos)
        {
            this.listaVuelos = listaVuelos;
            InitializeComponent();
            CenterToParent();
            actualizarListView();
        }

        private void actualizarListViewNombre()
        {
            ordenamientoPasajero listaP = new ordenamientoPasajero();
            foreach (Universal v in listaVuelos)
            {
                foreach (Pasajero p in v.getListaPasajeros())
                {
                    listaP.Add(p);
                }
            }
            if (listaP.Count > 0)
                listaP.quicksortNombre(0, listaP.Count - 1);

            foreach (Pasajero p in listaP)
            {
                string[] arrString = new string[3];
                arrString[0] = p.getNombreYap();
                arrString[1] = p.getRuta();
                arrString[2] = p.getAsiento().ToString();

                ListViewItem item = new ListViewItem(arrString);
                ListViewPasajeros.Items.Add(item);
            }
        }

        private void actualizarListViewVuelo()
        {
            ordenamientoPasajero listaP = new ordenamientoPasajero();
            foreach (Universal v in listaVuelos)
            {
                foreach (Pasajero p in v.getListaPasajeros())
                {
                    listaP.Add(p);
                }
            }
            if (listaP.Count > 0)
                listaP.quicksortVuelos(0, listaP.Count - 1);

            foreach (Pasajero p in listaP)
            {
                string[] arrString = new string[3];
                arrString[0] = p.getNombreYap();
                arrString[1] = p.getRuta();
                arrString[2] = p.getAsiento().ToString();

                ListViewItem item = new ListViewItem(arrString);
                ListViewPasajeros.Items.Add(item);
            }
        }

        private void actualizarListViewAsientos()
        {
            ordenamientoPasajero listaP = new ordenamientoPasajero();
            foreach (Universal v in listaVuelos)
            {
                foreach (Pasajero p in v.getListaPasajeros())
                {
                    listaP.Add(p);
                }
            }
            if (listaP.Count > 0)
                listaP.quicksortAsientos(0, listaP.Count - 1);

            foreach (Pasajero p in listaP)
            {
                string[] arrString = new string[3];
                arrString[0] = p.getNombreYap();
                arrString[1] = p.getRuta();
                arrString[2] = p.getAsiento().ToString();

                ListViewItem item = new ListViewItem(arrString);
                ListViewPasajeros.Items.Add(item);
            }
        }

        private void actualizarListView()
        {
            foreach (Universal v in listaVuelos)
            {
                for (int i = 0; i < v.getPasajerosCount(); i++)
                {
                    string[] arrString = new string[3];
                    arrString[0] = v.getPasajero(i).getNombreYap();
                    arrString[1] = v.ToString();
                    arrString[2] = v.getPasajero(i).getAsiento().ToString();

                    ListViewItem item = new ListViewItem(arrString);
                    ListViewPasajeros.Items.Add(item);
                }
            }
        }

        private void actualizarListView(ref List<Pasajero> listaPasajeros)
        {
            ordenamientoPasajero listaP = new ordenamientoPasajero();
            foreach (Pasajero p in listaPasajeros)
            {
                listaP.Add(p);
            }
            foreach (Pasajero p in listaP)
            {
                string[] arrString = new string[3];
                arrString[0] = p.getNombreYap();
                arrString[1] = p.getRuta();
                arrString[2] = p.getAsiento().ToString();

                ListViewItem item = new ListViewItem(arrString);
                ListViewPasajeros.Items.Add(item);
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void eliminarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                string nombrePasajero = ListViewPasajeros.SelectedItems[0].Text.ToString();

                List<Pasajero> lp = new List<Pasajero>();

                foreach (Universal v in listaVuelos)
                {
                    for (int i = 0; i < v.getPasajerosCount(); ++i)
                    {
                        Pasajero p = v.getPasajero(i);

                        if (nombrePasajero == p.getNombreYap())
                        {
                            int num_asiento;
                            num_asiento = p.getAsiento() - 1;
                            v.setAsientoOcupado(false, num_asiento);
                            v.setAsientosDisponibles(v.getAsientos() + 1);
                            v.eliminarPasajero(i);
                            ListViewPasajeros.Items.Clear();
                            actualizarListView();
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine(error);
                MessageBox.Show("Seleccione un elemento");
            }
        }

        private void buscarPasajeros_TextChanged(object sender, EventArgs e)
        {
            ListViewPasajeros.Items.Clear();
            List<Pasajero> lp = new List<Pasajero>();

            if (comboFiltroPasajeros.Text.ToString() == "Nombre")
            {
                foreach (Universal v in listaVuelos)
                {
                    for (int i = 0; i < v.getPasajerosCount(); ++i)
                    {
                        Pasajero p = v.getPasajero(i);
                        bool iguales = false;
                        string nombre = "";
                        string buscable = "";

                        for (int j = 0; j < buscarPasajeros.Text.Length; ++j)
                        {
                            try
                            {
                                if (buscarPasajeros.Text.Length <= p.getNombreYap().Length)
                                {
                                    nombre = nombre + p.getNombreYap()[j];
                                    buscable = buscable + buscarPasajeros.Text[j].ToString().ToUpper();
                                    if (buscable == nombre)
                                    {
                                        iguales = true;
                                    }
                                    else
                                    {
                                        iguales = false;
                                    }
                                }

                            }
                            catch (IndexOutOfRangeException)
                            {
                                MessageBox.Show("Cadena Demasiado Grande");
                                continue;
                            }
                        }
                        if (iguales)
                        {
                            lp.Add(p);
                        }

                    }
                }
                actualizarListView(ref lp);
            }
            else if (comboFiltroPasajeros.Text.ToString() == "Vuelo")
            {
                foreach (Universal v in listaVuelos)
                {
                    for (int i = 0; i < v.getPasajerosCount(); ++i)
                    {
                        Pasajero p = v.getPasajero(i);
                        bool iguales = false;
                        string vuelo = "";
                        string buscable = "";

                        for (int j = 0; j < buscarPasajeros.Text.Length; ++j)
                        {
                            try
                            {
                                if (buscarPasajeros.Text.Length <= p.getNombreYap().Length)
                                {
                                    vuelo = vuelo + p.getRuta()[j];
                                    buscable = buscable + buscarPasajeros.Text[j].ToString().ToUpper();
                                    if (buscable == vuelo)
                                    {
                                        iguales = true;
                                    }
                                    else
                                    {
                                        iguales = false;
                                    }
                                }

                            }
                            catch (IndexOutOfRangeException)
                            {
                                MessageBox.Show("Cadena Demasiado Grande");
                                continue;
                            }
                        }
                        if (iguales)
                        {
                            lp.Add(p);
                        }

                    }
                }
                actualizarListView(ref lp);
            }
            else if (comboFiltroPasajeros.Text.ToString() == "Asiento")
            {
                foreach (Universal v in listaVuelos)
                {
                    for (int i = 0; i < v.getPasajerosCount(); ++i)
                    {
                        Pasajero p = v.getPasajero(i);
                        bool iguales = false;
                        int asiento = 0;
                        int buscable = 0;
                        try
                        {
                            buscable = Convert.ToInt32(buscarPasajeros.Text);
                        }
                        catch (FormatException)
                        {
                            continue;
                        }

                        asiento = p.getAsiento();
                        if (buscable == asiento)
                        {
                            iguales = true;
                        }
                        else
                        {
                            iguales = false;
                        }

                        if (iguales)
                        {
                            lp.Add(p);
                        }
                    }
                }
                actualizarListView(ref lp);
            }
            else
            {
                foreach (Universal v in listaVuelos)
                {
                    for (int i = 0; i < v.getPasajerosCount(); ++i)
                    {
                        Pasajero p = v.getPasajero(i);
                        bool iguales = false;
                        string nombre = "";
                        string buscable = "";

                        for (int j = 0; j < buscarPasajeros.Text.Length; ++j)
                        {
                            try
                            {
                                if (buscarPasajeros.Text.Length <= p.getNombreYap().Length)
                                {
                                    nombre = nombre + p.getNombreYap()[j];
                                    buscable = buscable + buscarPasajeros.Text[j].ToString().ToUpper();
                                    if (buscable == nombre)
                                    {
                                        iguales = true;
                                    }
                                    else
                                    {
                                        iguales = false;
                                    }
                                }

                            }
                            catch (IndexOutOfRangeException)
                            {
                                MessageBox.Show("Cadena Demasiado Grande");
                                continue;
                            }
                        }
                        if (iguales)
                        {
                            lp.Add(p);
                        }

                    }
                }
                actualizarListView(ref lp);
            }

            if (buscarPasajeros.Text.ToString() == "")
            {
                actualizarListView();
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPasajeros.SelectedIndex >= 0)
            {
                if (comboPasajeros.Text.ToString() == "Nombre")
                {
                    ListViewPasajeros.Items.Clear();
                    actualizarListViewNombre();
                }
                if (comboPasajeros.Text.ToString() == "Vuelo")
                {
                    ListViewPasajeros.Items.Clear();
                    actualizarListViewVuelo();
                }
                if (comboPasajeros.Text.ToString() == "Asiento")
                {
                    ListViewPasajeros.Items.Clear();
                    actualizarListViewAsientos();
                }
            }
        }

        private void comboFiltroPasajeros_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
