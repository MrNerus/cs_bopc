// See https://aka.ms/new-console-template for more information
var CYAN = "\x1b[38;5;51m";
var GREEN = "\x1b[38;5;82m";
var GOLD = "\x1b[38;5;226m";
var RESET = "\x1b[0m";
Random rnd = new Random();
int card = rnd.Next(1, 14);
int suit = rnd.Next(1, 5);
Dictionary<int, string> cardMap = new Dictionary<int, string>(){
    {1, "Ace"},
    {11, "Jack"},
    {12, "Queen"},
    {13, "King"}
};
Dictionary<int, string> suitMap = new Dictionary<int, string>(){
    {1, "Spade"},
    {2, "Heart"},
    {3, "Club"},
    {4, "Diamond"}
};

Console.Write($"{GOLD}{(cardMap.ContainsKey(card)? cardMap[card]: card)}{RESET}");
Console.Write($"{CYAN} of {RESET}");
Console.Write($"{GREEN}{(suitMap.ContainsKey(suit)? suitMap[suit]: suit)}{RESET}");

