using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said:");
            string number = Console.ReadLine();

            switch (number)
            {
                case "5":
                    Console.WriteLine("suurepärane");
                    break;
                case "4":
                    Console.WriteLine("Väga hea");
                    break;
                case "3":
                    Console.WriteLine("Hea");
                    break;
                case "2":
                    Console.WriteLine("Rahuldav");
                    break;
                case "1":
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Puudulik");
                    break;
            }
        }
    }
}
