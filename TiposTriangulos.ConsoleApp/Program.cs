using System;

namespace TiposTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lados = new int[4];

            for (int i = 1; i < lados.Length; i++)
            {
                do
                {
                    Console.Write(i + "º lado: ");
                    lados[i] = Convert.ToInt32(Console.ReadLine());
                } while (lados[i] < 0);

                if ((lados[1] < lados[2] + lados[3]) && (lados[2] < lados[1] + lados[3]) && (lados[3] < lados[1] + lados[2]))
                {
                    if ((lados[1] == lados[2]) && (lados[1] == lados[3]) && (lados[2] == lados[3]))
                    {
                        Console.WriteLine("Triângulo Equilátero!");
                    }
                    else if ((lados[1] != lados[2]) && (lados[2] != lados[3]) && (lados[1] != lados[3]))
                    {
                        Console.WriteLine("Triângulo Escaleno!");
                    }
                    else if ((lados[1] == lados[2]) || (lados[2] == lados[3]) || (lados[1] == lados[3]))
                    {
                        Console.WriteLine("Triangulo Isósceles!");
                    }
                }
            }
        }
    }
}