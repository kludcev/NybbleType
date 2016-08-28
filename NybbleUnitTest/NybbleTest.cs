using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nybble;
namespace NybbleUnitTest
{
    [TestClass]
    public class NybbleTest
    {
        [TestMethod]
        public void OverloadTest()
        {
                var a = new Nybble.Nybble(4);
                var b = new Nybble.Nybble(15);
                var c = b - a;
                Assert.AreEqual(c, 11); 
                Assert.AreNotEqual(c,12);
                c = c + a;
            Assert.AreEqual(c,15);
            Assert.IsFalse(c<a);
        }



    }
}
