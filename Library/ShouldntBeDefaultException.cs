namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when a unexpected default value is found.
    /// </summary>
    [Serializable]
    public class ShouldntBeDefaultException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public ShouldntBeDefaultException() : base("Should have a value other then the type's default at this point.") { }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="name">Variable name</param>
        public ShouldntBeDefaultException(string name) :
            base("\"" + name + "\" should have a value other then the type's default at this point.") { }
    }
}
