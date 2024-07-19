// string [] students = {"Jenna", "Ayesha", "Carlos", "Victor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert", "Vanya"});

// void DisplayStudents(string[] students)
// {
//     foreach (string student in students)
//     {
//         Console.Write($"{student}, " );
//     }
//     Console.WriteLine();
// };

// double pi = 3.141549; 
// PrintCircleInfo(12);
// PrintCircleInfo(24);

// void PrintCircleInfo(int radius)
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);

// }


// void PrintCircleArea(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Area = {circumference}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);

// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c)
// {
//     c = a * b;
//     Console.WriteLine($"inside statement: {a} x {b} = {c}");


// }



// int [] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//     foreach (int i in array)
//     {
//         Console.Write($"{i} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
// }




// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if(guest == name)
//             {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//     {
//         Console.WriteLine($"Sorry, {name} is not on the guest list");
//         return;
//     }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }
// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();



string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string corporateDomain = "contoso.com";
void PrintEmails(string[,] corporate, string[,] external)
{

    for (int i = 0; i < corporate.GetLength(0); i++) 
    {
        string emailFirst = corporate[i,0].Substring(0, 2).ToLower();
        string emailLast = corporate[i,1].ToLower();
        Console.WriteLine($"{emailFirst}{emailLast}@{corporateDomain}");
        // display internal email addresses
        // Console.WriteLine($"{corporate[i]}@{corporateDomain}");
    }

    for (int i = 0; i < external.GetLength(0); i++) 
    {
        // display external email addresses
       string emailFirst = external[i,0].Substring(0, 2).ToLower();
       string emailLast = external[i,1].ToLower();
        Console.WriteLine($"{emailFirst}{emailLast}@{externalDomain}");
    }
}

PrintEmails(corporate, external);