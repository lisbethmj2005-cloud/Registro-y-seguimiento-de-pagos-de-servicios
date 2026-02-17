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
                ServicioPagado sp = (ServicioPagado)serv;

                sw.WriteLine(sp.Id);
                sw.WriteLine(sp.Nombre);
                sw.WriteLine(sp.Monto);
                sw.WriteLine(sp.Estado);
            }

            sw.Close();
            Console.WriteLine("Datos han sido guardados correctamente.");
        }

        public void Leer()
        {
            if (!File.Exists("servicios.txt"))
                return;

            servicios.Clear();

            StreamReader sr = new StreamReader("servicios.txt");

            while (true)
            {
                try
                {
                    string lineaId = sr.ReadLine();

                    if (lineaId == null) 
                        break;

                    ServicioPagado sp = new ServicioPagado();

                    sp.Id = int.Parse(lineaId);
                    sp.Nombre = sr.ReadLine();
                    sp.Monto = double.Parse(sr.ReadLine());
                    sp.Estado = sr.ReadLine();

                    servicios.Add(sp);
                }
                catch
                {
                    break;
                }
            }

            sr.Close();
        }
    }
}