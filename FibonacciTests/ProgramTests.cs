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
            return 1;
        }

        [TestMethod()]
        public void TestFibonacci()
        {
            Assert.AreEqual(0, Fib(0));
            // テストを通すにはいくつか方法がある。
            // ここでは0を特別扱いするようにしてみよう。
            Assert.AreEqual(1, Fib(1));
        }
    }
}