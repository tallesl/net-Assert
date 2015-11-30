namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given object is null.
        /// </summary>
        /// <param name="value">Object to check</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsNotNull(object value, string name = null)
        {
            Debug.Assert(value != null, IsNotNullMessage(name));
        }

        private static string IsNotNullMessage(string name)
        {
            return name == null ?
                "Should have a value other then null at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should have a value other then null at this point.", name);
        }
    }
}
