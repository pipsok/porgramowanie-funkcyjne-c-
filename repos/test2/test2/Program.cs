using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("siemanko ile pijesz kaw codziennie");
            int kawycodz = int.Parse(Console.ReadLine());
            Console.WriteLine("ile masz lat?");
            int lata = int.Parse(Console.ReadLine());
            Console.WriteLine("ile dziennie programujesz");
            int godzinyprogramowania = int.Parse(Console.ReadLine());

            int dnidoemerytury = (65 - lata) * 365;
            int kawywroku = 365 * kawycodz;
            int kawydoemerytury = kawycodz * dnidoemerytury;
            int godzinykodowaniawroku = godzinyprogramowania * 365;

            double procentzyciaprogramowania = godzinyprogramowania / 24 * 100;


        }
    }
}