﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Pizza
    {
        public int preciobase;
        public Ingredientes masa;
        public Ingredientes salsa;
        public Ingredientes[] adicionales = new Ingredientes[5];
        public int preciototal;
        public int ingredientesAgregados;

        //Constructor
        public Pizza(Ingredientes masa, Ingredientes salsa, int precio)
        {
            this.masa = masa;
            this.salsa = salsa;
            this.preciobase = precio;
            preciototal = precio;
        }

        // Setters
        public void SetPrecio(int precio)
        {
            this.preciobase = precio;
        }

        public void SetMasa(Ingredientes masa)
        {
            this.masa = masa;
        }

        public void SetSalsa(Ingredientes salsa)
        {
            this.salsa = salsa;
        }



        //getters         
        public Ingredientes getMasa()
        {
            return this.masa;
        }
        public Ingredientes getSala()
        {
            return this.salsa;
        }

        public int getTotal()
        {
            return this.preciototal;
        }

        public int getPrecio()
        {
            return this.preciobase;
        }

        public Ingredientes[] getAdicionales()
        {
            return this.adicionales;
        }

        public int getAgregados()
        {
            return this.ingredientesAgregados;
        }


        public String mostrar()
        {
            String todo = "\n====================================================================\n";
            todo += "Precio Base: " + preciobase + "\n";
            todo += "Tipo de Masa: " + masa.getNombre() + "\n";
            todo += "Tipo de Salsa: " + salsa.getNombre() + "\n";
            todo += getAgregados() + " Adicionales: \n";

            //Listar ingredientes adicionales
            for (int i = 0; i < adicionales.Length; i++)
            {
                if (adicionales[i] != null)
                {
                    todo += adicionales[i].getNombre() + " $" + adicionales[i].getPrecio() + "\n";
                }
            }

            todo += "\nTotal: $" + getTotal();

            todo += "\n====================================================================\n";

            return todo;

        }

        //Metodo Para agregar ingredientes adicionales
        public void agregarAdicionales(Ingredientes adicional)
        {
            bool agregado = false;

            for (int i = 0; i < adicionales.Length; i++)
            {
                if (adicionales[i] == null)
                {
                    adicionales[i] = adicional;
                    agregado = true;
                    preciototal += adicional.getPrecio();
                    ingredientesAgregados++;
                    break;
                }
            }

            if (agregado)
            {
                Console.WriteLine("Ingrediente adicional [" + adicional.getNombre() + "] agregado");
            }
            else
            {
                Console.WriteLine("No se puede agregar mas ingredientes");
            }
        }


    }
}
