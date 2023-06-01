using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma, multiplicacion, resultado;
            Mensaje("Hola mundo cruel"); 
            Mensaje("Adios");

            suma = Suma(10, 20);
            suma = Suma(suma, 30);
            Console.WriteLine(suma);
            multiplicacion = Multiplicacion(5, 4);
            Console.WriteLine(multiplicacion);
            //5 * 4 + 10 - 20
            resultado = Multiplicacion(5, 4);
            resultado = Suma(resultado, 10);
            resultado = Resta(resultado, 20);
            Console.WriteLine(resultado);
            Console.ReadLine();

        }
        static public int Division(int valor1, int valor2)
        {
            return valor1 / valor2;
        }

        static public int Resta(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        static public int Multiplicacion(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        static public int Suma(int valor1, int valor2)
        {
            //Console.WriteLine(valor1 + valor2);
            return valor1 + valor2;
        }

        static public void Mensaje(string saludo)
        {
            Console.WriteLine(saludo);
        }
       
       


    }
}
