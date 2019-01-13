using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Ingredientes masa = new Ingredientes("Masa Normal", 0);
            Ingredientes salsa = new Ingredientes("Salsa Prego", 0);

             
            Ingredientes[] todosLosIngredientes = new Ingredientes[5];

            Ingredientes champiñones = new Ingredientes("Champiñones", 10);
            Ingredientes piña = new Ingredientes("Piña", 5);
            Ingredientes carne = new Ingredientes("Carne de pollo", 20);
            Ingredientes salami = new Ingredientes("Salami", 10);
            Ingredientes queso = new Ingredientes("Queso Danes", 10);

           
            todosLosIngredientes[0] = champiñones;
            todosLosIngredientes[1] = piña;
            todosLosIngredientes[2] = carne;
            todosLosIngredientes[3] = salami;
            todosLosIngredientes[4] = queso;

            Menu nuevo = new Menu("Pizza Hut Dominicana", "Yeduin Mateo");


            bool terminar = false;

            while (!terminar)
            {
                nuevo.imprimirMenu();
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Pizza normal = new Pizza(masa, salsa, 150);

                        bool fin = false;
                        while (!fin)
                        {
                            Console.WriteLine("[1] Agregar ingrediente extra\n[2] Imprimir recibo\n");
                            Console.WriteLine("Seleccione entre las opciones disponibles ");
                            int opcion2 = int.Parse(Console.ReadLine());

                            switch (opcion2)
                            {

                                case 1:
                                    nuevo.mostrarIngredientes(todosLosIngredientes);
                                    Console.WriteLine("Que ingrediente desea agregar?");
                                    int nuevoingrediente = int.Parse(Console.ReadLine());
                                    normal.agregarAdicionales(todosLosIngredientes[nuevoingrediente - 1]);
                                    break;

                                case 2:
                                    fin = true;
                                    Console.WriteLine(normal.mostrar());
                                    break;

                                default:
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }
                        break;

                    case 2:

                        Pizza saludable = new PizzaSaludable(masa, salsa, 200);

                        fin = false;
                        while (!fin)
                        {
                            Console.WriteLine("[1] Agregar ingrediente extra\n[2] Imprimir recibo\n");
                            Console.WriteLine("Seleccione entre las opciones disponibles ");
                            int opcion2 = int.Parse(Console.ReadLine());
                            switch (opcion2)
                            {

                                case 1:
                                    nuevo.mostrarIngredientes(todosLosIngredientes);
                                    Console.WriteLine("Que ingrediente desea agregar?");
                                    int nuevoingrediente = int.Parse(Console.ReadLine());
                                    if (nuevoingrediente <= todosLosIngredientes.Length && nuevoingrediente > 0)
                                    {
                                        saludable.agregarAdicionales(todosLosIngredientes[nuevoingrediente - 1]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrediente Invalido");
                                    }

                                    break;

                                case 2:
                                    fin = true;
                                    Console.WriteLine(saludable.mostrar());
                                    break;

                                default:
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }
                        break;

                    case 3:

                        Pizza premium = new PizzaPremiun(masa, salsa, 150);

                        fin = false;
                        while (!fin)
                        {
                            Console.WriteLine("[2] Imprimir recibo\n");
                            Console.WriteLine("Seleccione entre las opciones disponibles ");
                            int opcion2 = int.Parse(Console.ReadLine());
                            switch (opcion2)
                            {

                                /*case 1:

                                    nuevo.mostrarIngredientes(todosLosIngredientes);
                                    Console.WriteLine("Que ingrediente desea agregar?");
                                    int nuevoingrediente = int.Parse(Console.ReadLine());
                                    premium.agregarAdicionales(todosLosIngredientes[nuevoingrediente -1]);
                                    break;*/

                                case 1:
                                    fin = true;
                                    Console.WriteLine(premium.mostrar());
                                    break;

                                default:
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }

                        break;


                    case 4:
                        terminar = true;
                        Console.WriteLine("Sabor hasta la orilla" + "");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
                
            }
            
            Console.ReadKey();
        }
    }
   
}
