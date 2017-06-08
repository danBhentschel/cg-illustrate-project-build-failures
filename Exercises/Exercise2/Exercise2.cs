using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Exercise2
{
    [TestClass]
    class Exercise2
    {
        [TestMethod]
        public void TestMethod()
        {
            // Uncomment to fix compile error
            // var bar = "bar";
            Assert.AreEqual("bar", bar);
        }
    }
}
