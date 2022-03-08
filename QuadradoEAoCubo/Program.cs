using System;

namespace QuadradoEAoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {AoQuadrado(i)} {AoCubo(i)}");
            }

        }
        static int AoQuadrado(int numeroLido)
        {
            return numeroLido * numeroLido;
        }
        static int AoCubo(int numeroLido)
        {
            return numeroLido * numeroLido * numeroLido;
        }
    }
}
