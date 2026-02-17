using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDePOO
{
    public class GestorServicios
    {
        private List<Servicio> servicios = new List<Servicio>();

        public void Agregar(Servicio s)
        {
            servicios.Add(s);
        }

        public void MostrarT()
        {
            foreach (Servicio s in servicios)
            {
                Console.WriteLine(s.Mostrar());
            }
        }

        public void Guardar()
        {
            StreamWriter sw = new StreamWriter("servicios.txt");

            foreach (Servicio s in servicios)
            {
                sw.WriteLine(s.Mostrar());
            }

            sw.Close();
            Console.WriteLine("Datos guardados");
        }

        public void Leer()
        {
            StreamReader sr = new StreamReader("servicios.txt");
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }

            sr.Close();
        }
    }
}