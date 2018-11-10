using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Results
    {
        private double Number1 { get; set; }
        private double Number2 { get; set; }
        public string Symbol { get; set; }
        public double result { get; set; }

        public Results()
        {
            Console.WriteLine("Give me your 1st number");
            Number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Give me your 2nd number");
            Number2 = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Give me a symbol between :  +, -, *, /, %, square root");
                Symbol = Console.ReadLine();
            } while (Symbol != "+" && Symbol != "-" && Symbol != "*" && Symbol != "/" && Symbol != "%" && Symbol != "square root");
        }

        public void Calculate(string symbol)
        {
            switch (symbol)
            {
                default:
                case "+":
                    result = Number1 + Number2;
                    Console.WriteLine($"The result is: {Number1} + {Number2} = {result}");
                    break;
                case "-":
                    result = Number1 - Number2;
                    Console.WriteLine($"The result is: {Number1} - {Number2} = {result}");
                    break;
                case "*":
                    result = Number1 * Number2;
                    Console.WriteLine($"The result is: {Number1} * {Number2} = {result}");
                    break;
                case "/":
                    while (Number2 == 0)
                    {
                        Console.WriteLine("Give me a Number != 0");
                        Number2 = double.Parse(Console.ReadLine());
                    }
                    result = Number1 / Number2;
                    Console.WriteLine($"The result is: {Number1} / {Number2} = {result}");
                    break;
                case "%":
                    while (Number2 == 0)
                    {
                        Console.WriteLine("Give me a Number != 0");
                        Number2 = double.Parse(Console.ReadLine());
                    }
                    result = Number1 % Number2;
                    Console.WriteLine($"The result is: {Number1} % {Number2} = {result}");
                    break;
                case "square root":
                    //TODO:
                    double result1 = Number1 - Number2;
                    if (result1 <= 0)
                        result = 0;
                    else
                        result = Math.Sqrt(Number1) * Math.Sqrt(Number2);
                    Console.WriteLine($"The result is: {Number1} square root {Number2} = {result}");
                    break;
            }
        }


        //public static ulong GCD(ulong a, ulong b)
        //{
        //    while (a != 0 && b != 0)
        //    {
        //        if (a > b)
        //            a %= b;
        //        else
        //            b %= a;
        //    }

        //    return a == 0 ? b : a;
        //
        public static int GCD(int p, int q)
        {
            if (q == 0)
            {
                return p;
            }

            int r = p % q;

            return GCD(q, r);
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
