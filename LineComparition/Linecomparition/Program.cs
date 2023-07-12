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
            
            //EQUAL -- u3
            if(line1.Equals(line2))
            {
                Console.WriteLine("Line1 is equal to line2");

            }
            else
            {
                Console.WriteLine("Line1 and line 2 is not equal");
            }
            //uc4
            if(line1.CompareTo(line2)==0) {
                Console.WriteLine("Both line are equal");
            }
            if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine(" line1 greater than Line2");
            }
            if (line1.CompareTo(line2) < 0)
            {
                Console.WriteLine(" line1 greater than Line2");
            }

        }
        
    }
}