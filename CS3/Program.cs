using System;

namespace CS3 {
    class Program {
        static void Main(string[] args) {
            double a = 1;
            double b = 2;
            double resultado = 0;

            resultado = a + b;
            Console.WriteLine($"Suma: {resultado}");
            resultado = a - b;
            Console.WriteLine($"Resta: {resultado}");
            resultado = a * b;
            Console.WriteLine($"Multiplicacion: {resultado}");
            resultado = a / b;
            Console.WriteLine($"Division: {resultado}");
            resultado = a % b;
            Console.WriteLine($"Residuo: {resultado}");

            bool m = false;
            m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
        }
    }
}
