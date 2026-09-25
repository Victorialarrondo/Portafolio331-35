using System; 

namespace CS2 { // Espacio de nombres
    class Program { // Clase principal
        static void Main(string[] args){ // Funcion principal
            // Sesión 5: Tipos de datos
            // Sintaxis para declarar variables: " tipo de dato " "nombre de la variable" = " valor de la variable "
            int numero = 5;
            string nombre = "Victoria";
            bool estado = true; // Palabra reservada: Identificador especial predefinido para el compilador
            float flotante = 1.3F;
            double doble = 1.5D;

            Console.WriteLine($"Variable numero: {numero}");
            Console.WriteLine($"Variable nombre: {nombre}");
            Console.WriteLine($"Variable bool: {estado}");
            Console.WriteLine($"Variable flotante: {flotante}");
            Console.WriteLine($"Variable double: {doble}");
        } // Termino de la funcion principal
    } // Termino de la clase principal
} // Termino de espacio de nombres
