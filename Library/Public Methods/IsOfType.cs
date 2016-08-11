namespace AssertLibrary
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given value is of the given type.
        /// </summary>
        /// <typeparam name="T">Expected type</typeparam>
        /// <param name="value">Value to check</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsOfType<T>(object value, string variableName = null)
        {
            IsOfType(typeof(T), value, variableName);
        }

        /// <summary>
        /// Asserts that the given value is of the given type.
        /// </summary>
        /// <param name="type">Expected type</param>
        /// <param name="value">Value to check</param>
        /// <param name="variableName">Variable name to include in the error message (optional)</param>
        public static void IsOfType(Type type, object value, string variableName = null)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (value == null)
                throw new ArgumentNullException("value");

            Debug.Assert(type.IsAssignableFrom(value.GetType()), IsOfTypeMessage(variableName, type));
        }

        private static string IsOfTypeMessage(string variableName, Type type)
        {
            return variableName == null ?
                string.Format(CultureInfo.CurrentCulture, "Should be of type \"{0}\".", type) :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be of type \"{1}\".", variableName, type.Name);
        }
    }
}
