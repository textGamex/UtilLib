using NUnit.Framework;
using System;
using UtilLib;

namespace UtilityLibTests
{
    public class RandomExtendTest
    {
        static readonly Random random = new Random();
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void NextBoolean()
        {
            Assert.IsFalse(random.NextBoolean(0.0));
            Assert.IsFalse(random.NextBoolean(-1.0));
            Assert.IsTrue(random.NextBoolean(1.0));
        }
    }
}