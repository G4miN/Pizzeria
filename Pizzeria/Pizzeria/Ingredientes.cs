using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Ingredientes
    {
        private String nombre { get; set; }
        private int precio { get; set; }

        public Ingredientes(String nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
