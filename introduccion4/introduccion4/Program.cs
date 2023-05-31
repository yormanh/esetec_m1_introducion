using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion4
{
    internal class Program
    {
        //Dado la edad de una persona decir si es mayor de edad
        static void Main(string[] args)
        {
            int edad, mayoria;

            edad = 18;
            mayoria = 18;

            if (edad >= mayoria)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }



            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
        }
    }
}
