int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach (int qty in inventory)
{
    sum += qty;
    bin++;
    Console.WriteLine($"Bin {bin} = {qty} qty (Running total: {sum})");
}
    Console.WriteLine($"We have {sum} items in inventory");