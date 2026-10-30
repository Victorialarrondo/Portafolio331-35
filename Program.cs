// Victoria Sanchez 331-35

using System;

namespace CSTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia = 21000;
            double zancada = 0.63;
            double recorrido = 0;
            int zancadas = 0;

            while (recorrido < distancia)
            {
                recorrido = recorrido + zancada;
                zancadas = zancadas + 1;
            }

            Console.WriteLine("Zancadas que necesitara: " + zancadas);
            // 1. Ciclo for
            /* Sintaxis; ciclo for
            for (inicialización; expresión; iterador)
            {
                // Bloque de instrucciones
            }
            */
            //Ejemplo: Secuencia 35-41
            for (int m = 35; m <= 41; m++)
            {
                Console.WriteLine(m);
            }
        } // Término función principal
    } // Término clase principal
} // Término espacio de nombres