using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace etapa1
{
    public partial class Form1 : Form
    {
        List<Universal> listaVuelos = new List<Universal>();
        Grafo g;
        public Form1(ref List<Universal> listaVuelos, Grafo g)
        {
            this.listaVuelos = listaVuelos;
            this.g = g;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vuelo v = new Vuelo(ref listaVuelos);
            v.ShowDialog();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                SoundPlayer allhau = new SoundPlayer(@"Allahu.wav");
                allhau.Play();
                System.Threading.Thread.Sleep(1500);
                Application.Exit();
            }

        }

        private void Pasajeros_Click(object sender, EventArgs e)
        {
            adminPasajeros menuPasajeros = new adminPasajeros(ref listaVuelos);
            menuPasajeros.ShowDialog();
        }

        private void vuelos_Click(object sender, EventArgs e)
        {
            adminVuelos menuVuelos = new adminVuelos(ref listaVuelos, ref g);
            menuVuelos.ShowDialog();
        }

        /*ARREGLAR*/
        private void grafo_Click(object sender, EventArgs e)
        {
            //ventanaGrafo grafo = new ventanaGrafo(g);
            //grafo.ShowDialog();
            FormGrafo grafo = new FormGrafo(ref listaVuelos);
            grafo.ShowDialog();

        }
    }
}
