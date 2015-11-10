namespace Assert
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given object doesn't have its type's default value.
        /// </summary>
        /// <param name="value">Object to check</param>
        /// <param name="name">Variable name to include in the assertion message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK."),
        SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "False positive.")]
        public static void IsNotDefault<T>(T value, string name = null)
        {
            var defaultValue = Default<T>(value);
            var isNotDefault = (defaultValue == null && value != null) || !defaultValue.Equals(value);
            Debug.Assert(isNotDefault, IsNotDefaultMessage(name));
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "False positive.")]
        private static string IsNotDefaultMessage(string name)
        {
            return name == null ?
                "Should have a value other then the type's default at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have a value other then the type's default at this point.", name);
        }
    }
}
