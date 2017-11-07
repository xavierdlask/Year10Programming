﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        private static void playGame()
        {
            // Define array of answers
            string[] answers = {"Maybe", "Yes", "No", "It is certain",
                                "Unsure, ask again", "All signs point to yes",
                                "Most likely", "Reply hazy, try again",
                                "Definitely not" };
            // Prompt user
            Console.WriteLine("Ask me a question (or type 'exit): ");

            // Only play the game if the user doesn't type 'exit'
            if (Console.ReadLine() != "exit")
            {
                // Pick a random answer
                Random rnd = new Random();

                // Print out random item from array
                Console.WriteLine(answers[rnd.Next(9)]);

                // Blank line
                Console.WriteLine("");

                // Go again
                playGame();

            }
        }
    }
}
