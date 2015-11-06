namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when the one element is found in the collection.
    /// </summary>
    [Serializable]
    public class ShouldntBeSingleException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public ShouldntBeSingleException() :
            base("Shouldn't be single at this point.") { }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="name">Variable name</param>
        public ShouldntBeSingleException(string name) :
            base("\"" + name + "\" shouldnt't be single at this point.") { }
    }
}
