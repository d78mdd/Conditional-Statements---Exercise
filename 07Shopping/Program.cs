using System;

namespace _07Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double biodzhet = double.Parse(Console.ReadLine());
            int videokarti = int.Parse(Console.ReadLine());
            int procesori = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());



            double sumaZaVideokarti = videokarti * 250;
            
            double cenaZa1Procesor = 0.35 * sumaZaVideokarti;
            double sumaZaProcesori = procesori * cenaZa1Procesor;

            double cenaZa1Ram = 0.1 * sumaZaVideokarti;
            double sumaZaRam = ram * cenaZa1Ram;



            double obshtaSuma = sumaZaVideokarti + sumaZaProcesori + sumaZaRam;



            double krainaCena;
            if (videokarti > procesori)
            {
                double otstapka = 0.15;
                krainaCena = (1 - otstapka) * obshtaSuma;
            } else
            {
                krainaCena = obshtaSuma;
            }



            if (krainaCena <= biodzhet)
            {
                string ostavat = (biodzhet - krainaCena).ToString("F2");
                Console.WriteLine($"You have {ostavat} leva left!");
            }
            else
            {
                string neStigat = (krainaCena - biodzhet).ToString("F2");
                Console.WriteLine($"Not enough money! You need {neStigat} leva more!");
            }
        }
    }
}
