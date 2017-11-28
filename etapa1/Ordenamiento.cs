using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa1
{
    class ordenamientoPasajero : List<Pasajero>
    {
        public ordenamientoPasajero()
        {

        }
        public void quicksortNombre(int inicio, int fin)
        {
            int i = inicio;
            int j = fin;
            int medio = (inicio + fin) / 2;
            Pasajero pivote = new Pasajero();
            pivote = this[medio];
            
            while (i<=j)
            {
                while (this[i].getNombreYap().CompareTo(pivote.getNombreYap())==-1)
                    i++;
                while (this[j].getNombreYap().CompareTo(pivote.getNombreYap())==1)
                    j--;

                if(i<=j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            }
            if (i <= fin)
                quicksortNombre(i, fin);
            if (j >= inicio)
                quicksortNombre(inicio, j);
            
        }

        public void quicksortVuelos(int inicio, int fin)
        {
            int i = inicio;
            int j = fin;
            int medio = (inicio + fin) / 2;
            Pasajero pivote = new Pasajero();
            pivote = this[medio];

            while (i <= j)
            {
                while (this[i].getRuta().CompareTo(pivote.getRuta()) == -1)
                    i++;
                while (this[j].getRuta().CompareTo(pivote.getRuta()) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            }
            if (i <= fin)
                quicksortVuelos(i, fin);
            if (j >= inicio)
                quicksortVuelos(inicio, j);

        }

        public void quicksortAsientos(int inicio, int fin)
        {
            int i = inicio;
            int j = fin;
            int medio = (inicio + fin) / 2;
            Pasajero pivote = new Pasajero();
            pivote = this[medio];

            while (i <= j)
            {
                while (this[i].getAsiento().CompareTo(pivote.getAsiento()) == -1)
                    i++;
                while (this[j].getAsiento().CompareTo(pivote.getAsiento()) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            }
            if (i <= fin)
                quicksortAsientos(i, fin);
            if (j >= inicio)
                quicksortAsientos(inicio, j);

        }
        private void swap(int i, int j)
        {
            Pasajero aux = new Pasajero();
            aux = this[i];
            this[i] = this[j];
            this[j] = aux;
        }
    }

    class ordenamientoVuelos : List<Universal>
    {
        public ordenamientoVuelos() { }

        public void quicksortOrigen(int inicio, int fin)
        {
            int i = inicio;
            int j = fin;
            int medio = (inicio + fin) / 2;
            Universal pivote = new Universal();
            pivote = this[medio];

            while (i <= j)
            {
                while (this[i].getOrigen().ToString().CompareTo(pivote.getOrigen().ToString()) == -1)
                    i++;
                while (this[j].getOrigen().ToString().CompareTo(pivote.getOrigen().ToString()) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            }
            if (i <= fin)
                quicksortOrigen(i, fin);
            if (j >= inicio)
                quicksortOrigen(inicio, j);

        }
        private void swap(int i, int j)
        {
            Universal aux = new Universal();
            aux = this[i];
            this[i] = this[j];
            this[j] = aux;
        }

        public void quicksortDestino(int inicio, int fin)
        {
            int i = inicio;
            int j = fin;
            int medio = (inicio + fin) / 2;
            Universal pivote = new Universal();
            pivote = this[medio];

            while (i <= j)
            {
                while (this[i].getDestino().ToString().CompareTo(pivote.getDestino().ToString()) == -1)
                    i++;
                while (this[j].getDestino().ToString().CompareTo(pivote.getDestino().ToString()) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            }
            if (i <= fin)
                quicksortDestino(i, fin);
            if (j >= inicio)
                quicksortDestino(inicio, j);

        }

        public void quicksortCosto(int inicio, int fin)
        {
            int i = inicio;
            int j = fin;
            int medio = (inicio + fin) / 2;
            Universal pivote = new Universal();
            pivote = this[medio];

            while (i <= j)
            {
                while (compareInt(this[i].getCosto(), pivote.getCosto())==-1)//(this[i].getCosto().ToString().CompareTo(pivote.getCosto().ToString()) == -1)
                    i++;
                while (compareInt(this[j].getCosto(), pivote.getCosto())==1)//(this[j].getCosto().ToString().CompareTo(pivote.getCosto().ToString()) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            }
            if (i <= fin)
                quicksortCosto(i, fin);
            if (j >= inicio)
                quicksortCosto(inicio, j);
        }

        private int compareInt(int a, int b)
        {
            if (a > b)
                return 1;
            if (a < b)
                return -1;
            return 0;
        }
    }
}
