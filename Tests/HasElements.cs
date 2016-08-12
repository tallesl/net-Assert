namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class HasElements
    {
        [TestMethod]
        public void Valid()
        {
            Assert.HasElements(new[] { 1, });
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.HasElements(new int[] { });
        }
    }
}
