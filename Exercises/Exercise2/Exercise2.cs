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
        public void Exercise2()
        {
            // The variable bar is not declared
            Assert.AreEqual("bar", bar);
        }
    }
}
