namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsEqual
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsEqual(1, 1);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsEqual(1, "1");
        }
    }
}
