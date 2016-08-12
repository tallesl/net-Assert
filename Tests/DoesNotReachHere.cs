namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class DoesNotReachHere
    {
        [TestMethod, ExpectedException(typeof(ShouldNotReachHereException))]
        public void Throw()
        {
            Assert.DoesNotReachHere();
        }
    }
}
