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
