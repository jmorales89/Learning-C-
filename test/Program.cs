Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercnetage = 0;

// higher message priority

// if days to expiration is <=10 
// display Your subscription will expire soon. Renew now!

// if 5 days or less to expiration
// display Your subscription expires in _ days. Renew now and save 10%!


//if 1 day till expiration
// Your subscription expires within a day! Renew now and save 20%!

// if expired 
// display Your subscription has expired.
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
    console.WriteLine("Your subscription will expire soon. Renew now!");
}