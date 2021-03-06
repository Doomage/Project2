using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string end;
            do
            {
                Console.WriteLine("---First Calculation---\n");
                var x = new Results();
                x.number1();
                x.number2();
                x.symbol();
                x.Calculate(x.Symbol);

                Console.WriteLine("---Second Calculation---");
                var y = new Results();
                y.number1();
                y.number2();
                y.symbol();
                y.Calculate(y.Symbol);

                //checking and printing The Greater common Divison of 2 results.
                Console.WriteLine($"The Greater Common Divisor Between {x.result} and {y.result} is {Results.GreaterCommonDivision((long)x.result, (long)y.result)}");

                //check if Result 2 is a Prime number
                if (Results.IsPrime((int)y.result))
                {
                    Console.WriteLine($"The number {y.result} is a prime number");
                }
                else
                {
                    Console.WriteLine($"The number {y.result} is not a prime number");
                }

                //Finding Fibonacci of result2
                Console.WriteLine($"The Fibonacci number of {y.result} is {Results.Fibonacci((long)y.result)}");
                //Results.FibonnacciCount(Results.Fibonacci((long)y.result));
                //Programm continuing
                Console.WriteLine("Do u want to Calculate something more? y/n");
                end = Console.ReadLine();               
            } while (end != "n");

            Console.WriteLine("Bye Bye");
            Console.ReadKey();
        }
    }
}
