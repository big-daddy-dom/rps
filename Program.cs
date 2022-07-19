using System;
using System.Collections.Generic;
using System.Threading;

bool game = true;
bool choose = false;

char userChoice = 'a';
char computerChoice = 'a';

Console.WriteLine("Welcome to Rock Paper Scissors! What is your name?");
string userName = Console.ReadLine();

while (game)
{
    Console.WriteLine("{0}, would you like to play Rock, Paper, or Scissors?", userName);



    char choice = Console.ReadKey().KeyChar;
    switch (choice)
    {
        case 'r':
            Console.WriteLine("You chose rock");
            userChoice = 'r';
            break;
        case 'p':
            Console.WriteLine("You chose paper");
            userChoice = 'p';
            break;
        case 's':
            Console.WriteLine("You chose scissors");
            userChoice = 's';
            break;
        default:
            Console.WriteLine("You did not choose rock, paper, or scissors");
            Console.WriteLine("Please enter a valid choice");
            break;
    }

    Random roll = new Random();
    int computerRoll = roll.Next(1, 4);
    switch (computerRoll)
    {
        case 1:
            Console.WriteLine("The computer chose rock");
            computerChoice = 'r';
            break;
        case 2:
            Console.WriteLine("The computer chose paper");
            computerChoice = 'p';
            break;
        case 3:
            Console.WriteLine("The computer chose scissors");
            computerChoice = 's';
            break;
        default:
            Console.WriteLine("The computer did not choose rock, paper, or scissors");
            break;
    }

    if (userChoice == computerChoice)
    {
      Console.WriteLine("It's a tie!");
      choose = false;
      game = true;
      Thread.Sleep(1000);
    
    }



}
