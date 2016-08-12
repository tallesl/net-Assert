namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given number is less than the specified.
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <param name="than">Value to check against</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsLess(long n, long than, string variableName = null)
        {
            Check(n < than, IsLessMessage(variableName, n, than));
        }

        /// <summary>
        /// Asserts that the given number is less than the specified.
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <param name="than">Value to check against</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsLess(double n, double than, string variableName = null)
        {
            Debug.Assert(n < than, IsLessMessage(variableName, n, than));
        }

        private static string IsLessMessage(string variableName, object n, object than)
        {
            return variableName == null ?
                string.Format(CultureInfo.CurrentCulture, "Should be less than \"{0}\"at this point but found \"{1}\".", than, n) :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be less than \"{1}\" at this point but found \"{2}\".", variableName, than, n);
        }
    }
}
