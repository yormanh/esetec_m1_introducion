using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una edad, decir si es niño/a, adolescente o adulto
            //13 a 18 adolescencia
            int edad;

            edad = 10;

            if (edad >= 18)
            {
                Console.WriteLine("Adulto");
            }

            if (edad >= 13 && edad < 18) //forma 2
            {
                Console.WriteLine("Adolescente");
            }
            //if (edad < 18) //forma 1
            //{
            //    if (edad >= 13)
            //    {
            //        Console.WriteLine("Adolescente");
            //    }
            //}
            if (edad < 13)
            {
                Console.WriteLine("Niño");
            }




            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();

        }
    }
}
