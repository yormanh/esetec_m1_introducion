using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion16
{
    public class Jugador
    {
        public string nombre;
        public int puntuacion;


        public void SetPuntuacion(int puntos)
        {
            puntuacion = puntuacion + puntos;
        }

        public void ImprimirJugador()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Puntuacion: " + puntuacion);
        }

        public void Mensaje()
        {
            Console.WriteLine("Soy un jugador");
        }


    }

}
