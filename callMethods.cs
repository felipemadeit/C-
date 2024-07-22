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

    Console.WriteLin
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