// string message = "find what is (inside the parentheses)";

// int openingPosition = message.IndexOf("(");
// int closingPosition = message.IndexOf(")");

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);
// openingPosition++;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
string qtyStartInterior = "<span>";
string qtyEndInterior = "</span>";
int qtyStartingIndex = input.IndexOf(qtyStartInterior);
int qtyEndInteriorIndex = input.IndexOf(qtyEndInterior);
qtyStartingIndex += qtyStartInterior.Length;
int lengthSubstring1 = qtyEndInteriorIndex - qtyStartingIndex;

string divBeg = "<div>";
string divEnd = "</div>";
int qtyDivStart = input.IndexOf(divBeg);
int qtyDivEnd = input.IndexOf(divEnd);
qtyDivStart += divBeg.Length;
int lengthSubstring2 = qtyDivEnd - qtyDivStart;

quantity = $"Quantity: " + input.Substring(qtyStartingIndex, lengthSubstring1);
output = $"OutPut: " + input.Substring(qtyDivStart, lengthSubstring2);

Console.WriteLine(quantity);
Console.WriteLine(output);