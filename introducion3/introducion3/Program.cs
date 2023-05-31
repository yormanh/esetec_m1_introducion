using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introducion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables e inicializacion
            int numero1, numero2, resultado, multiplicacion;

            numero1 = 10;
            numero2 = 10;

            //Logica 
            resultado = numero1 + numero2;
            multiplicacion = numero1 * numero2;

            if(numero1 < numero2)
            {
                Console.WriteLine("numero1 menor numero2");
            }
            if (numero1 > numero2)
            {
                Console.WriteLine("numero1 mayor numero2");
            }
            if (numero1 == numero2)
            {
                Console.WriteLine("numero1 igual numero2");
            }


            //Visualizacion
            Console.WriteLine(numero1 +" + " + numero2 + " = " + resultado);
            Console.WriteLine(numero1 + " * " + numero2 + " = " + multiplicacion);

            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();
        }
    }
}
