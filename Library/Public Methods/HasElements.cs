namespace AssertLibrary
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given collection has elements.
        /// </summary>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the assertion message (optional)</param>
        public static void HasElements(IEnumerable collection, string name = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Debug.Assert(Count(collection) != 0, HasElementsMessage(name));
        }

        private static string HasElementsMessage(string name)
        {
            return name == null ?
                "Should have element(s) at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have element(s) at this point.", name);
        }
    }
}
