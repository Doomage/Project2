using System;

namespace Project2
{
    class Program
    {
        public static void Main(string[] args)
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
                    Console.WriteLine($"The number {(long)y.result} is a prime number");
                }
                else
                {
                    Console.WriteLine($"The number {(long)y.result} is not a prime number");
                }

                //Finding Fibonacci of result2
                Console.WriteLine($"The Fibonacci number of {(long)y.result} is {Results.Fibonacci((long)y.result)}");
                //Finding if the result2 is a fibinacci Number
                if (Results.IsFibonacci((long)y.result) == true)
                {
                    Console.WriteLine($"The number {(long)y.result} is in fibonacci numbers");
                }
                else
                {
                    Console.WriteLine($"The number {(long)y.result} is not in fibonacci numbers");
                }
                //Programm continuing
                Console.WriteLine("Do u want to Calculate something more? y/n");
                end = Console.ReadLine();               
            } while (end != "n");

            Console.WriteLine("Bye Bye");
            Console.ReadKey();
        }
    }
}
