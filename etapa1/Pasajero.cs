using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa1
{
    [Serializable] 
    public class Pasajero
    {
        string nombre;
        string apellido;
        int edad;
        int asiento;
        string vuelo;

        public Pasajero() { }
        public Pasajero(string n, string a, int e, int asiento, string vuelo)
        {
            nombre = n;
            apellido = a;
            edad = e;
            this.asiento = asiento;
            this.vuelo = vuelo;
        }
        public string getNombreYap()
        {
            return nombre + " " + apellido;
        }

        public int getAsiento()
        {
            return asiento;
        }

        public string getRuta()
        {
            return this.vuelo;
        }
    }
}
