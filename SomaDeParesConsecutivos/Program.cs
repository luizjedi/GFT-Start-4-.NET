using System;

namespace SomaDeParesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDigitado = int.Parse(Console.ReadLine());

            while (numeroDigitado != 0)
            {
                Console.WriteLine($"{SomaDosPares(numeroDigitado)}");
                numeroDigitado = int.Parse(Console.ReadLine());
            }
        }

        private static int SomaDosPares(int numeroDigitado)
        {
            if (numeroDigitado % 2 == 0)
                return numeroDigitado + (numeroDigitado + 2) + (numeroDigitado + 4) + (numeroDigitado + 6) + (numeroDigitado + 8);
            else 
                return (numeroDigitado + 1) + (numeroDigitado + 3) + (numeroDigitado + 5) + (numeroDigitado + 7) + (numeroDigitado + 9);
        }
    }
}
