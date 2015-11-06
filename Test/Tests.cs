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
            Throw.IfNotIn(3, new[] { 1, 2, 3, });
            Throw.IfNotInEnum<Enum>(1);
            Throw.IfNull(new object());
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldntBeDefaultException))]
        public void ThrowIfDefault()
        {
            Throw.IfDefault(default(Guid));
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldntBeDefaultException))]
        public void ThrowIfStringDefault()
        {
            Throw.IfDefault(default(string));
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
        [ExpectedException(typeof(ShouldBeInCollectionException))]
        public void ThrowIfNotIn()
        {
            Throw.IfNotIn(4, new [] { 1, 2, 3, });
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldBeInEnumException))]
        public void ThrowIfNotInEnum()
        {
            Throw.IfNotInEnum<Enum>(4);
        }

        [TestMethod]
        [ExpectedException(typeof(ShouldBeSingleException))]
        public void ThrowIfNotSingle()
        {
            Throw.IfNotSingle(new[] { 1, 2, 3, });
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

        [TestMethod]
        [ExpectedException(typeof(ShouldntBeSingleException))]
        public void ThrowIfSingle()
        {
            Throw.IfSingle(new[] { 1, });
        }
    }
}
