// See https://aka.ms/new-console-template for more information

var CYAN = "\x1b[38;5;51m";
var GREEN = "\x1b[38;5;82m";
var GOLD = "\x1b[38;5;226m";
var RESET = "\x1b[0m";

Console.WriteLine($"{CYAN}After Ready, you have to wait for 10 seconds in your head. When you think 10 seconds is over, Press Enter to see how much accurate you were.\n{RESET}");
Console.Write($"{GOLD}Ready?{RESET}");
Console.ReadLine();
var timerStart = DateTime.Now;
Console.Write($"{GOLD}Press enter after 10 second...{RESET}");
Console.ReadLine();
var timerEnd = DateTime.Now;
var offset = timerEnd - timerStart;
Console.WriteLine($"{GREEN}{offset}{RESET}");