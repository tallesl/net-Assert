namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given flag is true.
        /// </summary>
        /// <param name="flag">Flag to check</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsTrue(bool flag, string name = null)
        {
            Debug.Assert(flag, IsTrueMessage(name));
        }

        private static string IsTrueMessage(string name)
        {
            return name == null ?
                "Shouldn't be true at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" shouldn't be true at this point.", name);
        }
    }
}
