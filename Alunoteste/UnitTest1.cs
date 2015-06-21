using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alunoteste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;

            Assert.IsTrue(x==1);
        }
    }
}
