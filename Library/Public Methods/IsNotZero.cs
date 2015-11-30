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
        public static void IsNotZero(int n, string name = null)
        {
            Debug.Assert(n != 0, IsNotZeroMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsNotZero(long n, string name = null)
        {
            Debug.Assert(n != 0, IsNotZeroMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsNotZero(float n, string name = null)
        {
            Debug.Assert(n != 0, IsNotZeroMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsNotZero(double n, string name = null)
        {
            Debug.Assert(n != 0, IsNotZeroMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is negative.
        /// </summary>
        /// <param name="n">Number to check if it's negative</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsNotZero(decimal n, string name = null)
        {
            Debug.Assert(n != 0, IsNotZeroMessage(name));
        }

        private static string IsNotZeroMessage(string name)
        {
            return name == null ?
                "Shouldn't be zero at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" shouldn't be zero at this point.", name);
        }
    }
}
