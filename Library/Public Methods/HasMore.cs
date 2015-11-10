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
        /// Asserts that the given collection has more than n elements.
        /// </summary>
        /// <param name="n">Number of elements to be more than</param>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK."),
        SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "That's OK."),
        SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "False positive.")]
        public static void HasMore(int n, IEnumerable collection, string name = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            var count = Count(collection);
            Debug.Assert(count > n, HasMoreMessage(name, n, count));
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "False positive.")]
        private static string HasMoreMessage(string name, int n, int count)
        {
            return name == null ?
                string.Format(CultureInfo.CurrentCulture, "Should have more than \"{0}\" element(s) at this point but found \"{1}\" element(s).", n, count) :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have more than \"{1}\" element(s) at this point but found \"{2}\" element(s).", name, n, count);
        }
    }
}
