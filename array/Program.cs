// string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

string[] fraduelentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraduelentOrderIDs[0]}");
Console.WriteLine($"Second: {fraduelentOrderIDs[1]}");
Console.WriteLine($"Third: {fraduelentOrderIDs[2]}");

fraduelentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraduelentOrderIDs[0]}");


Console.WriteLine($"There are {fraduelentOrderIDs.Length} fraduelnt orders to process.");

foreach(string ID in fraduelentOrderIDs){
    Console.WriteLine($"ID: {ID}");
}