using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.NetworkInformation;

namespace predavanja_testiranje
{
    [TestClass]
    public class PredavanjeTestiranje
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 2; int b = 3;
            int povrsina;
            bool povrsinatrue = false;

            povrsina = a * b;
            if (povrsina ==6)
            {
                povrsinatrue = true;
            }
            Assert.IsTrue(povrsinatrue);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 2;
            int b = 3;
            int expectedArea = 6;

            int actualArea = a * b;
            Assert.IsTrue(actualArea == expectedArea, $"ocekivano podrucje {expectedArea}, ali dobili smo {actualArea}");
        }
        [TestMethod]
        public void TestMethod3()
        {
            int number = 10;
            bool isPositive = number > 0;
            Assert.IsTrue(isPositive, $"Ocekuje se da ce {number} biti pozitivan");
        }
    }
}