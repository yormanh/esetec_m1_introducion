using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nombre de la persona

            Console.WriteLine("Hola Mundo");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(5 + 5);

            for(int i = 1; i <= 20; i++) 
            { 
                Console.WriteLine(i + " ");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * 5);
            }


            Console.ReadLine();
        }
    }
}
