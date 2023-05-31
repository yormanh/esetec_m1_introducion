using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //tabla de multiplicar de un numero

            int tabla = 1;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }

            tabla = 2;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }

            tabla = 3;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tabla + " * " + i + " = " + (tabla * i));
            }

            //todas las tablas
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (j * i));
                }
            }

            //Console.WriteLine(int.MaxValue);
            //for (int i = int.MaxValue; ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            
            for (int i = 0; i < 10; i++)
            {
                int resto = i % 2;
                if (resto == 0)
                    Console.WriteLine("Par: " + i);
                else
                    Console.WriteLine("Impar: " + i);
            }







            Console.ReadLine();
        }
    }
}
