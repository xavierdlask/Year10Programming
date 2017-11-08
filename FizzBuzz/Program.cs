using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop 100 times
            for (int i = 1; i <= 100; i++)
            {
                // If divisible by both 3 and 5
                if (1 % 3 ==0 && 1 % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // If divisible by 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // if divisable by 5
                else if (1 % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Otherwise, Just print the number
                else
                {
                    Console.WriteLine(i);
                }
            }
            //Wait
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
