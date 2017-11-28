using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace etapa1
{
    [Serializable]
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
       [STAThread]

        static void Main()
        {

            List<Universal> listaVuelos = new List<Universal>();

            //lectura
            if (File.Exists("Vuelos.bin"))
            {
                using (Stream stream = File.Open("Vuelos.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    listaVuelos = (List<Universal>)bformatter.Deserialize(stream);
                }

            }
            else
            {
                Universal v1 = new Universal('A', 'B', 50, 600);
                Universal v2 = new Universal('A', 'F', 90, 1050);
                Universal v3 = new Universal('A', 'G', 80, 1150);
                Universal v4 = new Universal('B', 'A', 50, 600);
                Universal v5 = new Universal('B', 'C', 40, 750);
                Universal v6 = new Universal('B', 'D', 60, 650);
                Universal v7 = new Universal('B', 'E', 70, 1850);
                Universal v8 = new Universal('C', 'B', 35, 800);
                Universal v9 = new Universal('C', 'E', 50, 850);
                Universal v10 = new Universal('E', 'C', 45, 750);
                Universal v11 = new Universal('E', 'G', 80, 1150);
                Universal v12 = new Universal('E', 'L', 60, 1650);
                Universal v13 = new Universal('E', 'D', 35, 700);
                Universal v14 = new Universal('D', 'E', 45, 900);
                Universal v15 = new Universal('D', 'B', 55, 700);
                Universal v16 = new Universal('F', 'B', 65, 800);
                Universal v17 = new Universal('F', 'L', 140, 2850);
                Universal v18 = new Universal('G', 'A', 95, 1250);
                Universal v19 = new Universal('G', 'E', 75, 1175);
                Universal v20 = new Universal('G', 'L', 135, 2675);
                Universal v21 = new Universal('G', 'J', 60, 1400);
                Universal v22 = new Universal('G', 'H', 25, 450);
                Universal v23 = new Universal('H', 'G', 30, 350);
                Universal v24 = new Universal('H', 'I', 35, 400);
                Universal v25 = new Universal('I', 'H', 30, 400);
                Universal v26 = new Universal('I', 'K', 35, 400);
                Universal v27 = new Universal('K', 'J', 35, 400);
                Universal v28 = new Universal('J', 'L', 40, 750);
                Universal v29 = new Universal('J', 'M', 70, 1450);
                Universal v30 = new Universal('L', 'M', 40, 650);
                Universal v31 = new Universal('L', 'K', 70, 700);
                Universal v32 = new Universal('L', 'E', 60, 1550);
                Universal v33 = new Universal('M', 'L', 40, 700);

                listaVuelos.Add(v1);
                listaVuelos.Add(v2);
                listaVuelos.Add(v3);
                listaVuelos.Add(v4);
                //listaVuelos.Add(v5);
                //listaVuelos.Add(v6);
                //listaVuelos.Add(v7);
                //listaVuelos.Add(v8);
                //listaVuelos.Add(v9);
                //listaVuelos.Add(v10);
                //listaVuelos.Add(v11);
                //listaVuelos.Add(v12);
                //listaVuelos.Add(v13);
                //listaVuelos.Add(v14);
                //listaVuelos.Add(v15);
                //listaVuelos.Add(v16);
                //listaVuelos.Add(v17);
                //listaVuelos.Add(v18);
                //listaVuelos.Add(v19);
                //listaVuelos.Add(v20);
                //listaVuelos.Add(v21);
                //listaVuelos.Add(v22);
                //listaVuelos.Add(v23);
                //listaVuelos.Add(v24);
                //listaVuelos.Add(v25);
                //listaVuelos.Add(v26);
                //listaVuelos.Add(v27);
                //listaVuelos.Add(v28);
                //listaVuelos.Add(v29);
                //listaVuelos.Add(v30);
                //listaVuelos.Add(v31);
                //listaVuelos.Add(v32);
                //listaVuelos.Add(v33);
            }

            //apartir de la lista crear el grafo
            Grafo g = new Grafo(listaVuelos);
            //g.avanza();


            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 Vuelo = new Form1(ref listaVuelos, g);
            Vuelo.ShowDialog();

            //escritura
            using (Stream stream = File.Open("Vuelos.bin", FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, listaVuelos);
            }

        }
    }
}
