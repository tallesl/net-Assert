namespace ThrowIf
{
    using System.Collections;

    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given collection count isn't one.
        /// </summary>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeMoreException">
        /// If the given collection count isn't one
        /// </exception>
        public static void IfNotSingle(IEnumerable collection, string name = null)
        {
            var count = Count(collection);
            if (count != 1)
                throw name == null ? new ShouldBeSingleException(count) : new ShouldBeSingleException(count, name);
        }
    }
}
