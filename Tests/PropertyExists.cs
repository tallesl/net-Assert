namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class PropertyExists
    {
        [TestMethod]
        public void Valid()
        {
            Assert.PropertyExists(new { Foo = "Bar" }, "Foo");
        }

        [TestMethod, ExpectedException(typeof(AssertException))]
        public void Invalid()
        {
            Assert.PropertyExists(new { Foo = "Bar" }, "Qux");
        }
    }
}
