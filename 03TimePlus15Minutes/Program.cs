using System;

namespace _03TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());


            int hours = (hour + (minute + 15) / 60) % 24;
            int minutes = (minute + 15) % 60 ;


            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
