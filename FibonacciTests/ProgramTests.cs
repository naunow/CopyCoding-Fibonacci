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
            return 0;
        }

        [TestMethod()]
        public void TestFibonacci()
        {
            Assert.AreEqual(0, Fib(0));
        }
    }
}