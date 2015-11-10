namespace Assert
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given collection have exactly one element.
        /// </summary>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK."),
        SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "False positive.")]
        public static void IsSingle(IEnumerable collection, string name = null)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Debug.Assert(Count(collection) == 1, IsSingleMessage(name));
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "False positive.")]
        private static string IsSingleMessage(string name)
        {
            return name == null ?
                "Shouldn't be single at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" shouldnt't be single at this point.", name);
        }
    }
}
