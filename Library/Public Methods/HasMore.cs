namespace AssertLibrary
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given collection has more than n elements.
        /// </summary>
        /// <param name="n">Number of elements to be more than</param>
        /// <param name="collection">Collection to check</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void HasMore(int n, IEnumerable collection, string variableName = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            var count = Count(collection);
            Check(count > n, HasMoreMessage(variableName, n, count));
        }

        private static string HasMoreMessage(string variableName, int n, int count)
        {
            return variableName == null ?
                string.Format(CultureInfo.CurrentCulture, "Should have more than \"{0}\" element(s) at this point but found \"{1}\" element(s).", n, count) :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have more than \"{1}\" element(s) at this point but found \"{2}\" element(s).", variableName, n, count);
        }
    }
}
