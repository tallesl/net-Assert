namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given number is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsPositive(int n, string variableName = null)
        {
            Check(n > 0, IsPositiveMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given number is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsPositive(long n, string variableName = null)
        {
            Check(n > 0, IsPositiveMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given number is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsPositive(float n, string variableName = null)
        {
            Check(n > 0, IsPositiveMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsPositive(double n, string variableName = null)
        {
            Check(n > 0, IsPositiveMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given number is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsPositive(decimal n, string variableName = null)
        {
            Check(n > 0, IsPositiveMessage(variableName));
        }

        private static string IsPositiveMessage(string variableName)
        {
            return variableName == null ?
                "Should be positive at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be positive at this point.", variableName);
        }
    }
}
