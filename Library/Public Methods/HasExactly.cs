namespace AssertLibrary
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given collection has exactly n elements.
        /// </summary>
        /// <param name="n">Number of elements expected</param>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void HasExactly(int n, IEnumerable collection, string name = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            var count = Count(collection);
            Debug.Assert(count == n, HasExactlyMessage(name, n, count));
        }

        private static string HasExactlyMessage(string name, int n, int count)
        {
            return name == null ?
                string.Format(CultureInfo.CurrentCulture, "Should have exactly \"{0}\" element(s) at this point but found \"{1}\" element(s).", n, count) :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have exactly \"{1}\" element(s) at this point but found \"{2}\" element(s).", name, n, count);
        }
    }
}
