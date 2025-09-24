using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe ktora bedzie uzyta do kwadratu i szescianu: ");
            int podanaliczba = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe: ");
            int podanaliczba2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecia liczbe: ");
            int podanaliczba3 = int.Parse(Console.ReadLine());

            double srednia = (podanaliczba + podanaliczba2 + podanaliczba3) / 3;

            int suma = podanaliczba + podanaliczba2 + podanaliczba3;

            Action<string> print = msg => Console.WriteLine(msg.ToUpper());
            if (podanaliczba % 2 == 0)
            {
                print("liczba jest parzysta");
            }
            else
            {
                print("liczba jest nieparzysta");
            }

            Func<int, int> square = x => x * x;

            Func<int, int> szescian = x => x * x * x;

            Func<int, Func<int, int>> utworzmnoznik = mnoznik => x => mnoznik * x;
            var podwojenie = utworzmnoznik(2);
            var potrojenie = utworzmnoznik(3);


            Console.WriteLine($"Liczba: {podanaliczba}\n");

            Console.WriteLine($"Kwadrat: {square(podanaliczba)}\n");

            Console.WriteLine($"Szescian: {szescian(podanaliczba)}\n");

            Console.WriteLine("Srednia wszystkich podanych liczb: "+srednia+"\n");

            Console.WriteLine($"Podwojenie 7: {podwojenie(7)} ");

            Console.WriteLine($"Potrojenie 7: {potrojenie(7)} ");

            Console.WriteLine("Suma wszystkich podanych liczb: " + suma+"\n");
        }
    }
}
