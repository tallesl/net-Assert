namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsInEnum
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsInEnum<StringSplitOptions>(0);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsInEnum<StringSplitOptions>(2);
        }
    }
}
