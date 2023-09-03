// See https://aka.ms/new-console-template for more information
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

var CYAN = "\x1b[38;5;51m";
var GREEN = "\x1b[38;5;82m";
var GOLD = "\x1b[38;5;226m";
var RESET = "\x1b[0m";

Console.WriteLine($"{GREEN}This program uses JokeAPI from https://jokeapi.dev/ to get jokes from internet.\nThis program is to show my ability to handel JSON Response or even use of API.\n{RESET}");

var url = "https://v2.jokeapi.dev/joke/Any?type=twopart";


using (HttpClient client = new HttpClient())
{
    string json = await client.GetStringAsync(url);
    // Use the JSON string as needed
    Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
    Console.WriteLine($"{GOLD}{dictionary["setup"]}{RESET}");
    Console.Write($"{CYAN}Press Enter to show punchline...{RESET}"); Console.Read();
    Console.WriteLine($"{GOLD}{dictionary["delivery"]}{RESET}");
    Console.ResetColor();
}



