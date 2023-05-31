using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir los 10 primeros numeros
            int tabla = 5, resultado;


            //for (int indice = 0; indice < 10; indice++)
            //{
            //    Console.WriteLine(indice);
            //}

            //for (int indice = 9; indice >= 0; indice--)
            //{
            //    Console.WriteLine(indice);
            //}

            for (int indice = 0; indice < 10; indice++)
            {
                resultado = indice * tabla;
                Console.WriteLine(resultado);
                //Console.WriteLine(indice + " * 5" + " = " + (indice * 5));
            }






            Console.ReadLine();
        }
    }
}
