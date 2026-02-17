using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDePOO
{
    public class Servicio
    {
        private int id;
        private string nombre;
        private double monto;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public virtual string Mostrar()
        {
            return "ID: " + id + " - Servicio: " + nombre + " - Monto: " + monto;
        }
    }
}