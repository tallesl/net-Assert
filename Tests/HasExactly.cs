namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class HasExactly
    {
        [TestMethod]
        public void Valid()
        {
            Assert.HasExactly(3, new[] { 1, 2, 3, });
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.HasExactly(3, new[] { 1, 2, });
        }
    }
}
