using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPalindrome()
        {
            string[] testStringsTrue = { "", "1", "11", "121", "1221", "12121" };
            string[] testStringsFalse = { "12", "21", "211", "1231", "2221", "112121" };

            foreach (var item in testStringsTrue)
            {
                Assert.IsTrue(sweeft_01.Methods.IsPalindrome(item));
            }

            foreach (var item in testStringsFalse)
            {
                Assert.IsFalse(sweeft_01.Methods.IsPalindrome(item));
            }

        }

        [TestMethod]
        public void TestMinSplit()
        {
            Assert.AreEqual(1, sweeft_01.Methods.MinSplit(1));
            Assert.AreEqual(1, sweeft_01.Methods.MinSplit(2));
            Assert.AreEqual(2, sweeft_01.Methods.MinSplit(3));
            Assert.AreEqual(2, sweeft_01.Methods.MinSplit(4));
            Assert.AreEqual(1, sweeft_01.Methods.MinSplit(5));
            Assert.AreEqual(3, sweeft_01.Methods.MinSplit(9));
            Assert.AreEqual(1, sweeft_01.Methods.MinSplit(10));
            Assert.AreEqual(2, sweeft_01.Methods.MinSplit(15));
            Assert.AreEqual(3, sweeft_01.Methods.MinSplit(45));
            Assert.AreEqual(2, sweeft_01.Methods.MinSplit(55));
            Assert.AreEqual(2, sweeft_01.Methods.MinSplit(100));
        }

        [TestMethod]
        public void TestNotContains()
        {
            Assert.AreEqual(1, sweeft_01.Methods.NotContains(new int[] { 2, 3, 4, 5 }));
            Assert.AreEqual(2, sweeft_01.Methods.NotContains(new int[] { 1, 3, 4, 5 }));
            Assert.AreEqual(3, sweeft_01.Methods.NotContains(new int[] { 1, 2, 4, 5 }));
            Assert.AreEqual(9, sweeft_01.Methods.NotContains(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
        }

        [TestMethod]
        public void TestIsProperly()
        {
            Assert.IsTrue(sweeft_01.Methods.IsProperly(""));
            Assert.IsTrue(sweeft_01.Methods.IsProperly("()"));
            Assert.IsTrue(sweeft_01.Methods.IsProperly("()()"));
            Assert.IsTrue(sweeft_01.Methods.IsProperly("(())"));
            Assert.IsTrue(sweeft_01.Methods.IsProperly("(()())"));

            Assert.IsFalse(sweeft_01.Methods.IsProperly("("));
            Assert.IsFalse(sweeft_01.Methods.IsProperly(")"));
            Assert.IsFalse(sweeft_01.Methods.IsProperly("())"));
            Assert.IsFalse(sweeft_01.Methods.IsProperly("()("));
            Assert.IsFalse(sweeft_01.Methods.IsProperly("(()"));
            Assert.IsFalse(sweeft_01.Methods.IsProperly("())("));
            Assert.IsFalse(sweeft_01.Methods.IsProperly("))(("));
        }

        [TestMethod]
        public void TestCountVariants()
        {
            Assert.AreEqual(1, sweeft_01.Methods.CountVariants(1));
            Assert.AreEqual(2, sweeft_01.Methods.CountVariants(2));
            Assert.AreEqual(3, sweeft_01.Methods.CountVariants(3));
            Assert.AreEqual(5, sweeft_01.Methods.CountVariants(4));
            Assert.AreEqual(8, sweeft_01.Methods.CountVariants(5));
            Assert.AreEqual(13, sweeft_01.Methods.CountVariants(6));
            Assert.AreEqual(21, sweeft_01.Methods.CountVariants(7));
            Assert.AreEqual(34, sweeft_01.Methods.CountVariants(8));
            Assert.AreEqual(55, sweeft_01.Methods.CountVariants(9));
            Assert.AreEqual(89, sweeft_01.Methods.CountVariants(10));
        }

        [TestMethod]
        public void TestExchangeRate()
        {
            Assert.AreNotEqual(0, sweeft_01.Methods.ExchangeRate("EUR", "USD"));
            Assert.AreNotEqual(0, sweeft_01.Methods.ExchangeRate("GEL", "AZN"));
            Assert.AreNotEqual(0, sweeft_01.Methods.ExchangeRate("RUB", "TRY"));
        }


        [TestMethod]
        public void TestLinkedStructure()
        {
            sweeft_01.LinkedStructure linkedStructure = new sweeft_01.LinkedStructure();
            linkedStructure.Add("1");
            linkedStructure.Add("2");
            linkedStructure.Add("3");
            linkedStructure.Add("4");
            linkedStructure.Add("5");
            linkedStructure.Add("6");

            string[] str1 = new string[] { "1", "2", "3", "4", "5", "6" };

            for (int i = 0; i < str1.Length; i++)
            {
                Assert.AreEqual(str1[i], linkedStructure.stack[i]);
            }

            linkedStructure.Remove("2");
            linkedStructure.Remove("6");

            string[] str2 = new string[] { "1", "5", "3", "4" };

            for (int i = 0; i < str2.Length; i++)
            {
                Assert.AreEqual(str2[i], linkedStructure.stack[i]);
            }

        }

    }
}
