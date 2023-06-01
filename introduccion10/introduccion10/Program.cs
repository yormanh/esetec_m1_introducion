using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                MiNota(i);
            }

            GetMiNota(50);

            Console.ReadLine(); //parar la consala al final
        }

        static public void GetMiNota(int nota)
        {
            string notaString = "";
            switch(nota)
            {
                case 0: 
                case 1:
                case 2:
                case 3:
                case 4:
                    notaString = "Supendido";
                    break;
                case 5:
                case 6:
                    notaString = "Aprobado";
                    break;
                case 7:
                case 8:
                    notaString = "Notable";
                    break;
                case 9:
                case 10:
                    notaString = "Sobresaliente";
                    break;
                default:
                    notaString = "Valor no esperado";
                    break;
            }

            Console.WriteLine(notaString);
        }

        static public void MiNota(int nota)
        {
            //0 al 4: supendido
            //5 6: aprobado
            //7 8 notable
            //9 10 sobresaliente;
            //int nota = 5;

            if (nota >= 0 && nota < 5)
            {
                Console.WriteLine("Supendido");
            }
            if (nota >= 5 && nota <= 6)
            {
                Console.WriteLine("Aprobado");
            }
            if (nota >= 7 && nota <= 8)
            {
                Console.WriteLine("Notable");
            }
            if (nota >= 9 && nota <= 10)
            {
                Console.WriteLine("Sobresaliente");
            }

        }
    }
}
