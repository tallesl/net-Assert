namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNegative(int n, string variableName = null)
        {
            Check(n < 0, IsPositiveMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNegative(long n, string variableName = null)
        {
            Check(n < 0, IsPositiveMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNegative(float n, string variableName = null)
        {
            Check(n < 0, IsPositiveMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNegative(double n, string variableName = null)
        {
            Check(n < 0, IsPositiveMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNegative(decimal n, string variableName = null)
        {
            Check(n < 0, IsNegativeMessage(variableName));
        }

        private static string IsNegativeMessage(string variableName)
        {
            return variableName == null ?
                "Should be negative at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be negative at this point.", variableName);
        }
    }
}
