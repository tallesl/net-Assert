namespace AssertLibrary
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given object is in the given collection.
        /// </summary>
        /// <param name="value">Value to check if it's in the collection</param>
        /// <param name="collection">Collection to check if the value is in it</param>
        public static void IsIn(object value, IEnumerable collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            foreach (var item in collection)
            {
                if (item.Equals(value))
                    return;
            }
            Debug.Assert(false, string.Format(CultureInfo.CurrentCulture, "Couldn't find the value \"{0}\" in the collection.", value));
        }
    }
}
