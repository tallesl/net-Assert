using System.Globalization;

namespace AssertLibrary
{
    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given string is not null, empty or whitespace.
        /// </summary>
        /// <param name="value">String to check</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsNotNullOrWhiteSpace(string value, string variableName = null)
        {
            Check(!string.IsNullOrWhiteSpace(value), IsNotNullOrWhiteSpaceMessage(variableName));
        }

        private static string IsNotNullOrWhiteSpaceMessage(string variableName)
        {
            return string.IsNullOrWhiteSpace(variableName) ?
                "Should not be empty at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should not be empty at this point.", variableName);
        }
    }
}
