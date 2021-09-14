using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled ükssarvik";

            Console.WriteLine("Mis su lemmik värv on:");
            string usercolor = Console.ReadLine();

            switch (usercolor)
            {
                case "punane":
                    Console.WriteLine("oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"oled {usercolor} ükssarvik.");
                    break;
            }
        }
    }
}
