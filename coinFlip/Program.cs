Random headsOrTails = new Random();
int coinFlip = headsOrTails.Next(0, 2);
string flipResult = coinFlip > 0 ? "heads" : "tails";

Console.WriteLine($"Coin flip result is {flipResult}!");
