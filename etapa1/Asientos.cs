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
    public partial class Asientos : Form
    {
        string RutaVuelo;
        List<Button> listaBotones = new List<Button>();
        Button b;
        Universal v;
        List<int> asientoTemporal = new List<int>();

        public void SetRutaVuelo(string r)
        {
            RutaVuelo = r;
        }
        public Asientos()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public Asientos(ref Universal v)
        {
            this.v = v;
            int k =1;
            for (int i=0; i<5; i++)
            {
                for(int j=0;j<4;j++)
                {
                    int x = 120 + 25 * j;
                    int y = 190 + 25 * i;

                    if(x>=160){ x += 8; }
                    b = new Button();
                    b.Text = i.ToString();
                    this.b.Location = new System.Drawing.Point(x, y);
                    this.b.Name = "botonAsiento";
                    this.b.Size = new System.Drawing.Size(28, 25);
                    this.b.TabIndex = 3;
                    this.b.Text = k.ToString();
                    this.b.UseVisualStyleBackColor = true;
                    if(v.getAsientoOcupado(k-1)==true)
                    {
                        this.b.BackColor = Color.Red;
                    }
                    else
                    {
                        this.b.BackColor = Color.Green;
                    }
                    b.Click += new System.EventHandler(botonAsiento_Click);
                    //Console.WriteLine("x: " + x + " y: " + y);
                    listaBotones.Add(b);
                    this.Controls.Add(listaBotones[k-1]);
                    k++;
                }
            }

            InitializeComponent();
            CenterToScreen();
        }

        private void botonAsiento_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int num = Convert.ToInt32(b.Text)-1;
            int last = 0;
            bool clickeado = false;

            if(v.getAsientoOcupado(num)==true)
            {
                MessageBox.Show("El asiento que selecciono esta ocupado");
            }
            else if(clickeado)
            {
                foreach(Button btn in listaBotones)
                {
                    if (Convert.ToInt32(btn.Text) - 1 == num)
                    {
                        btn.BackColor = Color.Green;
                    }
                }
                   
                v.AO.Clear();
                asientoTemporal.Clear();
                v.confirmable = false;
                clickeado = false;

                if(!clickeado)
                {
                    b.BackColor = Color.Blue;
                    v.confirmable = true;
                    v.AO.Add(num);
                    asientoTemporal.Add(num);
                    v.setNumeroAsiento(num);
                    last = num;
                    clickeado = true;
                }
            }
            else
            {
                b.BackColor = Color.Blue;
                v.confirmable = true;
                v.AO.Add(num);
                asientoTemporal.Add(num);
                v.setNumeroAsiento(num);
                last = num;
                clickeado = true;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            foreach (int element in asientoTemporal)
            {
                v.setAsientoOcupado(false, element);
                v.setAsientosDisponibles(v.getAsientos() + 1);
            }
            v.AO.Clear();
            asientoTemporal.Clear();
            v.confirmable = false;

            this.Close(); 
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            //v.setAsientosDisponibles(v.getAsientos() - 1);
            Close();
            //tener un restador en datos para confirmar y que lo reste    
        }

    }
}
