using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "yes";
            while (menu == "yes")
            {
                Console.WriteLine("Pick a door");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Behind door 1 is a beast");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Behind door 2 is Ziggy the homo");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Behind door 3 is Luke the pussi");
                }
                else
                {
                    Console.WriteLine("Big doinks in Armish");
                }

                Console.WriteLine("\nDo you want to try again? yes/no");
                menu = Console.ReadLine();
            }           
        }
    }
}
