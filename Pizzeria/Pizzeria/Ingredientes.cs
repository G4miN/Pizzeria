using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Ingredientes
    {
        public String nombre;
        public int precio;

        public Ingredientes(String nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        //Getters
        public String getNombre()
        {
            return this.nombre;
        }

        public int getPrecio()
        {
            return this.precio;
        }

        //Setters
        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void SetPrecio(int precio)
        {
            this.precio = precio;
        }


    }
}
