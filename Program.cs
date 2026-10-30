using System;
// Espacio de nombres
namespace CS7
{
    // Clase Principal
    class Program
    {
        // Función principal
        static void Main(string[] args)
        {
            // Bloque de la función
            // Sesion 15: funciones 15102026
            /*
            Función: Bloque de instrucciones para realizar una tarea específica, que se ejecuta, únicamente, cuando es invocada.
            Sintaxis
            tipo_dato_devuelto identificador_función(paramétros)
            {
                Bloque de instrucciones
            }
            Nota 1: Los parámetros se definen incluyendo tipo de dato. 
            Nota 2: Los parámetros van a ser separados por comas.
            Sintaxis: Invocación función
            identificador_función(argumentos);
            Argumento: El valor del párametro.
            */
            // Ejemplo 1: Función vacía sin parámetros
            // Definición
            void Saludar()
            {
                string salón = "Exactas 331";
                Console.WriteLine($"Hola, {salón}!");
            }
            // Invocación
            Saludar(); 
            // Ejercitación
            // 1. Definir e invocar una función sin parámetros para imprimir: nombre, clave y salón.
            void Datos()
            {
                string nombre = "Victoria";
                string clave = "331-35";
                string salón = "Exactas 331";
                Console.WriteLine($"Nombre: {nombre}, Clave: {clave}, Salón: {salón}");
            }
            Datos();
            // 2. Definir e invocar una función sin parámetros para desplegar el horario de hoy.
            void Horario()
            {
                string jueves_7_00 = "Cálculo";
                string jueves_7_50 = "FH";
                string jueves_8_40 = "Programación";
                string jueves_9_50 = "Psicología";
                string jueves_10_40 = "Francés";
                string jueves_11_50 = "Dibujo";
                Console.WriteLine($"Horario de hoy: {jueves_7_00}, {jueves_7_50}, {jueves_8_40}, {jueves_9_50}, {jueves_10_40} y {jueves_11_50}");
            }
            Horario();
            // Sesión 16: funciones con parámetros
            // return: palabra reservada terminar una función y devolver una expresión
            // Ejemplo 1: Doble
            int CalcularDoble(int número)
            {
                int resultado = 2 * número;
                return resultado;
            }
            // Invocación
            int devolución;
            devolución = CalcularDoble(3);
            Console.WriteLine($"Devolución: {devolución}");
            // 1. Definir e invocar una función que devuelva el resultado de la siguiente expresión: f(x) = 4x - 7/5
            double CalcularExpresión(double x)
            {
                double resultado = (4 * x - 7) / 5;
                return resultado;
            }
            double devolución2;
            devolución2 = CalcularExpresión(3);
            Console.WriteLine($"Devolución: {devolución2}");        
        } // Término función principal
    }  // Término clase principal
} // Término espacio de nombres