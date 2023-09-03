// See https://aka.ms/new-console-template for more information
var CYAN = "\x1b[38;5;51m";
var GREEN = "\x1b[38;5;82m";
var GOLD = "\x1b[38;5;226m";
var RESET = "\x1b[0m";

string[] choices = {"rock", "paper", "scissors"};
string userChoice = "";
Random rnd = new Random();
const int ROCK = 0;
const int PAPER = 1;
const int SCISSORS = 2;
bool exitFlag = false;
int computer = 0;
while (true) {
    while (true) {
        Console.WriteLine($"{GOLD}Rock, Paper, or Scissors?{RESET}");
        try
        {
            userChoice = Console.ReadLine().Trim().ToLower();
            if (userChoice == "exit") { exitFlag = true; break; }
            if (choices.Contains(userChoice)) { break; }
            else { throw new Exception(userChoice + " is not in the option."); }
        }
        // Catch keyboard inturrupt, say bye and exit.
        catch (Exception)
        {
            Console.WriteLine($"{CYAN}Please enter a valid choice.{RESET}"); continue; 
        }
    }
    if (exitFlag) {return;}

    computer = rnd.Next(0, 3);
    
    Console.WriteLine($"{CYAN}Computer choosed {choices[computer]}.{RESET}");
    if (userChoice == "rock") {
        if (computer == ROCK) { Console.WriteLine($"{GOLD}It's a tie!{RESET}"); }
        else if (computer == PAPER) { Console.WriteLine($"{GOLD}You Loose!{RESET}"); }
        else { Console.WriteLine($"{GREEN}You Win!{RESET}"); }
    }
    if (userChoice == "paper") {
        if (computer == PAPER) { Console.WriteLine($"{GOLD}It's a tie!{RESET}"); }
        else if (computer == SCISSORS) { Console.WriteLine($"{GOLD}You Loose!{RESET}"); }
        else { Console.WriteLine($"{GREEN}You Win!{RESET}"); }
    }
    if (userChoice == "scissors") {
        if (computer == SCISSORS) { Console.WriteLine($"{GOLD}It's a tie!{RESET}"); }
        else if (computer == ROCK) { Console.WriteLine($"{GOLD}You Loose!{RESET}"); }
        else { Console.WriteLine($"{GREEN}You Win!{RESET}"); }
    }
}