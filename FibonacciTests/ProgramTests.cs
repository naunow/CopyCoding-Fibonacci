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
            //Assert.AreEqual(0, Fib(0));
            //Assert.AreEqual(1, Fib(1));

            // テストケース内の重複が気になり始めた。
            // 新しいテストを足したらさらにひどくなるだろう。
            // 入力値と期待値の組でテストを回すようにする。
            Dictionary<int, int> cases = new Dictionary<int, int>()
            {
                {0, 0},
                {1, 1},
            };

            foreach (var pair in cases)
            {
                Assert.AreEqual(pair.Value, Fib(pair.Key));
            }
        }
    }
}