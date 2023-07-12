using System;

namespace Linecomparition
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparition problem statement");
            Operation operation = new Operation(3,4,5,6);
            double line1 = operation.CalculateLenth();
            Console.WriteLine(line1);
            Operation operation2 = new Operation(3, 4, 5, 6);
            double line2 = operation2.CalculateLenth();
            Console.WriteLine(line2);
                
        }
        
    }
}