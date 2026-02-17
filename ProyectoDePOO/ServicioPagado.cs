using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDePOO
{
    public class ServicioPagado : Servicio
    {
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public override string Mostrar()
        {
            return base.Mostrar() + $" | Estado: {estado}";
        }
    }
}