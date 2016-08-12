namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsNotDefault
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsNotDefault(Guid.NewGuid());
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsNotDefault(new Guid());
        }
    }
}
