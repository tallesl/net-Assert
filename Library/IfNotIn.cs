namespace ThrowIf
{
    using System.Collections;

    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given object is not in the given collection.
        /// </summary>
        /// <param name="value">Value to check if it's in the collection</param>
        /// <param name="collection">Collection to check if the value is in it</param>
        /// <exception cref="ShouldBeInEnumException&lt;T&gt;">
        /// If the given object is not defined in the specified enum
        /// </exception>
        public static void IfNotIn(object value, IEnumerable collection)
        {
            foreach (var item in collection)
            {
                if (item.Equals(value))
                    return;
            }

            throw new ShouldBeInCollectionException(value);
        }
    }
}
