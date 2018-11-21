using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2;
using System.Collections.Generic;

namespace Project2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestISFibonacci()
        {
            List<long> fibonaccilist = new List<long> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811};
            foreach (var number in fibonaccilist)
            {
                Assert.IsTrue(Results.IsFibonacci(number));
            }
            List<long> fibonaccilist2 = new List<long> { 4,6,7,9,10,11,12,14,15,16,17,18,19,20,26,30,32,40,50,200,300,600,900 };
            foreach (var number in fibonaccilist2)
            {
                Assert.IsFalse(Results.IsFibonacci(number));
            }
        }


        [TestMethod]
        public void TestFibonacci()
        {
            List<long> fibonaccilist = new List<long> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811 };         
            for (int i = 0; i <= fibonaccilist.Count - 1; i++)
            {
                Assert.AreEqual(Results.Fibonacci(i), fibonaccilist[i]);
            }  
        }

        [TestMethod]
        public void TestIsPrime()
        {
            List<long> Primelist = new List<long> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103,
                                                        107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 };
            List<long> Primelist2 = new List<long> { 0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 32, 35, 38, 40, 42, 44, 50, 66 };

            foreach (var number in Primelist)
            {
                Assert.IsTrue(Results.IsPrime((int)number));
            }
            foreach(var number in Primelist2)
            {
                Assert.IsFalse(Results.IsPrime((int)number));
            }
        }

        [TestMethod]
        public void TestGreaterCommonDivisor()
        {
            Assert.AreEqual(Results.GreaterCommonDivision(1, 0), 1);
            Assert.AreEqual(Results.GreaterCommonDivision(1, 1), 1);
            Assert.AreEqual(Results.GreaterCommonDivision(10, 5), 5);
            Assert.AreEqual(Results.GreaterCommonDivision(20, 2), 2);
            Assert.AreEqual(Results.GreaterCommonDivision(30, 50), 10);
        }

        [TestMethod]
        public void TestCalculate()
        {
            Results x = new Results();
            x.Number1 = 1;
            x.Number2 = 0;
            Assert.IsTrue(x.Calculate("sr"));
            Assert.Equals(x.Calculate("+"),1);
            Assert.Equals(x.Calculate("-"),1);
            Assert.IsTrue(x.Calculate("/"));
            Assert.IsTrue(x.Calculate("%"));
            Assert.Equals(x.Calculate("*"),1);

        }
    }   
}
