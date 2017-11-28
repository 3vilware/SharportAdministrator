using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace etapa1
{
    public partial class FormGrafo : Form
    {
        Grafo graph;
        List<Universal> vuelosActuales = new List<Universal>();
        List<Universal> ListaK = new List<Universal>();
        List<Point> lp = new List<Point>();
        List<Arista> arm = new List<Arista>();

        public void actualizaLista()
        {
            listBoxVertices.Items.Clear();
            comboOrigenes.Items.Clear();
            for (int i = 0; i < graph.Count; i++)
            {
                listBoxVertices.Items.Add(graph[i].getOrigen());
                //if(graph[i].getListaAristas().Count>0)
                comboOrigenes.Items.Add(graph[i].getOrigen());
            }
        }
        public void letras()
        {
            for (int i = 0; i < graph.Count; i++)
            {
                Font fuente = new Font("Arial Bold", 12);
                SolidBrush brocha = new SolidBrush(Color.Red);
                panelGrafo.CreateGraphics().DrawString(graph[i].getOrigen().ToString(), 
                    fuente, brocha, Convert.ToUInt32(graph[i].getX() - 8), Convert.ToUInt32(graph[i].getY() - 10));
            }
        }

        public void pesos()
        {
            for (int i = 0; i < graph.Count; i++)
            {
                for (int j = 0; j < graph[i].getListaAristas().Count; j++)
                {
                    Font fuente = new Font("Arial Bold", 12);
                    SolidBrush wea = new SolidBrush(Color.Red);
                    int newX = (graph[i].getX() + graph[i].getListaAristas()[j].getX()) / 2;
                    int newY = (graph[i].getY() + graph[i].getListaAristas()[j].getY()) / 2;
                    panelGrafo.CreateGraphics().DrawString(graph[i].getListaAristas()[j].getCosto().ToString(), fuente, wea, newX, newY);
                }
            }
        }

        public FormGrafo(ref List<Universal> listavuelos)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.vuelosActuales = listavuelos;
            graph = new Grafo(vuelosActuales);
        }

        private void dibuja()
        {
            panelGrafo.CreateGraphics().Clear(Color.GreenYellow);
            Pen pen1 = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Orange, 3);
            AdjustableArrowCap flecha = new AdjustableArrowCap(8, 8);
            pen1.CustomEndCap = flecha;
            double a, r;
            int x, y;
            for (int i = 0; i < graph.Count; i++)
            {
                r = (panelGrafo.Height - 20) / 2;
                a = 2 * Math.PI / graph.Count;
                x = Convert.ToInt32(Math.Cos(i * a) * r + r + 12);
                y = Convert.ToInt32(Math.Sin(i * a) * r + r + 12);
                panelGrafo.CreateGraphics().DrawEllipse(pen2, x - 12, y - 12, 24, 24);
                graph[i].setX(x);
                graph[i].setY(y);
            }
            for (int i = 0; i < graph.Count; i++)
            {
                for (int j = 0; j < graph[i].getListaAristas().Count; j++)
                {
                    for (int h = 0; h < graph.Count; h++)
                    {
                        if (graph[i].getListaAristas()[j].getDestino() == graph[h].getOrigen())
                        {
                            graph[i].getListaAristas()[j].setX(graph[h].getX());
                            graph[i].getListaAristas()[j].setY(graph[h].getY());
                        }
                    }
                }
            }
            int x1, x2, y1, y2;
            for (int i = 0; i < graph.Count; i++)
            {
                x1 = graph[i].getX();
                y1 = graph[i].getY();
                for (int g = 0; g < graph[i].getListaAristas().Count; g++)
                {
                    x2 = graph[i].getListaAristas()[g].x;
                    y2 = graph[i].getListaAristas()[g].y;
                    panelGrafo.CreateGraphics().DrawLine(pen1, x1, y1, x2, y2);
                }
            }
            letras();
            actualizaLista();
        }
        private void buttonGrafo_Click(object sender, EventArgs e)
        {
            dibuja();
        }

        private void panelGrafo_MouseDown(object sender, MouseEventArgs e)
        {
            Pen pen1 = new Pen(Color.Black, 5);
            panelGrafo.CreateGraphics().DrawEllipse(pen1, e.X - 8, e.Y - 8, 16, 16);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //cargar
        private void button1_Click(object sender, EventArgs e)
        {
            dibuja();
            pesos();
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            panelGrafo.CreateGraphics().Clear(Color.GreenYellow);
            char elimV = graph[listBoxVertices.SelectedIndex].getOrigen();
            for (int i = 0; i < vuelosActuales.Count; i++)
            {
                if (elimV == vuelosActuales[i].getOrigen() || elimV == vuelosActuales[i].getDestino())
                {
                    vuelosActuales.Remove(vuelosActuales[i]);
                    i--;
                }
            }
            graph.delete();
            graph = new Grafo(vuelosActuales);
            buttonEliminar.Enabled = false;
            dibuja();
            pesos();
        }

        private void listBoxVertices_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = true;
        }

        private void FormGrafo_Load(object sender, EventArgs e)
        {
            //nada
        }

        private void FormGrafo_Shown(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = false;
            dibuja();
            pesos();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            panelGrafo.CreateGraphics().Clear(Color.GreenYellow);
            Pen pen1 = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Orange, 3);
            AdjustableArrowCap flecha = new AdjustableArrowCap(8, 8);
            pen1.CustomEndCap = flecha;
            double a, r;
            int x, y;
            int cont=0;
            foreach(Point p in lp) //for (int i = 0; i < graph.Count; i++)
            {
                int i = cont;
                r = (panelGrafo.Height - 20) / 2;
                a = 2 * Math.PI / graph.Count;
                x = p.X;
                y = p.Y;
                panelGrafo.CreateGraphics().DrawEllipse(pen2, x - 12, y - 12, 24, 24);
                graph[i].setX(x);
                graph[i].setY(y);
                cont++;
            }
            for (int i = 0; i < graph.Count; i++)
            {
                for (int j = 0; j < graph[i].getListaAristas().Count; j++)
                {
                    for (int h = 0; h < graph.Count; h++)
                    {
                        if (graph[i].getListaAristas()[j].getDestino() == graph[h].getOrigen())
                        {
                            graph[i].getListaAristas()[j].setX(graph[h].getX());
                            graph[i].getListaAristas()[j].setY(graph[h].getY());
                        }
                    }
                }
            }
            int x1, x2, y1, y2;
            for (int i = 0; i < graph.Count; i++)
            {
                x1 = graph[i].getX();
                y1 = graph[i].getY();
                for (int g = 0; g < graph[i].getListaAristas().Count; g++)
                {
                    x2 = graph[i].getListaAristas()[g].x;
                    y2 = graph[i].getListaAristas()[g].y;
                    panelGrafo.CreateGraphics().DrawLine(pen1, x1, y1, x2, y2);
                }
            }
            letras();
            actualizaLista();
            pesos();
        }

        private void panelGrafo_MouseClick(object sender, MouseEventArgs e)
        {
            Pen pen1 = new Pen(Color.Blue, 2);
            Point p = new Point(e.X - 10, e.Y - 10);

            if (lp.Count < graph.Count)
            {
                lp.Add(p);
                panelGrafo.CreateGraphics().DrawEllipse(pen1, p.X - 12, p.Y - 12, 24, 24);
            }
            if (lp.Count == graph.Count)
                printBtn.Enabled = true;
            //MessageBox.Show("Clicks almacenados: " + lp.Count);
        }

        private void Kruskal()
        {
            Color newColor = Color.FromArgb(75, Color.Blue);
            Pen pen1 = new Pen(newColor, 8);

            List<string> ponderacion = new List<string>();
            ordenamientoVuelos listaKrus = new ordenamientoVuelos();
            ordenamientoVuelos vuelosKrus = new ordenamientoVuelos();

            for (int i = 0; i < graph.Count; i++)
            {
                ponderacion.Add(graph[i].getOrigen().ToString());
            }

            for (int i = 0; i < vuelosActuales.Count; i++)
            {
                listaKrus.Add(vuelosActuales[i]);
            }
            listaKrus.quicksortCosto(0, listaKrus.Count() - 1);

            foreach (Universal v in listaKrus)
            {
                Console.WriteLine("Costo: " + v.getCosto());
            }

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            for (int p = 0; p < listaKrus.Count(); p++)
            {
                for (int i = 0; i < ponderacion.Count; i++)
                {
                    if (ponderacion[i].Contains(listaKrus[p].getOrigen().ToString()) && !ponderacion[i].Contains(listaKrus[p].getDestino().ToString()))
                    {
                        for (int h = 0; h < ponderacion.Count; h++)
                        {
                            if (ponderacion[h].Contains(listaKrus[p].getDestino().ToString()) && !ponderacion[h].Contains(listaKrus[p].getOrigen().ToString()) && ponderacion[h].Length == 1)
                            {
                                vuelosKrus.Add(listaKrus[p]);
                                //agregar a aceptados 
                                ponderacion[i] = ponderacion[i] + listaKrus[p].getDestino();
                                ponderacion.Remove(ponderacion[h]);
                                break;
                            }
                            else if (ponderacion[h].Contains(listaKrus[p].getDestino().ToString()) && !ponderacion[h].Contains(listaKrus[p].getOrigen().ToString()) && ponderacion[h].Length > 1)
                            {
                                vuelosKrus.Add(listaKrus[p]);
                                //agregar a aceptados 
                                ponderacion[i] = ponderacion[i] + ponderacion[h];
                                ponderacion.Remove(ponderacion[h]);
                                break;
                            }
                        }
                    }
                }
            }

            int ponderacionTotal = 0;
            for (int i = 0; i < vuelosKrus.Count; i++)
            {
                ponderacionTotal += vuelosKrus[i].getCosto();
                for (int j = 0; j < graph.Count; j++)
                {
                    if (vuelosKrus[i].getOrigen() == graph[j].getOrigen())
                    {
                        x1 = graph[j].getX();
                        y1 = graph[j].getY();
                    }
                    for (int h = 0; h < graph[j].getListaAristas().Count; h++)
                    {
                        if (vuelosKrus[i].getDestino() == graph[j].getListaAristas()[h].getDestino())
                        {
                            x2 = graph[j].getListaAristas()[h].getX();
                            y2 = graph[j].getListaAristas()[h].getY();
                        }
                    }
                }

                vuelosKrus.quicksortCosto(0, vuelosKrus.Count - 1);
                listBoxRecorrido.Items.Clear();
                for (int n = 0; n < vuelosKrus.Count; n++)
                {
                    listBoxRecorrido.Items.Add(vuelosKrus[n].getOrigen().ToString() + vuelosKrus[n].getDestino().ToString());
                }

                panelGrafo.CreateGraphics().DrawLine(pen1, x1, y1, x2, y2);
                letras();
                letreroARM.Text = "Peso total con Kruskal: " + ponderacionTotal;
                letreroARM.Visible = Enabled;
            }
            //vuelosKrus.quicksortCosto(0, listaKrus.Count() - 1);
        }

        private void ordenarAdyacencia(Grafo g)
        {
            Arista aux;
            for (int i = 0; i < g.Count(); ++i)
            {
                for (int j = 0; j < g[i].getListaAristas().Count() - 1; j++)
                {
                    for (int k = 0; k < g[i].getListaAristas().Count() - 1 - j; k++)
                    {
                        if (g[i].getListaAristas()[k].getCosto() > g[i].getListaAristas()[k + 1].getCosto())
                        {
                            aux = g[i].getListaAristas()[k];
                            g[i].getListaAristas()[k] = g[i].getListaAristas()[k + 1];
                            g[i].getListaAristas()[k + 1] = aux;
                        }
                    }
                }
            }

            for (int i = 0; i < g.Count(); ++i)
            {
                for (int j = 0; j < g[i].getListaAristas().Count(); j++)
                {
                    //Console.WriteLine("ady[" + i + "]=" + g[i].getListaAristas()[j].getCosto());
                }
            }
        }

        private void tryPrim()
        {
            listBoxRecorrido.Items.Clear();

            Font letra = new Font("Arial", 10);
            SolidBrush color = new SolidBrush(Color.Black);
            Color newColor = Color.FromArgb(75, Color.Red);
            Pen lapiz = new Pen(newColor, 8);
            int ponderacionTotal = 0;
            //usable
            Vertice aux;
            List<visitado> aceptados = new List<visitado>();
            List<Vertice> aceptadosVertices = new List<Vertice>();
            List<char> visitados = new List<char>();//adyacencias disponibles
            List<char> visitadosAux = new List<char>();//adyacencias disponibles
            List<visitado> listaArcos = new List<visitado>();
            List<visitado> ArcosUsados = new List<visitado>();
            List<visitado> listaArcosDisp = new List<visitado>();
            List<visitado> colaVertices = new List<visitado>();
            bool esDestino;
            bool usada=false, componenteConexaVisitada=false;

            foreach (Vertice v in graph)
            {
                foreach (Arista a in v.getListaAristas())
                {
                    visitado nodo = new visitado(v.getOrigen(), a.getDestino(), a.getCosto());
                    listaArcos.Add(nodo);
                }
            }

            //ordena 
            visitado visitadoAux;
            for (int j = 0; j < listaArcos.Count - 1; j++)
            {
                for (int k = 0; k < listaArcos.Count - 1 - j; k++)
                {
                    if (listaArcos[k].peso > listaArcos[k + 1].peso)
                    {
                        visitadoAux = listaArcos[k];
                        listaArcos[k] = listaArcos[k + 1];
                        listaArcos[k + 1] = visitadoAux;
                    }
                }
            }

            foreach (visitado v in listaArcos)
            {
                Console.WriteLine(v.origen + "->" + v.destino + ": " + v.peso);
                colaVertices.Add(v);
            }

            int cont=0;
            ordenarAdyacencia(graph);
            while (visitados.Count < graph.Count || cont<=2)
            {
                esDestino = true;
                if(visitados.Count==0)
                {
                    foreach (Vertice v in graph)
                    {
                        foreach (Arista a in v.getListaAristas())
                        {
                            if (v.getOrigen() == colaVertices[0].origen && a.getDestino() == colaVertices[0].destino)
                            {
                                visitado nodo = new visitado(v.getOrigen(), a.getDestino(), a.getCosto());
                                if (!aceptados.Contains(nodo))
                                {
                                    if (!visitados.Contains(v.getOrigen()))
                                    {
                                        visitados.Add(v.getOrigen());
                                    }
                                    if (!visitados.Contains(a.getDestino()))
                                    {
                                        visitados.Add(a.getDestino());
                                        esDestino = false;
                                    }

                                    if (!esDestino)
                                    {
                                        aceptados.Add(nodo);
                                        ArcosUsados.Add(nodo);
                                        ponderacionTotal += nodo.peso;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    visitadosAux.Clear();
                    foreach (char c in visitados)
                    {
                        visitadosAux.Add(c);
                        Console.WriteLine("VISITADOS:" + c);
                    }
                    foreach (Vertice v in graph)
                    {
                        foreach(char c in visitadosAux)
                        {
                           if(v.getOrigen()==c)
                            {
                                foreach (Arista a in v.getListaAristas())
                                {
                                    usada = false;
                                    visitado arco = new visitado(c, a.getDestino(), a.getCosto());
                                    foreach(visitado usado in ArcosUsados)
                                    {
                                        if (usado.origen==arco.origen && usado.destino==arco.destino)
                                        {
                                            usada = true;
                                        }
                                    }
                                    if(!usada)
                                    {
                                        listaArcosDisp.Add(arco);
                                        cont++;
                                    }
                                }
                            }
                        }
                    }

                    //ordena arcosDisp
                    visitado arcoAux;
                    for (int j = 0; j < listaArcosDisp.Count - 1; j++)
                    {
                        for (int k = 0; k < listaArcosDisp.Count - 1 - j; k++)
                        {
                            if (listaArcosDisp[k].peso > listaArcosDisp[k + 1].peso)
                            {
                                arcoAux = listaArcosDisp[k];
                                listaArcosDisp[k] = listaArcosDisp[k + 1];
                                listaArcosDisp[k + 1] = arcoAux;
                            }
                        }
                    }//fin
                    if (listaArcosDisp.Count>0)
                    {
                        aceptados.Add(listaArcosDisp[0]);
                        ArcosUsados.Add(listaArcosDisp[0]);
                        Console.WriteLine("Lista ArcosDisp");
                        foreach (visitado arco in listaArcosDisp)
                        {
                            Console.WriteLine(arco.origen + "->" + arco.destino + ":" + arco.peso);
                        }
                        listaArcosDisp.RemoveAt(0);
                    }
                    foreach(visitado v in ArcosUsados)
                    {
                        if (!visitados.Contains(v.origen))
                        {
                            visitados.Add(v.origen);
                        }
                        if (!visitados.Contains(v.destino))
                        {
                            visitados.Add(v.destino);
                        }
                    }
                    if (cont >= 5)
                        break;
                }

                if (componenteConexaVisitada)
                {
                    break;
                }
            }

            Console.WriteLine("LISTA PRIM");
            foreach (visitado n in aceptados)
            {
                Console.WriteLine(n.origen + "->" + n.destino + ":" + n.peso);
                foreach (Vertice v in graph)
                {
                    foreach (Arista a in v.getListaAristas())
                    {
                        if(v.getOrigen()==n.origen && a.getDestino()==n.destino)
                        {
                            if(!aceptadosVertices.Contains(v))
                                aceptadosVertices.Add(v);//agrega vertice no adyacencia
                        }
                    }
                }
            }

            Console.WriteLine("YA PARA ELEGIR NODO");
            foreach (Vertice v in aceptadosVertices)
            {
                Console.WriteLine(v.getOrigen() + "->" + v.getListaAristas()[0].getDestino() + ": " + v.getListaAristas()[0].getCosto());
            }   

            listBoxRecorrido.Items.Clear();
            for (int i = 0; i < graph.Count; i++)
            {
                for (int j = 0; j < graph[i].getListaAristas().Count; j++)
                {
                    for (int k = 0; k < aceptadosVertices.Count; k++)
                    {
                        //checar aqui->
                        if (graph[i].getOrigen() == aceptadosVertices[k].getOrigen() && graph[i].getListaAristas()[j].getDestino() == aceptadosVertices[k].getListaAristas()[0].getDestino())
                        {
                            panelGrafo.CreateGraphics().DrawLine(lapiz, graph[i].getX(), graph[i].getY(), graph[i].getListaAristas()[j].getX(), graph[i].getListaAristas()[j].getY());

                            listBoxRecorrido.Items.Add(graph[i].getOrigen().ToString() + graph[i].getListaAristas()[j].getDestino().ToString());
                        }
                    }
                }
            }
            letras();
            letreroARM.Text = "Peso total con Prim: " + ponderacionTotal;
            letreroARM.Visible = Enabled;

        }


        private void prim()
        {
            listBoxRecorrido.Items.Clear();

            Font letra = new Font("Arial", 10);
            SolidBrush color = new SolidBrush(Color.Black);
            Color newColor = Color.FromArgb(75, Color.Red);
            Pen lapiz = new Pen(newColor, 8);
            int ponderacionTotal = 0;
            int indice;
            indice = comboOrigenes.SelectedIndex;
            Console.WriteLine("Seleccionado=" + graph[indice].getOrigen());
            Vertice origen = graph[indice];
            Vertice aux = origen;
            List<Vertice> aceptados = new List<Vertice>();
            List<char> visitados = new List<char>();

           // ordenarAdyacencia(graph);
            if (origen.getListaAristas().Count > 0)
            {

                Arista menor = origen.getListaAristas()[0];

                List<Arista> ArcosUsados = new List<Arista>();
                List<string> conjuntos = new List<string>();
                List<Vertice> ListPrim = new List<Vertice>();

                int cont = 0;
                int cont2 = 1;
                bool band1, band2, band4;
                int cont3 = 0;

                do
                {
                    band1 = band2 = true;
                    ListaAristas la = new ListaAristas(); //no estoy pasando lista aristas en blanco?
                    foreach (Arista a in aux.getListaAristas())
                    {
                        if (!ArcosUsados.Contains(a))
                        {
                            Vertice NV = new Vertice(aux.getOrigen(), la);
                            NV.getListaAristas().Add(a);//agregado extra
                            NV.setX(aux.getX());
                            NV.setY(aux.getY());
                            NV.getListaAristas().Add(a);
                            ListPrim.Add(NV);
                        }
                    }

                    foreach (Vertice n in ListPrim)
                    {
                        if (menor.getCosto() >= n.getListaAristas()[0].getCosto() || ArcosUsados.Contains(menor))
                        {
                            menor = n.getListaAristas()[0];
                            aux = n;
                        }
                    }

                    foreach (String a in conjuntos)
                    {
                        if (Convert.ToString(aux.getOrigen()) == a)
                        {
                            band1 = false;
                        }
                        if (Convert.ToString(menor.getDestino()) == a) //checar aqui
                        {
                            band2 = false;
                        }
                    }

                    if (band1 == true || band2 == true)
                    {
                        Vertice NV = aux;
                        aceptados.Add(NV);
                        visitados.Add(NV.getOrigen());
                        if (band1 == true)
                            conjuntos.Add(Convert.ToString(aux.getOrigen()));
                        if (band2 == true)
                        {
                            conjuntos.Add(Convert.ToString(aux.getListaAristas()[0].getDestino()));
                        }
                        ArcosUsados.Add(menor);
                    }

                    if (band1 == false && band2 == false)
                    {
                        ArcosUsados.Add(menor);
                    }
                    ListPrim.Remove(aux);
                    Console.WriteLine("Menor= " + menor.getDestino());
                    //aux = menor; //aqui es el pedo
                    foreach (Vertice v in graph)
                    {
                        if (v.getOrigen() == menor.getOrigen())
                        {
                           
                            foreach(Vertice v2 in graph)
                            {
                                if(v2.getOrigen()==v.getListaAristas()[0].getDestino())
                                {
                                    Console.WriteLine("Aux antes = " + aux.getOrigen());
                                    aux = v2;
                                    Console.WriteLine("Aux despues= " + aux.getOrigen());
                                }
                            }
                        }
                    }
                    cont++;
                }
                while (ArcosUsados.Count < graph.Count());
            }
            Console.WriteLine("LISTA DE ACEPTADOS");
            foreach (Vertice a in aceptados)
            {
                Console.WriteLine(a.getOrigen());
            }

            listBoxRecorrido.Items.Clear();
            for (int i = 0; i < graph.Count - 1; i++)
            {
                for (int j = 0; j < graph[i].getListaAristas().Count; j++)
                {
                    for (int k = 0; k < aceptados.Count; k++)
                    {
                        if (graph[i].getOrigen() == aceptados[k].getOrigen() && graph[i].getListaAristas()[j].getDestino() == aceptados[k].getListaAristas()[0].getDestino())
                        {
                            panelGrafo.CreateGraphics().DrawLine(lapiz, graph[i].getX(), graph[i].getY(), graph[i].getListaAristas()[j].getX(), graph[i].getListaAristas()[j].getY());

                            listBoxRecorrido.Items.Add(graph[i].getOrigen().ToString() + graph[i].getListaAristas()[j].getDestino().ToString());
                        }
                    }
                }
            }
            letras();
            letreroARM.Text = "Peso total con Prim: " + ponderacionTotal;
            letreroARM.Visible = Enabled;
        }//fin

        private void kruskalbutton_Click(object sender, EventArgs e)
        {
            Kruskal();
        }

        private void primButton_Click(object sender, EventArgs e)
        {
            Vertice origen = new Vertice();
            foreach (Vertice v in graph)
            {
                if (v.getOrigen().ToString() == comboOrigenes.SelectedItem.ToString())
                {
                    origen = v;
                    break;
                }
            }
            Console.WriteLine("SELECTED " + origen.getOrigen().ToString());
            arm = graph.newPrim(origen);//prim();//tryPrim();//Prim();

            listBoxRecorrido.Items.Clear();
            foreach (Arista a in arm)
            {
                listBoxRecorrido.Items.Add(a.getOrigen().ToString() + a.getDestino().ToString());
            }
        }

        private void comboOrigenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            primButton.Enabled = true;
        }


    }
}

