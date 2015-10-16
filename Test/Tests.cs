namespace ThrowIf.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;
    using ThrowIf;

    enum Enum
    {
        One = 1,
        Two = 2,
        Three = 3,
    }

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void NoThrow()
        {
            Throw.IfDefault(Guid.NewGuid());
            Throw.IfEmpty(new[] { 1, 2, 3, });
            Throw.IfLess(3, new[] { 1, 2, 3, });
            Throw.IfMore(3, new[] { 1, 2, 3, });
            Throw.IfNotDefinedInEnum<Enum>(1);
            Throw.IfNull(new object());
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldntBeDefaultException))]
        public void ThrowIfDefault()
        {
            Throw.IfDefault(default(Guid));
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldntBeEmptyException))]
        public void ThrowIfEmpty()
        {
            Throw.IfEmpty(Enumerable.Empty<object>());
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldntBeLessException))]
        public void ThrowIfLess()
        {
            Throw.IfLess(3, new[] { 1, 2, });
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldntBeMoreException))]
        public void ThrowIfMore()
        {
            Throw.IfMore(3, new[] { 1, 2, 3, 4, });
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldBeInEnumException))]
        public void ThrowIfNotDefinedInEnum()
        {
            Throw.IfNotDefinedInEnum<Enum>(4);
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldntBeNullException))]
        public void ThrowIfNull()
        {
            Throw.IfNull(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldntReachHereException))]
        public void ThrowIfReachHere()
        {
            Throw.IfReachHere();
        }
    }
}
