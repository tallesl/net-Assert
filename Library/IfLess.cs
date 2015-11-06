namespace ThrowIf
{
    using System.Collections;

    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given collection has less than the expected elements.
        /// </summary>
        /// <param name="lessThan">Expected elements</param>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeLessException">
        /// If the given collection has less than the expected elements
        /// </exception>
        public static void IfLess(int lessThan, IEnumerable collection, string name = null)
        {
            var count = Count(collection);
            if (count < lessThan)
                throw (name == null ?
                    new ShouldntBeLessException(lessThan, count) :
                    new ShouldntBeLessException(lessThan, count, name));
        }
    }
}
