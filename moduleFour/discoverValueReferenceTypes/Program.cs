// Console.WriteLine("Signed integral types");

// Console.WriteLine($"sbyte : {sbyte.MinValue}, sbyte : {sbyte.MaxValue}");
// Console.WriteLine($"short : {short.MinValue}, short : {short.MaxValue}");
// Console.WriteLine($"int : {int.MinValue}, int : {int.MaxValue}");
// Console.WriteLine($"long : {long.MinValue}, long : {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");



// array that can hold integers it is a null reference;
// int[] data;

// creates a new instance of int array and the size of the array;

// int[] data2 = new int[3];

// Console.WriteLine(data2);

// // string as a reference type because of its common use does not need the kewyword new to create a new instnace of it
// string shortenedString = "Hello World!";
// Console.WriteLine(shortenedString);

// int val_A = 2;
// int val_B = val_A;
// val_B = 5;

// Console.WriteLine("--Value Types--");
// Console.WriteLine($"val_A: {val_A}");
// Console.WriteLine($"val_B: {val_B}");

int[] ref_A = new int[1];
ref_A[0] = 2;
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");