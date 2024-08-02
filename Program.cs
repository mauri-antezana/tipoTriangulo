using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.WriteLine("Inserte el valor del lado A: ");
            ladoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el valor del lado B ");
            ladoB = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el valor del lado C: ");
            ladoC = int.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
            Console.WriteLine($"El triangulo es: {triangulo.identificarTriangulo()}");
        }
    }
}
