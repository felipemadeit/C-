// This is the freeCodeCamp and Microsoft course practice



// Creates a instance when the method is stateful, else dont create an instance
Random dice = new Random();
int result = dice.Next(1,2);
//Console.WriteLine(result);

// Method to get the max value
int firstValue = 500;
int secondValue = 200;
int largeValue = Math.Max(firstValue, secondValue);
//Console.WriteLine($"The max value is {largeValue}");



// Conditionals
Random randim = new Random();
int primero = randim.Next(1,2);
int segundo = randim.Next(1,5);
int tercero = randim.Next(1,5);
int total = primero + segundo + tercero;

if (total  > 15) {
    Console.WriteLine("You Win!");
} else {
    Console.WriteLine("Yoy lost!");
}

// Boolean Expression

string message = "The quick brown fox jumps over the lazy dog.";
bool resultado = message.Contains("dog");
Console.WriteLine(resultado);

if (resultado) {
    Console.WriteLine("Contains");
} else {
    Console.WriteLine("Not Contains");
}

// More if statement (Compound condition) (  ||  ->   OR) // ( && -> AND)


if ((primero > segundo) || (!resultado)) {
    Console.WriteLine("YESSSSS");
} else {
    Console.WriteLine("NOOOOOOO");

}



if ((primero > segundo) && (resultado)) {
    Console.WriteLine("YESSSSS");
} else {
    Console.WriteLine("NOOOOOOO");

}


// Array 

string [] customerId = new string[3]; // Arrat of three elements

// Assign elements in specific positions

customerId[0] = "A1234";
customerId[1] = "A2345";
customerId[2] = "A3456";

Console.WriteLine(customerId[0]);

// Initialize an array with values

string[] orderId  = {"HELLO", "Customer", "Julian"};

Console.WriteLine(orderId[2]);

// Propierty length

Console.WriteLine(orderId.Length);


// For each 

foreach (string order in orderId) {

    Console.WriteLine("");
}


int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

// Method StarsWith

string name = "Bob";
if (name.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B'!");
}

/*
    Multiple line comments
    heyyy
*/



// Conditional operator

//<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1000;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// Min and max value 

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");



Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");



int first = 2;
string second = "4";
string toPrint= first + second; //This is valid but int not
Console.WriteLine(toPrint);


// Convert a int to string  ToString()
// Convert a string to int int.parse()

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);


// Try parse
//  Use TryParse() when converting a string into a numeric data type.
//  TryParse() returns true if the conversion is successful, false if it's unsuccessful.
//  Out parameters provide a secondary means of a method returning a value. In this case, the out parameter returns the converted value.
//  Use the keyword out when passing in an argument to a method that has defined an out parameter.

string valueT = "102";
int resultY = 0;
if (int.TryParse(valueT, out resultY))
{
   Console.WriteLine($"Measurement: {resultY}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}


// Array methods
// Use the Clear() method to empty the values out of elements in the array.
// Use the Resize() method to change the number of elements in the array, removing or adding elements from the end of the array.
// New array elements and cleared elements are null, meaning they don't point to a value in memory.


// Composite formatting
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);


string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);


// Formatting currency 
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// output Price: $123.45 (Save $50.00)


// Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
// output Measurement: 123,456.79 units


// Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
// output Tax rate: 36.79%


// Mixed
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);


string myWords = "Learning C#";
Console.WriteLine(myWords.PadLeft(12));
//One space is added to the start of the string.



// Search in a string
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);


/*
    IndexOf() gives you the first position of a character or string inside of another string.
    IndexOf() returns -1 if it can't find a match.
    Substring() returns just the specified portion of a string, using a starting position and optional length.
    There's often more than one way to solve a problem. You used two separate techniques to find all instances of a given character or string.
    Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.

*/


/*
    LastIndexOf() returns the last position of a character or string inside of another string.
    IndexOfAny() returns the first position of an array of char that occurs inside of another string
*/