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
        public static void IsNotZero(int n, string variableName = null)
        {
            Check(n != 0, IsNotZeroMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNotZero(long n, string variableName = null)
        {
            Check(n != 0, IsNotZeroMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNotZero(float n, string variableName = null)
        {
            Check(n != 0, IsNotZeroMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNotZero(double n, string variableName = null)
        {
            Check(n != 0, IsNotZeroMessage(variableName));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNotZero(decimal n, string variableName = null)
        {
            Check(n != 0, IsNotZeroMessage(variableName));
        }

        private static string IsNotZeroMessage(string variableName)
        {
            return variableName == null ?
                "Shouldn't be zero at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" shouldn't be zero at this point.", variableName);
        }
    }
}
