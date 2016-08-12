namespace AssertLibrary
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given objects are not equal.
        /// </summary>
        /// <param name="one">Object to check</param>
        /// <param name="another">The other object to check</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        public static void IsNotEqual(object one, object another, string name = null)
        {
            if (one == null)
                throw new ArgumentNullException("one");

            if (another == null)
                throw new ArgumentNullException("another");

            Check(!one.Equals(another), IsNotEqualMessage(name));
        }

        private static string IsNotEqualMessage(string name)
        {
            return name == null ?
                string.Format(CultureInfo.CurrentCulture, "Should be equal at this point.") :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be equal at this point.", name);
        }
    }
}
