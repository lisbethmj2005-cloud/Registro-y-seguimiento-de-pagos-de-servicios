using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorServicios gestor = new GestorServicios();
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Lista de opciones");
                Console.WriteLine("1. Agregar un servicio");
                Console.WriteLine("2. Mostrar los servicios");
                Console.WriteLine("3. Buscar servicio");
                Console.WriteLine("4. Guardar en archivo");
                Console.WriteLine("5. Leer archivo");
                Console.WriteLine("6. Salir");
                Console.Write("Selecciona una de las opciones disponibles: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ServicioPagado sp = new ServicioPagado();

                        Console.Write("ID: ");
                        sp.Id = int.Parse(Console.ReadLine());

                        Console.Write("Nombre del servicio: ");
                        sp.Nombre = Console.ReadLine();

                        Console.Write("Monto: ");
                        sp.Monto = double.Parse(Console.ReadLine());

                        Console.Write("Estado (Pagado/Pendiente): ");
                        sp.Estado = Console.ReadLine();

                        gestor.Agregar(sp);
                        Console.WriteLine("Servicio agregado correctamente.");
                        break;

                    case 2:
                        gestor.MostrarT();   
                        break;

                    case 3:
                        Console.Write("Ingrese el ID a buscar: ");
                        int idBuscar = int.Parse(Console.ReadLine());
                        gestor.BuscarPId(idBuscar);
                        Console.ReadKey();
                        break;

                    case 4:
                        gestor.Guardar();
                        Console.ReadKey();
                        break;

                    case 5:
                        gestor.Leer();
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.WriteLine("Cerrando el programa.....");
                        break;
                }

            } while (opcion != 6);
        }
    }
}