using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("Suurepärane");
            }
            else if (number == 4)
            {
                Console.WriteLine("Väga hea");
            }
            else if (number == 3)
            {
                Console.WriteLine("Hea");
            }
            else if (number == 2)
            {
                Console.WriteLine("Rahuldav");
            }
            else if (number == 1)
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine($"puudulik");
            }




        }
    }
}
