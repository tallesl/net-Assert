namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsNotEqual
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsNotEqual(1, "1");
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsNotEqual(1, 1);
        }
    }
}
