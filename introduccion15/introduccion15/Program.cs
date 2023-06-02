using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int puntos = 0;
            Random random = new Random();

            puntos = random.Next(10);

            Console.WriteLine(puntos);
            //Si tienes mas de 5 puntos escribir "superado"
            if (puntos > 5)
            {
                Console.WriteLine("superado");
            }
            else
            {
                Console.WriteLine("no superado");
            }

            //Si estas entre 3 y 5 escribir casi superado
            if (puntos > 3 && puntos < 5)
            {
                Console.WriteLine("casi superado");
            }

            if (puntos > 10)
            {
                Console.WriteLine("ganastes");
            }

            if (puntos != 0)
            {
                Console.WriteLine("tienes algo de puntuacion");
            }
            //si tienes 6 o 7 puntos escribir bastante bien
            if (puntos == 6 || puntos == 7)
            {
                Console.WriteLine("bastante bien");
            }


            Console.ReadLine();
        }
    }
}
