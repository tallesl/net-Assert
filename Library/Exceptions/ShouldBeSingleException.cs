namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when the numbers of elements found in the collection is not 1.
    /// </summary>
    [Serializable]
    public class ShouldBeSingleException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="found">Found number of elements</param>
        public ShouldBeSingleException(int found) :
            base("Should have a single element at this point but found \"" + found + "\" element(s).") { }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="found">Found number of elements</param>
        /// <param name="name">Variable name</param>
        public ShouldBeSingleException(int found, string name) :
            base("\"" + name + "\" should have a single element at this point but found \"" + found + "\" element(s).") { }
    }
}
