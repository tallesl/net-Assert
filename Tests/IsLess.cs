namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsLess
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsLess(-1, 0);
            Assert.IsLess(1L, 2L);
            Assert.IsLess(0f, 0.1f);
            Assert.IsLess(0.05, 0.1);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsLess(2, 1);
        }
    }
}
