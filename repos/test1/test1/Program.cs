using System;
using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Random rnd = new Random();
            int liczba = rnd.Next(1,101);
            int input = int.Parse(Console.ReadLine());
            int proby = 0;
            while (input != liczba) {
                proby++;
                input = int.Parse(Console.ReadLine());
                if (input != liczba)
                {
                    Console.WriteLine("niestety nie zgadles sporobj jeszcze raz, proby: " + proby);
                }
            }
            if (input == liczba) {
                Console.WriteLine("brawo zgadles, prob:" + proby);
                if (proby == 1) {
                    Console.WriteLine("wow zgadles za pierwszym razem brawo !!!!!!!!!!!!!");
                }
            }
            Console.WriteLine();
            
        }
    }
}