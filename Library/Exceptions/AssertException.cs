namespace AssertLibrary
{
    using System;

    /// <summary>
    /// Exception thrown when execution reaches a place in code that shouldn't.
    /// </summary>
    [Serializable]
    public class AssertException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public AssertException(string message) : base(message) { }
    }
}
