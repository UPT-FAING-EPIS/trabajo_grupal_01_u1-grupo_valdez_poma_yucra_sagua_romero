using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Pizza pizza;

            PizzeriaArgentina pizzeria = new PizzeriaArgentina();

            pizza = pizzeria.CrearPizza("napo");
            pizza.Render();
            pizza = pizzeria.CrearPizza("cancha");
            pizza.Render();

            PizzeriaItaliana pizzeria2 = new PizzeriaItaliana();
            pizza = pizzeria2.CrearPizza("napo");
            pizza.Render();
            pizza = pizzeria2.CrearPizza("cancha");
            pizza.Render();
            Console.ReadKey();
        }
    }
}
