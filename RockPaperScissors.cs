using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            Console.Write("Choose: [r]ock, [p]aper, [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }

            Random randomNumber = new Random();
            int randomNumberPC = randomNumber.Next(1, 4);

            string pcMove = string.Empty;

            switch (randomNumberPC)
            {
                case 1:
                    pcMove = Rock;
                    break;
                case 2:
                    pcMove = Paper;
                    break;
                case 3:
                    pcMove = Scissors;
                    break;
            }
            Console.WriteLine($"The computer chose {pcMove}.");

            if ((playerMove == Rock && pcMove == Scissors) ||
                (playerMove == Paper && pcMove == Rock) ||
                (playerMove == Scissors && pcMove == Paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove == Rock && pcMove == Paper) ||
                 (playerMove == Paper && pcMove == Scissors) ||
                 (playerMove == Scissors && pcMove == Rock))
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }

        }
    }
}
