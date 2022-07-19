//write a rock paper scissors game, human vs computer
//use a random number generator to generate the computer's choice
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
            string playerChoice;
            string computerChoice;
            int playerScore = 0;
            int computerScore = 0;
            int ties = 0;
            int round = 1;
            string playAgain;

            do
            {
                Console.WriteLine("Welcome to Rock Paper Scissors!");
                Console.WriteLine("Please enter your choice: (R)ock, (P)aper, (S)cissors");
                playerChoice = Console.ReadLine();
                playerChoice = playerChoice.ToUpper();
                Random rnd = new Random();
                int computerNumber = rnd.Next(1, 4);
                if (computerNumber == 1)
                {
                    computerChoice = "ROCK";
                }
                else if (computerNumber == 2)
                {
                    computerChoice = "PAPER";
                }
                else
                {
                    computerChoice = "SCISSORS";
                }
                Console.WriteLine("The computer chose " + computerChoice + ".");
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                    ties++;
                }
                else if (playerChoice == "ROCK")
                {
                    if (computerChoice == "PAPER")
                    {
                        Console.WriteLine("The computer wins!");
                        computerScore++;
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                        playerScore++;
                    }
                }
                else if (playerChoice == "PAPER")
                {
                    if (computerChoice == "SCISSORS")
                    {
                        Console.WriteLine("The computer wins!");
                        computerScore++;
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                        playerScore++;
                    }
                }
                else if (playerChoice == "SCISSORS")
                {
                    if (computerChoice == "ROCK")
                    {
                        Console.WriteLine("The computer wins!");
                        computerScore++;
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                        playerScore++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
                Console.WriteLine("Your score is " + playerScore + ".");
                Console.WriteLine("The computer's score is " + computerScore + ".");
                Console.WriteLine("There have been " + ties + " ties.");
                Console.WriteLine("Round " + round + " is over.");
                round++;
                Console.WriteLine("Would you like to play again? (Y/N)");
                playAgain = Console.ReadLine();
                playAgain = playAgain.ToUpper();
            } while (playAgain == "Y");
            Console.WriteLine("Thanks for playing!");
        }
    }
}


