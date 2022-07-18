// See https://aka.ms/new-console-template for more information
// JS (Import) CS Using; 
// every line ends with a semicolon (;)
//upper camel case for class names, lower camel case for variables and functions
using System;
using System.Threading;
Random choice = new Random();
bool playing = true;
string player;
string computer;

while (playing)
{
    Console.WriteLine("Rock, Paper, Scissors, Die:");
string playerChoice = Console.ReadLine();
int computerChoice = choice.Next(1, 4);
switch (computerChoice)
{
    case 1:  Console.WriteLine("PC picked rock");
    break;
case 2: Console.WriteLine("pc picked paper");
break;
case 3: Console.WriteLine("pc picked scissors");
break;

};
if (playerChoice == "1")
{
    Console.WriteLine("rock");
    break;
}
else if (playerChoice == "2")
{
    Console.WriteLine("paper");
    break;

}
else {
    Console.WriteLine("scissors");
    break;
}

Thread.Sleep(1500);
Console.Clear();
Console.WriteLine();



}



