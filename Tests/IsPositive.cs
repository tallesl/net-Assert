namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsPositive
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsPositive(1);
            Assert.IsPositive(1L);
            Assert.IsPositive(1f);
            Assert.IsPositive(1d);
            Assert.IsPositive(1m);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsPositive(-1);
        }
    }
}
