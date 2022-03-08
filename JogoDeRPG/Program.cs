using JogoDeRPG.src.Entities;
using System;

namespace JogoDeRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new("Arus", 23, "Knight");
            Wizard wizard = new("Jennica", 23, "White Wizard");
            BlackWizard blackWizard = new("Topapa", 42, "Black Wizard");
            Ninja ninja = new("Wedge", 57, "Ninja");


            Console.WriteLine(arus.ToString());
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(blackWizard.ToString());
            Console.WriteLine(ninja.ToString());
            Console.WriteLine();
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(55));
            Console.WriteLine(wizard.Attack(5));
            Console.WriteLine(blackWizard.Attack(7));
            Console.WriteLine(blackWizard.Attack(1));
            Console.WriteLine(ninja.Attack(7));
            Console.WriteLine(ninja.Attack(1));
        }
    }
}
