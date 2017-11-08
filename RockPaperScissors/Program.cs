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
            // Code for printing the score
        }
        private static string UserTurn()
        {
            return "Rock";
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
        private static void updateScores(string result, ref int computerScore)
        {

        }
    }
}
