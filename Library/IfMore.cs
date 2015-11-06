namespace ThrowIf
{
    using System.Collections;

    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given collection has more than the expected elements.
        /// </summary>
        /// <param name="moreThan">Expected elements</param>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeMoreException">
        /// If the given collection has more than the expected elements
        /// </exception>
        public static void IfMore(int moreThan, IEnumerable collection, string name = null)
        {
            var count = Count(collection);
            if (count > moreThan)
                throw (name == null ?
                    new ShouldntBeMoreException(moreThan, count) :
                    new ShouldntBeMoreException(moreThan, count, name));
        }
    }
}
