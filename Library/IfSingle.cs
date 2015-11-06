namespace ThrowIf
{
    using System.Collections;

    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given collection has a single element.
        /// </summary>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeMoreException">
        /// If the given collection has a single element
        /// </exception>
        public static void IfSingle(IEnumerable collection, string name = null)
        {
            var count = Count(collection);
            if (count == 1)
                throw name == null ? new ShouldntBeSingleException() : new ShouldntBeSingleException(name);
        }
    }
}
