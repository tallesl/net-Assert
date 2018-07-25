using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertLibrary.Tests
{
    [TestClass]
    public class IsNotNullOrWhiteSpace
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsNotNullOrWhiteSpace("Test");
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void InvalidNull()
        {
            Assert.IsNotNullOrWhiteSpace(null);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void InvalidEmpty()
        {
            Assert.IsNotNullOrWhiteSpace(string.Empty);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void InvalidWhiteSpace()
        {
            Assert.IsNotNullOrWhiteSpace(" ");
        }
    }
}
