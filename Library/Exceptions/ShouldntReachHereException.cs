namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when execution reaches a place in code that shouldn't.
    /// </summary>
    [Serializable]
    public class ShouldntReachHereException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public ShouldntReachHereException() : base("Shouldn't reach here regardless the program state.") { }
    }
}
