using System;

namespace PerimetroCuadrado 
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;
            Console.WriteLine("Longitud del lado del cuadrado:");
            linea = Console.ReadLine();
            lado=int.Parse(linea);

            perimetro = lado * 4;

            Console.WriteLine($"El perímetro del cuadrado es:");
            Console.WriteLine(perimetro);
            Console.ReadKey();
        }
    }
}