using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Imprimir en patalla los numeros pares del 0 al 10

            //int num;
            //num = 1;
            //num = num + 1;
            //num++;
            //num += 1;//


            for (int i = 0; i < 10; i = i + 2)
            {
                //Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i = i + 2)
            {
                //Console.WriteLine(i);
            }

            //Factorial  5! 5*4*3*2*1 = 120
            //10!  
            int resultado = 1;
            for (int i = 5; i >= 1; i--)
            {
                resultado = i * resultado;
                //Console.WriteLine(i);
            }
            Console.WriteLine(resultado);

            resultado = 1;
            for (int i = 1; i <= 5; i++)
            {
                resultado = i * resultado;
                //Console.WriteLine(i);
            }
            Console.WriteLine(resultado);


            //sumatoria de n numeros
            resultado = 0;
            for (int i = 1; i <= 5; i++)
            {
                //1+2+3+4+5 = 15
                resultado = i + resultado;
                //Console.WriteLine(i);
            }
            Console.WriteLine(resultado);


            Console.ReadLine();
        }
    }
}
