using System;
// Espacio de nombres
namespace SE2
{
    // Clase principal
    class Program
    {
        // Función principal
        static void Main(string[] args)
        {
            // Bloque de Instrucciones
            // Sesión 17: Solución de examen
            //1. Sintaxis: Función
            /*
            tipo_dato_devuelto identificador_función(paramétros)
            {
                Bloque de instrucciones
            }
            */
            //2. Ciclo ascendente 
            int i=2;
            while(i<=27)
            {
                Console.WriteLine($"i: {i}");
                if(i < 6)
                {
                    i += 2;
                }
                else if(i < 15)
                {
                    i += 3;
                }
                else if(i < 27)
                {
                    i += 4;
                }
            }
            // 3. Ciclos
            int inicio = 9;
            int limite = 22;
            int producto;
            producto = inicio * limite;
            if(producto < 8 && inicio > limite)
            {
                // Bloque de instrucciones
                // Ciclo descendente de 9 ejecuciones
                int m = 9;
                while(m >= 1)
                {
                    m -= 1;
                }
            }
            else
            {
                // Bloque de instrucciones
                // Ciclo ascendente
                int n = 3;
                while(n <= 8)
                {
                    n += 1;
                }
            }
            // 4. Múltiplo de 5
            bool CalcularMúltiplo(int número)
            {
                bool resultado = false;
                if(número % 5 == 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            bool resultado = CalcularMúltiplo(32);
            Console.WriteLine($"Devolución: {resultado}");
            // 5. Función vacía
            void ImprimirTexto(string materia)
            {
                Console.WriteLine($"Materia: {materia}");
            }
            ImprimirTexto("Programación III");
        } // Término función principal
    } // Término clase principal
} // Término espacio de nombres