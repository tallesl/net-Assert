namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when a value is not find the the collection.
    /// </summary>
    [Serializable]
    public class ShouldBeInCollectionException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="value">Value found</param>
        public ShouldBeInCollectionException(object value) :
            base("Couldn't find the value \"" + value + "\" in the collection.") { }
    }
}
