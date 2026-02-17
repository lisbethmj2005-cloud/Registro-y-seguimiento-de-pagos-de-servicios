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

        public void Agregar(Servicio serv)
        {
            servicios.Add(serv);
        }
        public void MostrarT()
        {
            bool hayServicios = false;

            foreach (Servicio serv in servicios)
            {
                Console.WriteLine(serv.Mostrar());
                hayServicios = true;
            }
            if (!hayServicios)
            {
                Console.WriteLine("No hay servicios registrados.");
            }
        }
        public void BuscarPId(int id)
        {
            bool encontrado = false;

            foreach (Servicio serv in servicios)
            {
                if (serv.Id == id)
                {
                    Console.WriteLine("El servicio ha sido encontrado:");
                    Console.WriteLine(serv.Mostrar());
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El servicio no ha sido encontrado");
            }
        }

        public void Guardar()
        {
            StreamWriter sw = new StreamWriter("servicios.txt");

            foreach (Servicio serv in servicios)
            {
                sw.WriteLine(serv.Mostrar());
            }

            sw.Close();
            Console.WriteLine("Los datos ya han sido guardados");
        }

        public void Leer()
        {
            if (!File.Exists("servicios.txt"))
            {
                Console.WriteLine("No se ha guardado un archivo todavia.");
                return;
            }

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