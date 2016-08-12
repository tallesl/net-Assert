namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsNegative
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsNegative(-1);
            Assert.IsNegative(-1L);
            Assert.IsNegative(-1f);
            Assert.IsNegative(-1d);
            Assert.IsNegative(-1m);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsNegative(1);
        }
    }
}
