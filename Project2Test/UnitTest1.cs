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
            
        }
    }   
}
