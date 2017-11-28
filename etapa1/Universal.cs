using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa1
{
    [Serializable]
    public class Universal
    {
        char origen;
        char destino;
        int tiempo;
        int costo;
        string ruta;
        int numAsiento;

        public int asientosDisp = 20;
        public bool confirmable = false;
        public bool[] asientoOcupado = new bool[20];
        public string vuelo;
        public List<int> AO = new List<int>(); //lista de numeros de asientos ocupados.
        List<Pasajero> listaPasajeros = new List<Pasajero>();

        public char getOrigen()
        {
            return origen;
        }

        public char getDestino()
        {
            return destino;
        }

        public int getTiempo()
        {
            return tiempo;
        }

        public int getCosto()
        {
            return costo;
        }
        public bool getAsientoOcupado(int i)
        {
            return asientoOcupado[i];
        }
        public void setAsientoOcupado(bool value, int i)
        {
            asientoOcupado[i] = value;
        }
        public void setAsientosDisponibles(int a)
        {
            asientosDisp = a;
        }

        public int getAsientos()
        {
            return asientosDisp;
        }

        public void setNumeroAsiento(int n)
        {
            this.numAsiento = n;
        }

        public int getNumeroAsiento()
        {
            return numAsiento;
        }


        public Universal() { }

        public Universal(char origen, char destino, int tiempo, int costo)
        {
            this.origen = origen;
            this.destino = destino;
            this.tiempo = tiempo;
            this.costo = costo;
            ruta = "SK1" + origen + destino;
        }

        public override string ToString()
        {
            return ruta;
        }

        public void setPasajero(Pasajero p)
        {
            listaPasajeros.Add(p);
        }

        public Pasajero getPasajero(int i)
        {
            return listaPasajeros[i];
        }

        public List<Pasajero> getListaPasajeros()
        {
            return listaPasajeros;
        }

        public void eliminarPasajero(int pos)
        {
            listaPasajeros.RemoveAt(pos);
        }

        public int getPasajerosCount()
        {
            return listaPasajeros.Count();
        }
    }
}
