namespace AssertLibrary
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Exception thrown when execution reaches a place in code that shouldn't.
    /// </summary>
    [Serializable]
    public class ShouldNotReachHereException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public ShouldNotReachHereException() : base("Shouldn't reach here regardless the program state.") { }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public ShouldNotReachHereException(string message) : base(message) { }
    }
}
