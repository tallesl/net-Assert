namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when a unexpected null value is found.
    /// </summary>
    [Serializable]
    public class ShouldntBeNullException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public ShouldntBeNullException() : base("Should have a value other then null at this point.") { }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="name">Variable name</param>
        public ShouldntBeNullException(string name) :
            base("\"" + name + "\" should have a value other then null at this point.") { }
    }
}
