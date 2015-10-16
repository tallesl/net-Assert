namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when a unexpected empty collection is found.
    /// </summary>
    [Serializable]
    public class ShouldntBeEmptyException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public ShouldntBeEmptyException() : base("Should have element(s) at this point.") { }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="name">Variable name</param>
        public ShouldntBeEmptyException(string name) :
            base("\"" + name + "\" should have element(s) at this point.") { }
    }
}
