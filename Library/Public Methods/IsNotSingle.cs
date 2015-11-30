namespace AssertLibrary
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given collection doesn't have exactly one element.
        /// </summary>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsNotSingle(IEnumerable collection, string name = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Debug.Assert(Count(collection) != 1, IsNotSingleMessage(name));
        }

        private static string IsNotSingleMessage(string name)
        {
            return name == null ?
                "Shouldn't be single at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" shouldnt't be single at this point.", name);
        }
    }
}
