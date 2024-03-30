using System;

namespace _05GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double biodzhet = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double cenaObleklo = double.Parse(Console.ReadLine());

            double sumaZaDekor = biodzhet * 0.1;
            double sumaZaObleklo = statisti * cenaObleklo;

            double otstapka = 0.0;
            if (statisti > 150)
            {
                otstapka = sumaZaObleklo * 0.1;
            }

            double obshtaSumaZaFilma = sumaZaDekor + (sumaZaObleklo - otstapka);

            double ostanali = biodzhet - obshtaSumaZaFilma;

            if (ostanali >= 0)
            {
                string ostanaliFormatted = ostanali.ToString("F2");
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with { ostanaliFormatted } leva left.");
            }
            else
            {
                string ostanaliFormatted = (0 - ostanali).ToString("F2");
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {ostanaliFormatted} leva more.");
            }

        }
    }
}
