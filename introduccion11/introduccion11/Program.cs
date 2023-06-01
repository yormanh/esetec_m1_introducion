using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int valor = random.Next(100);
            int valor2 = random.Next(100);

            Console.WriteLine(valor);
            Console.WriteLine(valor2);
            Console.WriteLine(valor + valor2);

            Console.ReadLine();
        }
    }
}
