using System;

namespace _06WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {

            double rekord = double.Parse(Console.ReadLine());
            double razstoianie = double.Parse(Console.ReadLine());
            double vremeZa1Metar = double.Parse(Console.ReadLine());

            double triabvaDaPrepluvaZaVreme = razstoianie * vremeZa1Metar;
            double dobaveniSekundi = Math.Floor(razstoianie / 15) * 12.5;

            double obshtoVreme = triabvaDaPrepluvaZaVreme + dobaveniSekundi;

            double razlika = rekord - obshtoVreme;

            if (razlika > 0)
            {
                string obshtoVremeFormatted = obshtoVreme.ToString("F2");
                Console.WriteLine($"Yes, he succeeded! The new world record is {obshtoVremeFormatted} seconds.");
            }
            else
            {
                string razlikaFormatted = (0 - razlika).ToString("F2");
                Console.WriteLine($"No, he failed! He was {razlikaFormatted} seconds slower.");
            }
        }
    }
}
