namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsMore
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsMore(0, -1);
            Assert.IsMore(2L, 1L);
            Assert.IsMore(0.1f, 0f);
            Assert.IsMore(0.1, 0.05);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsMore(1, 2);
        }
    }
}
