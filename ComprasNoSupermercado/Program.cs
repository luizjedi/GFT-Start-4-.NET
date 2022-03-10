using System;
using System.Collections.Generic;
using System.Linq;

class ComprasNoSupermercado
{
    public static void Main(string[] args)
    {
        int totalDeCasosDeTeste = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalDeCasosDeTeste; i++)
        {
            List<string> listDeCompras = new List<string>(Console.ReadLine().Split(' '));
            List<string> listaSemDuplicados = listDeCompras.Distinct().ToList();
            listaSemDuplicados.Sort();

            foreach (var itens in listaSemDuplicados)
            {
                Console.Write($"{itens} ");
            }

            Console.WriteLine(" ");
        }
    }
}