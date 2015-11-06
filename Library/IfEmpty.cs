namespace ThrowIf
{
    using System.Collections;

    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given collection has no elements.
        /// </summary>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeEmptyException">If the given collection has no elements</exception>
        public static void IfEmpty(IEnumerable collection, string name = null)
        {
            if (Count(collection) == 0)
                throw (name == null ? new ShouldntBeEmptyException() : new ShouldntBeEmptyException(name));
        }
    }
}
