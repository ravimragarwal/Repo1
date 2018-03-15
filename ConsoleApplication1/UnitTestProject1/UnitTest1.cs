using System;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private LongestString ls;
        [TestInitialize]
        public void TestSetup()
        {
            ls = new LongestString();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(ls.Get("abgcdefghiccc"), "abgcdef"); //cdefghi
        }

        [TestMethod]
        public void TestMethod21()
        {
            Assert.AreEqual(ls.Get("abgcdcefgeabcdefgh"), "abcdefgh");  //abgcd, dcefg, fgeabcd, abcdefgh
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(ls.Get("abgcdce"), "abgcd");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(ls.Get("abgcc"), "abgc");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(ls.Get("abgcccefghi"), "cefghi"); // abgc, cefghi
        }

        [TestMethod]
        public void TestMethod15()
        {
            Assert.AreEqual(ls.Get("abgcdefghiccc"), "abgcdef"); //abgcdef, cdefghi, defghic
        }

        [TestMethod]
        public void TestMethod151()
        {
            Assert.AreEqual(ls.Get("abgcdefghizbccc"), "cdefghizb");
        }

        [TestMethod]
        public void TestMethod16()
        {
            Assert.AreEqual(ls.Get("aaaaa"), "a");
        }

        [TestMethod]
        public void TestMethod17()
        {
            Assert.AreEqual(ls.Get("aa"), "a");
        }

        [TestMethod]
        public void TestMethod18()
        {
            Assert.AreEqual(ls.Get("a"), "a");
        }

        [TestMethod]
        public void TestMethod19()
        {
            Assert.AreEqual(ls.Get(""), "");
        }

        [TestMethod]
        public void TestMethod20()
        {
            Assert.AreEqual(ls.Get(null), null);
        }

        [TestMethod]
        public void TestMethod212()
        {
            Assert.AreEqual(ls.Get("abcdefcabfcde"), "abcdef");   // abcdef, defcab, cabf, abfcde
        }

        [TestMethod]
        public void TestMethod49()
        {
            Assert.AreEqual(ls.Get("abcdefcabfcdez"), "abfcdez");
        }
    }
}
