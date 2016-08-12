namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class HasMore
    {
        [TestMethod]
        public void Valid()
        {
            Assert.HasMore(3, new[] { 1, 2, 3, 4, });
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.HasMore(3, new[] { 1, 2, 3, });
        }
    }
}
