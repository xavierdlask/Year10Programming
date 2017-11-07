using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // Ask for your name
            string name = GetName();

            // Generate a random insult
            GenerateInsult(name, rnd);
        }
        private static string GetName()
        {
            Console.WriteLine("Welcome to the Insult Generator. What is your Name?");
            return Console.ReadLine();
        }
        private static void GenerateInsult(string name, Random rnd)
        { 
            Console.WriteLine(name + ", you are " + GetAdjective(rnd) + " " + GetCompoundAdjective(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }
        private static void Menu(string name, Random rnd)
        {
            Console.ReadKey();
        }

        private static string GetAdjective(Random rnd)
        {
            string[] adjective = { "a grubby", "a fat ass", "a little", "a cracky", "a triggered", "A memed" };
            return adjective[rnd.Next(6)];
        }
        private static string GetCompoundAdjective(Random rnd)
        {
            string[] CompoundAdjective = { "no-good", "self-loathing", "meme-loving", "big-headed", "rage-inducing" };
            return CompoundAdjective[rnd.Next(5)];
        }
        private static string GetObject(Random rnd)
        {
            string[] objects = { "fart", "crack head", "nugget", "child", "3-yr-old" };
            return objects[rnd.Next(5)];
        }
    }
}
