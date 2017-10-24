using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            for(int num = 1; num <= number; num++)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();

            

        }
    }
}
