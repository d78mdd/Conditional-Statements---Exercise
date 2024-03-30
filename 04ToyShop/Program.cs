using System;

namespace _04ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double ekskurzia = double.Parse(Console.ReadLine());
            int pazeli = int.Parse(Console.ReadLine());
            int kukli = int.Parse(Console.ReadLine());
            int mecheta = int.Parse(Console.ReadLine());
            int minioni = int.Parse(Console.ReadLine());
            int kamioncheta = int.Parse(Console.ReadLine());

            double suma = pazeli * 2.60 + kukli * 3 + mecheta * 4.10 + minioni * 8.20 + kamioncheta * 2;
            int broiIgrachki = pazeli + kukli + mecheta + minioni + kamioncheta;

            double otstapka = 0.0;
            if (broiIgrachki >= 50)
            {
                otstapka = suma * 0.25;
            }
            double krainaCena = suma - otstapka;
            double naem = krainaCena * 0.1;
            double pechalba = krainaCena - naem;
            double ostanali = pechalba - ekskurzia;

            if (ostanali >= 0)
            {
                string ostanaliFormatted = ostanali.ToString("F2");
                Console.WriteLine($"Yes! {ostanaliFormatted} lv left.");
            }
            else
            {
                string ostanaliFormatted = (0 - ostanali).ToString("F2");
                Console.WriteLine($"Not enough money! {ostanaliFormatted} lv needed.");
            }

        }
    }
}
