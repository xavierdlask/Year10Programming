using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int computerScore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "draw";
                PrintScore(ref userScore, ref computerScore);
                string userChoice = UserTurn();
                string computerChoice = ComputerTurn();
                result = DetermineWinner(userChoice, computerChoice);
                Givefeedback(result, userChoice, computerChoice);
                updateScores(result, ref userScore, ref computerScore);
                repeat = PlayAgain();
            }
        }

        private static void updateScores(string result, ref int userScore, ref int computerScore)
        {
            throw new NotImplementedException();
        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.Clear();
            Console.WriteLine("User: " + userScore + "   Computer: " + computerScore);
        }
        private static string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                Console.Write("Your Choice: ");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                return "Rock";
            }
            else if (choice == "2")
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }
        private static string ComputerTurn()
        {
            return "Paper;";
        }
        private static string DetermineWinner(string user, string computer)
        {
            return "User";
        }
        private static void Givefeedback(string result, string userChoice, string computerChoice)
        {

        }
        private static bool PlayAgain()
        {
            return true;
        }
        private static void UpdateScore(string result, ref int userScore, ref int computerScore)
        {

        }
    }
}
