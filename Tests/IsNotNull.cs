namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsNotNull
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsNotNull(string.Empty);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsNotNull(null);
        }
    }
}
