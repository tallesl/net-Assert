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
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNotSingle(IEnumerable collection, string variableName = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Check(Count(collection) != 1, IsNotSingleMessage(variableName));
        }

        private static string IsNotSingleMessage(string variableName)
        {
            return variableName == null ?
                "Shouldn't be single at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" shouldnt't be single at this point.", variableName);
        }
    }
}
