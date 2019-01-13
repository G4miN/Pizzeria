using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class PizzaSaludable : Pizza 
    {
        public PizzaSaludable(Ingredientes masa, Ingredientes salsa, int precio) : base(salsa, masa, precio)
        {
            
            Ingredientes masaFina = new Ingredientes("Masa Fina", 0);
            SetMasa(masaFina);
            adicionales = new Ingredientes[6];
        }
    }
}
