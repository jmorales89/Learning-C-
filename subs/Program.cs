Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercnetage = 0;

if(daysUntilExpiration > 1 && daysUntilExpiration <= 10) {
    discountPercnetage = 10;
} 
else if(daysUntilExpiration == 1)
{
    discountPercnetage = 20;
}

if(daysUntilExpiration == 0 )
{
    Console.WriteLine("Your subscription has expired.");
} 
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercnetage}%!");
} 
else if (daysUntilExpiration > 1 && daysUntilExpiration <= 10)
{
    Console.WriteLine($"Your subscription expires {daysUntilExpiration} in days.\nRenew now and save {discountPercnetage}%.");
} else {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}