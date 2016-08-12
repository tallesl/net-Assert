namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsNotZero
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsNotZero(1);
            Assert.IsNotZero(1L);
            Assert.IsNotZero(1f);
            Assert.IsNotZero(1d);
            Assert.IsNotZero(1m);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsNotZero(0);
        }
    }
}
