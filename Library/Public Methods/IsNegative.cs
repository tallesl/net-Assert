namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsNegative(int n, string name = null)
        {
            Debug.Assert(n < 0, IsPositiveMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsNegative(long n, string name = null)
        {
            Debug.Assert(n < 0, IsPositiveMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsNegative(float n, string name = null)
        {
            Debug.Assert(n < 0, IsPositiveMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsNegative(double n, string name = null)
        {
            Debug.Assert(n < 0, IsPositiveMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsNegative(decimal n, string name = null)
        {
            Debug.Assert(n < 0, IsNegativeMessage(name));
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "False positive.")]
        private static string IsNegativeMessage(string name)
        {
            return name == null ?
                "Should be negative at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be negative at this point.", name);
        }
    }
}
