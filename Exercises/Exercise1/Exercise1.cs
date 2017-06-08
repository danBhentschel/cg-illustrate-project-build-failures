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
            // Uncomment to fix compile error
            // var foo = "foo";
            Assert.AreEqual("foo", foo);
        }
    }
}
