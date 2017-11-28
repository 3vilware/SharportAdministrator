using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa1
{
    [Serializable]
    public class Grafo : List<Vertice>
    {
        List<char> listaVertices;
        List<Universal> listavuelos;
        public Grafo(List<Universal> listavuelos)
        {
            this.listavuelos = listavuelos;
            listaVertices = new List<char>();

            for (int i = 0; i < listavuelos.Count; i++)
            {
                if (!listaVertices.Contains(listavuelos[i].getOrigen()))
                {
                    listaVertices.Add(listavuelos[i].getOrigen());
                }
                if (!listaVertices.Contains(listavuelos[i].getDestino()))
                {
                    listaVertices.Add(listavuelos[i].getDestino());
                }
            }
            for (int c = 0; c < listaVertices.Count; c++)
            {
                ListaAristas listaAristas = new ListaAristas();

                for (int k = 0; k < listavuelos.Count; k++)
                {
                    if (listaVertices[c] == listavuelos[k].getOrigen())
                    {
                        Arista a = new Arista(listavuelos[k].getCosto(), listavuelos[k].getTiempo(), listavuelos[k].getOrigen(), listavuelos[k].getDestino());
                        listaAristas.Add(a);
                    }
                }
                Vertice v = new Vertice(listaVertices[c], listaAristas);
                this.Add(v);
            }
        }

        public Grafo()
        {
        }

        public void delete()
        {
            for (int i = 0; i < Count; i++)
            {
                Remove(this[i]);
            }
        }

        public void insertarVertice(char vertice)
        {
            bool existe = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].getOrigen() == vertice)
                {
                    existe = true;
                    break;
                }
                foreach (Arista a in this[i].listaA)
                {
                    if (a.getDestino() == vertice)
                    {
                        existe = true;
                    }
                }

                if (!existe)
                {
                    ListaAristas la = new ListaAristas();
                    Vertice newV = new Vertice(vertice, la);
                    this.Add(newV);
                }
            }
        }

        public void eliminarVertice(char vertice)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].getOrigen() == vertice)
                {
                    Remove(this[i]);
                    break;
                }
                for (int k = 0; k < this[i].listaA.Count; k++)
                {
                    if (this[i].listaA[k].getDestino() == vertice)
                    {
                        this[i].listaA.RemoveAt(k);
                    }
                }
            }
        }


        public void eliminarArista(char origen, char destino)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].getOrigen() == origen)
                {
                    int cont = 0;
                    foreach (Arista la in this[i].listaA)
                    {
                        if (la.getDestino() == destino)
                        {
                            this[i].listaA.RemoveAt(cont);
                            if (this[i].listaA.Count == 0)
                            {
                                Remove(this[i]);
                            }
                        }
                        cont++;
                    }
                }
            }
        }

        public void insertarArista(int costo, int tiempo, char origen, char destino)
        {
            bool agregable = true;
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].getOrigen() == origen)
                {
                    foreach (Arista la in this[i].listaA)
                    {
                        if (la.getDestino() == destino)
                        {
                            agregable = false;
                        }
                    }
                    if (agregable)
                    {
                        Arista a = new Arista(costo, tiempo, origen, destino);
                        this[i].listaA.Add(a);
                        break;
                    }
                }
            }
        }

        public void ordenarListaAdyacencia()
        {

        }

        public int BuscarVertice(char Origen)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].getOrigen() == Origen)
                {
                    return i;
                }
            }
            return -1;
        }

        public List<Arista> newPrim(Vertice Origen)
        {
            Grafo P = new Grafo(); //List<Vertice> P = new List<Vertice>();
            P.Add(Origen);
            List<Arista> Cand = new List<Arista>();
            List<Arista> Prometedor = new List<Arista>();
            Arista NoDirigido;

            foreach (Vertice V in this)
            {
                foreach (Arista A in V.getListaAristas())
                {
                    Cand.Add(A);
                    NoDirigido = new Arista(A.getCosto(), A.getTiempo(), A.getOrigen(), A.getDestino());
                    Cand.Add(NoDirigido);
                }
            }

            Arista Ar;
            List<Arista> LA = new List<Arista>();

            do
            {
                Ar = SeleccionPrim(Cand, P);//truena
                Prometedor.Add(Ar);
                Console.WriteLine("Works " + Ar.getOrigen().ToString());
                if (BuscarVertice(Ar.getOrigen()) != -1)
                {
                    Vertice Nuevo = this[this.BuscarVertice(Ar.getDestino())];
                    P.Add(Nuevo);
                }
                else
                {
                    Vertice Nuevo = this[this.BuscarVertice(Ar.getOrigen())];
                    P.Add(Nuevo);
                }
            } while (P.Count <= this.Count - 1);
            return Prometedor;
        }


        private Arista SeleccionPrim(List<Arista> Cand, Grafo P)
        {
            Vertice AuxO, AuxD;
            Arista AuxA = new Arista();
            bool bandera = false;
            do
            {
                foreach (Arista A in Cand)
                {
                    if (BuscarVertice(A.getOrigen()) != -1)
                    {
                        AuxO = this[BuscarVertice(A.getOrigen())];
                    }
                    else
                    {
                        AuxO = new Vertice();
                    }

                    if (BuscarVertice(A.getDestino()) != -1)
                    {
                        AuxD = this[BuscarVertice(A.getDestino())];
                    }
                    else
                    {
                        AuxD = new Vertice();
                    }

                    if (P.Contains(AuxO))
                    {
                        if (!P.Contains(AuxD))
                        {
                            AuxA = A;
                            bandera = true;
                            break;
                        }
                    }
                }
                if (!bandera)
                {
                    foreach (Vertice V in this)
                    {
                        if (!P.Contains(V))
                        {
                            P.Add(V);
                            break;
                        }
                    }
                }
            } while (!bandera);
            Cand.Remove(AuxA);
            return AuxA;
        }

    }
    //fin grafo

    public class Vertice
    {
        public ListaAristas listaA;
        char origen;
        public int x, y;

        public Vertice()
        {
        }

        public Vertice(Universal entra)
        {
            origen = entra.getOrigen();
        }
        public Vertice(char o, ListaAristas listaA)
        {
            this.origen = o;
            this.listaA = new ListaAristas();
            this.listaA = listaA;
            x = 0;
            y = 0;
        }

        public char getOrigen()
        {
            return origen;
        }
        public ListaAristas getListaAristas()
        {
            return listaA;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }

    }

    public class Arista
    {
        int costo;
        int tiempo;
        char origen;
        char destino;
        public int x, y;

        public Arista()
        {
        }

        public Arista(int c, int t, char o, char d)
        {
            destino = d;
            costo = c;
            tiempo = t;
            origen = o;
            x = 0;
            y = 0;
        }

        public char getDestino()
        {
            return destino;
        }
        public char getOrigen()
        {
            return origen;
        }
        public int getCosto()
        {
            return costo;
        }
        public int getTiempo()
        {
            return tiempo;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    }

    public class ListaAristas : List<Arista>
    {
    }

    public class visitado
    {
        public char origen;
        public char destino;
        public int peso;

        public visitado(char o, char d, int p)
        {
            origen = o;
            destino = d;
            peso = p;
        }
    }

}
