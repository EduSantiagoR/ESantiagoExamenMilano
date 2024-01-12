using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {
        public string NumeroEmpleado { get; set; }
        public string Nombre { get; set; }
        public ML.Tienda TiendaAsignada { get; set; }
        public List<object> Empleados { get; set; }

        public Usuario()
        {
            TiendaAsignada = new ML.Tienda();
        }
    }
}
