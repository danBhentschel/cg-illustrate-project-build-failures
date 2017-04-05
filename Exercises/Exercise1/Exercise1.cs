using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Exercise1
{
    [TestClass]
    class Exercise1
    {
        [TestMethod]
        public void TestMethod()
        {
            // The variable foo is not declared
            Assert.AreEqual("foo", foo);
        }
    }
}
