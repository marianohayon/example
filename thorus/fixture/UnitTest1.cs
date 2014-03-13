using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fixture
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = 5;
            Assert.AreEqual(expected, 5);
        }

      
    }
}
