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

            int numeroPersonasEntero;
            float valorCuentaFloat;
            float resultado;
            string valorCuenta;
            string numeroPersonas;
            float igic;

            Console.Write("Escribe el numero de personas: ");
            numeroPersonas = Console.ReadLine();

            Console.Write("Entra valor de la cuenta: ");
            valorCuenta = Console.ReadLine();

            valorCuentaFloat = Convert.ToSingle(valorCuenta) * 1.0f;
            numeroPersonasEntero = Convert.ToInt32(numeroPersonas);

            resultado = valorCuentaFloat / numeroPersonasEntero;
            Console.WriteLine("A pagar: " + resultado);

            //Calcular el IGIC
            //regla de 3
            //igic = 7 * valorceuenta / 100

            Console.WriteLine("Presiona Enter para salir");
            Console.ReadLine();
        }
    }
}
