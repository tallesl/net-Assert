﻿namespace AssertLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Dynamic;
    using System.Globalization;

    public static partial class Assert
    {
        /// <summary>
        /// Asserts that the given property exists in the given object.
        /// </summary>
        /// <param name="value">Object to check</param>
        /// <param name="propertyName">Name of the property to check</param>
        /// <param name="variableName">Variable name to include in the error message</param>
        public static void PropertyExists(object value, string propertyName, string variableName = null)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            var type = value.GetType();
            var exists = type == typeof(ExpandoObject) ?
                ((IDictionary<string, object>)value).ContainsKey(propertyName) :
                type.GetProperty(propertyName) != null;

            Debug.Assert(exists, PropertyExistsMessage(propertyName, variableName));
        }

        private static string PropertyExistsMessage(string propertyName, string variableName)
        {
            return variableName == null ?
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should exist at this point.", propertyName) :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should exist at this point in \"{1}\".", propertyName, variableName);
        }
    }
}