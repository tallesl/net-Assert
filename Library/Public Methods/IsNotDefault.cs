namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given object doesn't have its type's default value.
        /// </summary>
        /// <param name="value">Object to check</param>
        /// <param name="variableName">Variable name to include in the assertion message (optional)</param>
        public static void IsNotDefault<T>(T value, string variableName = null)
        {
            var defaultValue = Default<T>(value);
            var isNotDefault = (defaultValue == null && value != null) || !defaultValue.Equals(value);
            Check(isNotDefault, IsNotDefaultMessage(variableName));
        }

        private static string IsNotDefaultMessage(string variableName)
        {
            return variableName == null ?
                "Should have a value other then the type's default at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have a value other then the type's default at this point.", variableName);
        }
    }
}
