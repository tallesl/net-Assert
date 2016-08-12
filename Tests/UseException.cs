namespace AssertLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = AssertLibrary.Assert;

    [TestClass]
    public class UseException
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Assert.UseException();
        }
    }
}
