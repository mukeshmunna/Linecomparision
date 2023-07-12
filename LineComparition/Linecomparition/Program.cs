using System;

namespace Linecomparition
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparition problem statement");
            Operation operation = new Operation(3,4,5,6);
            operation.CalculateLenth();
        }
    }
}