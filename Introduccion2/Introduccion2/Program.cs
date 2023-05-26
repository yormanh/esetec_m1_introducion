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
            int edad;
            string entradaUsuario;
            string entradaNombre;

            Console.Write("Escribe tu edad: ");
            entradaUsuario = Console.ReadLine();

            Console.Write("Escribe tu nombre: ");
            entradaNombre = Console.ReadLine();

            Console.WriteLine("Tu edad es: " + entradaUsuario);
            Console.WriteLine("Tu nombre es: " + entradaNombre);

            Console.WriteLine("Presiona Enter para salir");
            Console.ReadLine();
        }
    }
}
