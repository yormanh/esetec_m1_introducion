using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valor1, valor2; 
            int resultado;
            int valor1Entero, valor2Entero;

            Console.Write("Entra el primer numero: ");
            valor1 = Console.ReadLine();

            Console.Write("Entra el segundo numero: ");
            valor2 = Console.ReadLine();

            //resultado = Convert.ToInt32(valor1) + Convert.ToInt32(valor2);

            valor1Entero = Convert.ToInt32(valor1);
            valor2Entero = Convert.ToInt32(valor2);

            resultado = valor1Entero + valor2Entero;
            Console.WriteLine(valor1 + " + " + valor2 + " = " + resultado);

            resultado = valor1Entero - valor2Entero;
            Console.WriteLine(valor1 + " - " + valor2 + " = " + resultado);

            resultado = valor1Entero * valor2Entero;
            Console.WriteLine(valor1 + " * " + valor2 + " = " + resultado);

            resultado = valor1Entero / valor2Entero;
            Console.WriteLine(valor1 + " / " + valor2 + " = " + resultado);



            Console.WriteLine("Presiona Enter para salir");
            Console.ReadLine();
        }
    }
}
