using System; // Import the System namespace for basic functionality like Console

namespace MathOperationApp // Define the namespace of the application
{
    // Define a class named MathOperations
    class MathOperations
    {
        // Create a void method that takes two integers
        public void DoMath(int number1, int number2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 3)
            int result = number1 * 3;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second integer
            Console.WriteLine("Second number is: " + number2);
        }
    }

    class Program // The main class containing the entry point
    {
        // The Main method is the entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the DoMath method, passing two numbers (positional arguments)
            mathOps.DoMath(5, 10); // 5 will be doubled, and 10 will be displayed

            // Call the DoMath method using named parameters
            mathOps.DoMath(number2: 22, number1: 7); // 7 will be doubled, and 22 will be displayed

            // Keep the console window open until a key is pressed
            Console.ReadLine(); 
        }
    }
}
