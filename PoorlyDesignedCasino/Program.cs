using System;

namespace PoorlyDesignedCasino
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            double odds = random.Next(-50, 100);
            Guy player = new Guy() { Cash = 1000, Name = "Player One" };
            Console.WriteLine("Welcome to the Poorly Designed Casino, where the odds are almost never in your favor! Today's odds are: " + odds);
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("Please place your bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You have won: " + winnings + " dollars.");
                            player.ReceiveCash(winnings);
                        } else
                        {
                            Console.WriteLine("Sorry, you have lost. Better luck next time!");
                        }
                    }
                } else
                {
                    Console.WriteLine("Please enter a valid bet amount.");
                }
                if (player.Cash == 0)
                {
                    Console.WriteLine("Uh Oh... your balance has reached zero dollars, might be time to sell the house?");

                }
            }
        }
    }
}