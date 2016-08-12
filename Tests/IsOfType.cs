namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class IsOfType
    {
        [TestMethod]
        public void Valid()
        {
            Assert.IsOfType(typeof(object), 1);
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.IsOfType(typeof(string), 1);
        }
    }
}
