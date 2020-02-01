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
            return 2;
        }

        [TestMethod()]
        public void TestFibonacci()
        {

            // テストケース内の重複が気になり始めた。
            // 新しいテストを足したらさらにひどくなるだろう。
            // 入力値と期待値の組でテストを回すようにする。
            Dictionary<int, int> cases = new Dictionary<int, int>()
            {
                {0, 0},
                {1, 1},
                {2, 1}, // テストは以外にも通ってしまった。
                {3, 2}, // ここでテストが失敗する。小さい値を特別扱いする戦略で修正する。
            };

            foreach (var pair in cases)
            {
                Assert.AreEqual(pair.Value, Fib(pair.Key));
            }
        }
    }
}