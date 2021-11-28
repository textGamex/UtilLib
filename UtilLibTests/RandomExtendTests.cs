using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLib.Tests
{
    [TestClass()]
    public class RandomExtendTests
    {
        private static readonly Random random = new Random(0);

        [TestMethod()]
        public void NextBooleanTest()
        {
            Assert.IsTrue(random.NextBoolean(1.0));
            Assert.IsFalse(random.NextBoolean(0.0));
        }
    }
}