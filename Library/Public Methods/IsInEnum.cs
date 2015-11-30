namespace AssertLibrary
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given object is defined in the specified enum.
        /// </summary>
        /// <typeparam name="T">Enum to check if the given object is defined in it</typeparam>
        /// <param name="value">Value to check if it's defined in the specified enum</param>
        public static void IsInEnum<T>(object value)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            var type = typeof(T);
            Debug.Assert(Enum.IsDefined(type, value),
                string.Format(CultureInfo.CurrentCulture, "Couldn't find the value \"{0}\" in the enumeration \"{1}\".", value, type.Name));
        }
    }
}
