using System;

namespace RockPaperScissors
{
    class Program
    {
        private const int Rock = 0;
        private const int Paper = 1;
        private const int Scissors = 2;

        static void Main(string[] args)
        {
            Random randomNumbers = new Random();

            string playerChoice;
            int playerValue = -1;

            int computerValue = randomNumbers.Next(3);
            string computerChoice;

            if (computerValue == Rock)
            { 
                computerChoice = "rock"; 
            }
            else if (computerValue == Paper)
            {
                computerChoice = "paper";
            }
            else
            {
                computerChoice = "scissors";
            }

            Console.Clear();
            Console.Write("Please enter rock, paper or scissors ");
            playerChoice = Console.ReadLine().ToLower();

            if (playerChoice.Equals ("rock"))
            {
                playerValue = Rock;
            }
            else if (playerChoice.Equals ("paper")) 
            {
                playerValue = Paper;
            }
            else if (playerChoice.Equals ("scissors"))
            {
                playerValue = Scissors;
            } 
            else
            {
                Console.WriteLine($"{playerChoice} is not a valid choice");
            }
            
            Console.WriteLine($"Computer chose {computerChoice}, player chose {playerChoice}");

            if (playerValue == computerValue)
            {
                Console.WriteLine("It's a draw");
            }
            else if ((playerValue - 1 == computerValue) || (playerValue == Rock && computerValue == Scissors))
            { 
                Console.WriteLine("Player Wins"); 
            } 
            else
            {
                Console.WriteLine("The computer wins!");
            }
        }
    }
}