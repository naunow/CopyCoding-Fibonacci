using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if(n <= 2)
            {
                return 1;
            }
            return 1 + 1;   // 一般化を始める。さきほど 2 と書いたのは、本当は1 + 1の結果だ。
        }

        [TestMethod()]
        public void TestFibonacci()
        {

            Dictionary<int, int> cases = new Dictionary<int, int>()
            {
                {0, 0},
                {1, 1},
                {2, 1}, 
                {3, 2}, 
            };

            foreach (var pair in cases)
            {
                Assert.AreEqual(pair.Value, Fib(pair.Key));
            }
        }
    }
}