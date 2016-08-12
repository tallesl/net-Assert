namespace AssertLibrary
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given object is in the given collection.
        /// </summary>
        /// <param name="value">Value to check if it's in the collection</param>
        /// <param name="collection">Collection to check if the value is in it</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsIn(object value, IEnumerable collection, string variableName = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            foreach (var item in collection)
            {
                if (item.Equals(value))
                    return;
            }
            Check(false, IsInMessage(variableName, value));
        }

        private static string IsInMessage(string variableName, object value)
        {
            return variableName == null ?
                string.Format(CultureInfo.CurrentCulture, "Couldn't find the value \"{0}\" in the collection.", value) :
                string.Format(CultureInfo.CurrentCulture, "Couldn't find the value \"{0}\" in the collection \"{1}\".", value, variableName);
        }
    }
}
