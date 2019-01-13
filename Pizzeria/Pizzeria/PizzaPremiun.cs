using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class PizzaPremiun : Pizza
    {
        public PizzaPremiun(Ingredientes masa, Ingredientes salsa, int precio) : base(salsa, masa, precio)
        {

            adicionales = new Ingredientes[2];
            Ingredientes palitosqueso = new Ingredientes("Palitos Rellenos con Queso", 50);
            Ingredientes bebida = new Ingredientes("Coca-Cola", 30);
            agregarAdicionales(palitosqueso);
            agregarAdicionales(bebida);
        }
    }
}
