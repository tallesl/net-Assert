namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class HasLess
    {
        [TestMethod]
        public void Valid()
        {
            Assert.HasLess(3, new[] { 1, 2, });
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.HasLess(3, new[] { 1, 2, 3, });
        }
    }
}
