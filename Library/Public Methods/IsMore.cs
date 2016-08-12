namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given number is more than the specified.
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <param name="than">Value to check against</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsMore(long n, long than, string variableName = null)
        {
            Check(n > than, IsMoreMessage(variableName, n, than));
        }

        /// <summary>
        /// Asserts that the given number is more than the specified.
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <param name="than">Value to check against</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsMore(double n, double than, string variableName = null)
        {
            Check(n > than, IsMoreMessage(variableName, n, than));
        }

        private static string IsMoreMessage(string variableName, object n, object than)
        {
            return variableName == null ?
                string.Format(CultureInfo.CurrentCulture, "Should be more than \"{0}\"at this point but found \"{1}\".", than, n) :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be more than \"{1}\" at this point but found \"{2}\".", variableName, than, n);
        }
    }
}
