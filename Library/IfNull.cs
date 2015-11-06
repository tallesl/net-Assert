namespace ThrowIf
{
    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given object is null.
        /// </summary>
        /// <param name="obj">Object to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeNullException">If the given object is null</exception>
        public static void IfNull(object obj, string name = null)
        {
            if (obj == null)
                throw (name == null ? new ShouldntBeNullException() : new ShouldntBeNullException(name));
        }
    }
}
