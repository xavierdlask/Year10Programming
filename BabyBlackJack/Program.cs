using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = 10;
            playGame(ref money);
        }

        private static void playGame(ref float money)
        {
            Console.Clear();
            float betAmount = MakeBet(ref money);
            Random rnd = new Random();
            int playerTotal = DealCards(rnd, "You");
            int dealerTotal = DealCards(rnd, "The Dealer");
            bool playerWins = determineWinner(playerTotal, dealerTotal);
            PayOut(playerWins, betAmount, ref money);
            Menu(ref money);
        }














        private static float MakeBet(ref float money)
        {
            float betAmount = 0;
            bool validBet = false;

            Console.WriteLine("Enter your bet. You have $" + money);

            while (validBet != true)
            {
                validBet = float.TryParse(Console.ReadLine(), out betAmount);

                if(betAmount > money)
                {
                    Console.WriteLine("Sorry, you do not have enough. Try again.");
                    validBet = false;
                }
                else if (betAmount <0)
                {
                    Console.WriteLine("Sorry you cannon bet a negative amount. Try again.");
                    validBet = false;
                }
            }

            money = money - betAmount;
            return betAmount;
        }

        private static int DealCards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card2;
            Console.WriteLine(player + " drew " + card1 + " and " + card2 + " for a total of " + total);
            return total;
        }

        private static bool determineWinner(int player, int dealer)
        {
            if (player > dealer)
            {
                Console.WriteLine("You win!");
                return true;
            }
            else if (player < dealer)
            {
                Console.WriteLine("You lose!");
                return false;
            }
            else
            {
                Console.WriteLine("It's a draw! dealer still wins!");
                return false;
            }
        }

        private static void PayOut(bool playerWins, float betAmount, ref float money)
        {
            if (playerWins)
            {
                money = money + (betAmount * 2);
            }
        }

        private static void Menu(ref float money)
        {
            Console.Write("Would you like another game? y/n");
            if (Console.ReadLine() == "y")
            {
                playGame(ref money);
            }
        }
    }
}
