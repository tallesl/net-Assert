namespace AssertLibrary
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given collection has elements.
        /// </summary>
        /// <param name="collection">Collection to check</param>
        /// <param name="variableName">Variable name to include in the assertion message (optional)</param>
        public static void HasElements(IEnumerable collection, string variableName = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Check(Count(collection) != 0, HasElementsMessage(variableName));
        }

        private static string HasElementsMessage(string variableName)
        {
            return variableName == null ?
                "Should have element(s) at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have element(s) at this point.", variableName);
        }
    }
}
