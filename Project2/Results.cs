using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Results
    {
        public static List<long> fibonacci = new List<long>();
        private double Number1 { get; set; }
        private double Number2 { get; set; }
        internal string Symbol { get; private set; }
        internal double result { get; private set; }

        internal Results()
        {
        }
        internal bool number1()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Give me your 1st number");
                    Number1 = double.Parse(Console.ReadLine());
                    return true;
                }
                catch (ArgumentNullException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (FormatException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (OverflowException x)
                {
                    Console.WriteLine(x.Message);
                }
            }
        }
        internal bool number2()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Give me your 2nd number");
                    Number2 = double.Parse(Console.ReadLine());
                    return true;
                }
                catch (ArgumentNullException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (FormatException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (OverflowException x)
                {
                    Console.WriteLine(x.Message);
                }
            }
        }
        internal void symbol()
        {
            do
            {
                Console.WriteLine("Give me between :  +, -, *, /, %, square root or sr");
                Symbol = Console.ReadLine();
            } while (Symbol != "+" && Symbol != "-" && Symbol != "*" && Symbol != "/" && Symbol != "%" && Symbol != "square root" && Symbol != "sr");
        }


        internal bool Calculate(string symbol)
        {
            while (true)
            {
                try
                {
                    switch (symbol)
                    {
                        default:
                        case "+":
                            result = Number1 + Number2;
                            Console.WriteLine($"The result is: {Number1} + {Number2} = {result}\n");
                            return true;
                        case "-":
                            result = Number1 - Number2;
                            Console.WriteLine($"The result is: {Number1} - {Number2} = {result}\n");
                            return true;
                        case "*":
                            result = Number1 * Number2;
                            Console.WriteLine($"The result is: {Number1} * {Number2} = {result}\n");
                            return true;
                        case "/":
                            while (Number2 == 0)
                            {
                                Console.WriteLine("Give me a Number != 0");
                                Number2 = double.Parse(Console.ReadLine());
                            }
                            result = Number1 / Number2;
                            Console.WriteLine($"The result is: {Number1} / {Number2} = {result}\n");
                            return true;
                        case "%":
                            while (Number2 == 0)
                            {
                                Console.WriteLine("Give me a Number != 0\n");
                                Number2 = double.Parse(Console.ReadLine());
                            }
                            result = Number1 % Number2;
                            Console.WriteLine($"The result is: {Number1} % {Number2} = {result}\n");
                            return true;
                        case "square root":
                        case "sr":
                            if (Number1 <= 0 || Number2 <= 0)
                                Console.WriteLine("U cant have a square root of a negative number or with zero \n");
                            else
                            {
                                result = Math.Pow(Number1, 1 / Number2);
                                Console.WriteLine($"The result of {Number1} square root raised in {Number2} power = {result}\n");
                            }
                            return true;
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }

        }

        internal static long GreaterCommonDivision(long NumberA, long NumberB)
        {
            if (NumberB == 0)
            {
                return NumberA;
            }

            long r = NumberA % NumberB;

            return GreaterCommonDivision(NumberB, r);
        }

        internal static bool IsPrime(int number)
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

        internal static long Fibonacci(long n)
        {

            long a = 0;
            long b = 1;
            for (int i = 0; i < n; i++)
            {
                fibonacci[i] = b;
                long temp = a;
                a = b;
                b = temp + b;
            }
            FibonnacciCount(n);
            return a;
        }

        internal static void FibonnacciCount(long n)
        {
            for (int i = 0; i <= fibonacci.Count-1 ; i++)
            {
                if (fibonacci[i] == n)
                {
                    Console.WriteLine($"The number {n} is a Fibonacci number");
                }
                Console.WriteLine($"The number {n} is not a Fibonacci number");
            }


        }

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }

}


