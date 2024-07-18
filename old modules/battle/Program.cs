int heroHealth = 10;
int monsterHealth = 10;
int heroAttack;
int monsterAttack;
Random attackValue = new Random();

do
{
    heroAttack =  attackValue.Next(1,11);
    monsterHealth = monsterHealth - heroAttack;
    Console.WriteLine($"The monster lost {heroAttack} health. Their remaining health is {monsterHealth}");
    if(monsterHealth <= 0)
    {
        Console.WriteLine("Hero Wins");
        break;
    }
    monsterAttack =  attackValue.Next(1,11);
    heroHealth = heroHealth - monsterAttack;
    Console.WriteLine($"The hero lost {monsterAttack} health. Their remaining health is {heroHealth}");
    if(heroHealth <= 0)
    {
        Console.WriteLine("Monster Wins");
        break;
    }
} while (heroHealth > 0 && monsterHealth > 0);