namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when the numbers of elements found in the collection is more than expected.
    /// </summary>
    [Serializable]
    public class ShouldntBeMoreException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="expected">Expect number of elements</param>
        /// <param name="found">Found number of elements</param>
        public ShouldntBeMoreException(int expected, int found) :
            base("Should have at most \"" + expected + "\" element(s) at this point but found \"" + found + "\" element(s).") { }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="expected">Expect number of elements</param>
        /// <param name="found">Found number of elements</param>
        /// <param name="name">Variable name</param>
        public ShouldntBeMoreException(int found, int expected, string name) :
            base("\"" + name + "\" should have at most \"" + expected + "\" element(s) at this point but found \"" + found + "\" element(s).") { }
    }
}
