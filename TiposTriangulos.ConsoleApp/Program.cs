using System;

namespace TiposTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            do
            {
                Console.WriteLine("\r\n---------------------------------------------------");
                Console.WriteLine("Verificar Triângulo");
                int[] lados = new int[4];
                for (int i = 1; i < lados.Length; i++)
                {
                    do
                    {
                        Console.Write(i + "º lado: ");
                        lados[i] = Convert.ToInt32(Console.ReadLine());
                    } while (lados[i] < 0);
                }

                if ((lados[1] < lados[2] + lados[3]) || (lados[2] < lados[1] + lados[3]) || (lados[3] < lados[1] + lados[2]))
                {
                    if ((lados[1] == lados[2]) && (lados[1] == lados[3]) && (lados[2] == lados[3]))
                    {
                        Console.WriteLine("\r\nTriângulo Equilátero!");
                    }
                    else if ((lados[1] != lados[2]) && (lados[2] != lados[3]) && (lados[1] != lados[3]))
                    {
                        Console.WriteLine("\r\nTriângulo Escaleno!");
                    }
                    else if ((lados[1] == lados[2]) || (lados[2] == lados[3]) || (lados[1] == lados[3]))
                    {
                        Console.WriteLine("\r\nTriangulo Isósceles!");
                    }
                }
                else
                {
                    Console.WriteLine("Triângulo Inválido");
                }

                Console.WriteLine("Deseja para Verificar mais um Tipo de Triângulo?");
                Console.WriteLine("[S]Sim  [N]Não");
                opcao = Convert.ToChar(Console.ReadLine().ToLower());

                if (opcao == 'n' || opcao == 'N')
                {
                    break;
                }
                else
                {
                    continue;
                }

            } while (opcao != 1);
        }
    }
}