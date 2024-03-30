using System;

namespace _08LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string imeNaSerial = Console.ReadLine();
            int prodaljitelnostNaEpizod = int.Parse(Console.ReadLine());
            int prodaljitelnostNaPochivkata = int.Parse(Console.ReadLine());


            double vremeZaObqd = prodaljitelnostNaPochivkata * (1.0 / 8.0);
            double vremeZaOtdih = prodaljitelnostNaPochivkata * (1.0 / 4.0);
            double ostanaloVreme = prodaljitelnostNaPochivkata - vremeZaObqd - vremeZaOtdih;


            if (ostanaloVreme >= prodaljitelnostNaEpizod)
            {
                int ostanaloVremeZakragleno = (int)Math.Ceiling(ostanaloVreme);
                int freeTime = ostanaloVremeZakragleno - prodaljitelnostNaEpizod;
                Console.WriteLine($"You have enough time to watch {imeNaSerial} and left with {freeTime} minutes free time.");
            }
            else
            {
                int neededTime = (int)Math.Ceiling(prodaljitelnostNaEpizod - ostanaloVreme);
                Console.WriteLine($"You don't have enough time to watch {imeNaSerial}, you need {neededTime} more minutes.");
            }

        }
    }
}
