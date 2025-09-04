using System;

namespace PerimetroCuadrado 
{
    class Program
    {
        static void Main(string[] args)
        {
            // int lado, perimetro;
            Console.WriteLine("Longitud del lado del cuadrado:");
            int lado = Console.ReadLine();

            int perimetro = lado * 4;
            
            Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
            Console.ReadKey();
        }
    }
}
