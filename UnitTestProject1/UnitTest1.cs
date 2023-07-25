using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using clock;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Form_clock test = new Form_clock();
        [TestMethod]
        public void Shtrich_1()
        {
            int[] excepted = { 38, 49}; 
            int[] actual; 
            actual = test.Shtrich(8);
            CollectionAssert.Equals(excepted, actual);
        }
        [TestMethod]
        public void Shtrich_2()
        {
            int[] excepted = { 3, 181 };
            int[] actual;
            actual = test.Shtrich(43);
            CollectionAssert.Equals(excepted, actual);
        }
        [TestMethod]
        public void Hour_1()
        {
            int[] excepted = { 92, 218 };
            int[] actual;
            actual = test.Hour(19, 20);
            CollectionAssert.Equals(excepted, actual);
        }
        [TestMethod]
        public void Hour_2()
        {
            int[] excepted = { 199, 74 };
            int[] actual;
            actual = test.Hour(13, 6);
            CollectionAssert.Equals(excepted, actual);
        }
        [TestMethod]
        public void Sec_Min_1()
        {
            int[] excepted = { 80, 28 };
            int[] actual;
            actual = test.Sec_Min(55);
            CollectionAssert.Equals(excepted, actual);
        }
        [TestMethod]
        public void Sec_Min_2()
        {
            int[] excepted = { 271, 220 };
            int[] actual;
            actual = test.Sec_Min(20);
            CollectionAssert.Equals(excepted, actual);
        }
    }
}
