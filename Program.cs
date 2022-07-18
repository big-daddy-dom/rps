//write a rock paper scissors game, human vs computer
//use a random number generator to generate the computer's choice
using System;
using System.Threading;
using System.Collections.Generic;   

bool running = true;
while (running)
{
Console.WriteLine("Welcome to Rock Paper Scissors!");
Console.WriteLine("Please enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name + "!");
Console.WriteLine("Please enter your choice: (R = Rock, P = Paper, S = Scissors) ");
char input = Console.ReadKey().KeyChar;
Console.WriteLine();
}




public class Moves
{
  public List<Move> moves = new List<Move>(){
    
  };

};