﻿Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);


int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triplles! +6 to total!");
    total += 6;
} else if((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 to total!");
    total += 2;
}



if (total >= 16) 
{
    Console.WriteLine("You win a new car!");
} else if (total >= 10) {
    Console.WriteLine("You win a new laptop!");
} else if (total == 7){
    Console.WriteLine("You win a trip!");
} else {
    Console.WriteLine("You won a new kitten!");
}
Console.WriteLine($"Your total {total} ");