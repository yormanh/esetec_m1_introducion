using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAlumnos = 10;
            GenerarNotas(numeroAlumnos);
            //SumarNotas(numeroAlumnos);
            MayorNota(numeroAlumnos);
            Console.ReadLine();
        }

        //Metodo que nos dice cual es la mayor nota que sea ha puesto
        //generando n notas aleatorias
        static public void MayorNota(int numeroAlumnosInterno)
        {
            int[] notas = new int[numeroAlumnosInterno];
            int numeroMayor = 0;
            Random rand = new Random();

            //Generar las notas aleatoriamente
            for (int i = 0; i < numeroAlumnosInterno; i++)
            {
                notas[i] = rand.Next(10);
            }

            //Calculando mayor
            for(int i = 0; i< numeroAlumnosInterno; i++)
            {
                if (numeroMayor < notas[i])
                {
                    numeroMayor = notas[i];
                }
            }
            Console.WriteLine(numeroMayor);


            //Cuantas personas han sacado la mayor nota
            int numeroDeMayorNota = 0;
            for (int i = 0; i < numeroAlumnosInterno; i++)
            {
                if (notas[i] == numeroMayor)
                {
                    numeroDeMayorNota++; // cantidadDeNotasMayores = cantidadDeNotasMayores + 1
                }
            }
            Console.WriteLine(numeroDeMayorNota);



            //Imprimiendo todas las notas
            for (int i = 0; i < numeroAlumnosInterno; i++)
            {
                Console.Write(notas[i] + " ");
            }



        }

        static public void SumarNotas(int numeroAlumnosInterno)
        {
            
            int[] notas = new int[numeroAlumnosInterno];
            int[] notas2 = new int[numeroAlumnosInterno];

            Random rand = new Random();

            for (int i = 0; i < numeroAlumnosInterno; i++)
            {
                notas[i] = rand.Next(10); //soy un vago y no quiero escribir la nota de 100 alumnos
                notas2[i] = rand.Next(10);//genera un numero aleatorio
            }

        }

        static public void GenerarNotas(int numeroAlumnosInterno)
        {
            int[] notas = new int[numeroAlumnosInterno];
            int suma = 0, mediaNota = 0;

            Random rand = new Random();
            //int valor = rand.Next(10);

            //Generar las notas aleatoriamente
            for(int i = 0; i < numeroAlumnosInterno; i++)
            {
                notas[i] = rand.Next(10);
            }

            //suma todas las notas
            for (int i = 0; i < numeroAlumnosInterno; i++)
            {
                suma = suma + notas[i];
            }
            Console.WriteLine(suma);
            mediaNota = suma / numeroAlumnosInterno;
            Console.WriteLine(mediaNota);

            //Impmirmirlo en pantalla o mostrarlo
            for (int i = 0; i < numeroAlumnosInterno; i++)
            {
                Console.WriteLine(notas[i]);
            }


        }
    }
}
