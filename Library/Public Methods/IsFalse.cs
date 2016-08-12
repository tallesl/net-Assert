namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given flag is false.
        /// </summary>
        /// <param name="flag">Flag to check</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsFalse(bool flag, string variableName = null)
        {
            Check(!flag, IsFalseMessage(variableName));
        }

        private static string IsFalseMessage(string variableName)
        {
            return variableName == null ?
                "Shouldn't be false at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" shouldn't be false at this point.", variableName);
        }
    }
}
