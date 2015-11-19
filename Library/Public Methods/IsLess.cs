namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given number is less than the specified.
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <param name="than">Value to check against</param>
        // <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsLess(long n, long than, string name = null)
        {
            Debug.Assert(n < than, IsLessMessage(name, n, than));
        }

        /// <summary>
        /// Asserts that the given number is less than the specified.
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <param name="than">Value to check against</param>
        // <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsLess(double n, double than, string name = null)
        {
            Debug.Assert(n < than, IsLessMessage(name, n, than));
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "False positive.")]
        private static string IsLessMessage(string name, object n, object than)
        {
            return name == null ?
                string.Format(CultureInfo.CurrentCulture, "Should be less than \"{0}\"at this point but found \"{1}\".", than, n) :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be less than \"{1}\" at this point but found \"{2}\".", name, than, n);
        }
    }
}
