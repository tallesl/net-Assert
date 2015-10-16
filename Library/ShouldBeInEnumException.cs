namespace ThrowIf
{
    using System;

    /// <summary>
    /// Exception thrown when a value outside of the defined in an enum is found.
    /// </summary>
    [Serializable]
    public class ShouldBeInEnumException : Exception
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="value">Value found</param>
        /// <param name="name">Enum name</param>
        public ShouldBeInEnumException(object value, string name) :
            base("Couldn't find the value \"" + value + "\" in the enumeration \"" + name + "\".") { }
    }
}
