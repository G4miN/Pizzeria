using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Menu
    {
        String nombreLocal;
        String nombreVendedor;

        public Menu(String nombreLocal, String nombreVendedor)
        {
            this.nombreLocal = nombreLocal;
            this.nombreVendedor = nombreVendedor;
        }

        private String encabezado()
        {
            var fecha = DateTime.Now.ToString("hh:mm");
            return "Local: " + nombreLocal + "\n" + "Atendido por: " + nombreVendedor + " Hora: "+fecha + "\n\n";
        }

        public void imprimirMenu()
        {
            String menu = encabezado();
            menu += "[1] Pizza Normal\n";
            menu += "[2] Pizza Saludable\n";
            menu += "[3] Pizza Premium\n";
            menu += "[4] Salir\n";
            Console.WriteLine(menu);
            Console.WriteLine("Seleccione entre las opciones disponibles: ");
        }

        public void mostrarIngredientes(Ingredientes[] todos)
        {
            String todo = "";
            for (int i = 0; i < todos.Length; i++)
            {
                if (todos[i] != null)
                {
                    todo += "[" + (i + 1) + "] " + todos[i].getNombre() + " precio: " + todos[i].getPrecio() + "\n";
                }
            }

            Console.WriteLine(todo);
        }
    }
}
