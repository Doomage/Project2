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
                var x = new Results();
                x.Calculate(x.Symbol);

                var y = new Results();
                y.Calculate(y.Symbol);

                //checking and printing The Greater commong Divison of 2 results.
                Console.WriteLine($"The Greater Common Divisor Between {x.result} and {y.result} is {Results.GCD((int)x.result, (int)y.result)}");
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
                Console.WriteLine($"The Fibonacci number of {y.result} is {Results.Fibonacci((int)y.result)}");
                Console.WriteLine("Do u want to Calculate something more? y/n");
                end = Console.ReadLine();               
            } while (end != "n");
            Console.WriteLine("Bye Bye");
            Console.ReadKey();
        }
    }
}
