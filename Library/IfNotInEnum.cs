namespace ThrowIf
{
    using System;

    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given object is not defined in the specified enum.
        /// </summary>
        /// <typeparam name="T">Enum to check if the given object is defined in it</typeparam>
        /// <param name="value">Value to check if it's defined in the specified enum</param>
        /// <exception cref="ShouldBeInEnumException">
        /// If the given object is not defined in the specified enum
        /// </exception>
        public static void IfNotInEnum<T>(object value)
        {
            var type = typeof(T);
            if (!Enum.IsDefined(type, value))
                throw new ShouldBeInEnumException(value, type.Name);
        }
    }
}
