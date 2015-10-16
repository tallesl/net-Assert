namespace ThrowIf
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Throws if something.
    /// </summary>
    public static class Throw
    {
        /// <summary>
        /// Throws if the given object has the type's default value.
        /// </summary>
        /// <param name="obj">Object to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeDefaultException">If the given object has the type's default value</exception>
        public static void IfDefault(object obj, string name = null)
        {
            if (Default(obj.GetType()).Equals(obj))
                throw (name == null ? new ShouldntBeDefaultException() : new ShouldntBeDefaultException(name));
        }

        /// <summary>
        /// Throws if the given collection has no elements.
        /// </summary>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeEmptyException">If the given collection has no elements</exception>
        public static void IfEmpty(IEnumerable collection, string name = null)
        {
            if (Count(collection) == 0)
                throw (name == null ? new ShouldntBeEmptyException() : new ShouldntBeEmptyException(name));
        }

        /// <summary>
        /// Throws if the given collection has less than the expected elements.
        /// </summary>
        /// <param name="lessThan">Expected elements</param>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeLessException">
        /// If the given collection has less than the expected elements
        /// </exception>
        public static void IfLess(int lessThan, IEnumerable collection, string name = null)
        {
            var count = Count(collection);
            if (count < lessThan)
                throw (name == null ?
                    new ShouldntBeLessException(lessThan, count) :
                    new ShouldntBeLessException(lessThan, count, name));
        }

        /// <summary>
        /// Throws if the given collection has more than the expected elements.
        /// </summary>
        /// <param name="moreThan">Expected elements</param>
        /// <param name="collection">Collection to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeMoreException">
        /// If the given collection has more than the expected elements
        /// </exception>
        public static void IfMore(int moreThan, IEnumerable collection, string name = null)
        {
            var count = Count(collection);
            if (count > moreThan)
                throw (name == null ?
                    new ShouldntBeMoreException(moreThan, count) :
                    new ShouldntBeMoreException(moreThan, count, name));
        }

        /// <summary>
        /// Throws if the given object is not defined in the specified enum.
        /// </summary>
        /// <typeparam name="T">Enum to check if the given object is defined in it</typeparam>
        /// <param name="value">Value to check if it's defined in the specified enum</param>
        /// <exception cref="ShouldBeInEnumException&lt;T&gt;">
        /// If the given object is not defined in the specified enum
        /// </exception>
        public static void IfNotDefinedInEnum<T>(object value)
        {
            var type = typeof(T);
            if (!Enum.IsDefined(type, value))
                throw new ShouldBeInEnumException(value, type.Name);
        }

        /// <summary>
        /// Throws if the given object is null.
        /// </summary>
        /// <param name="obj">Object to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeNullException">If the given object is null</exception>
        public static void IfNull(object obj, string name = null)
        {
            if (obj == null)
                throw (name == null ? new ShouldntBeNullException() : new ShouldntBeNullException(name));
        }

        /// <summary>
        /// Throws ShouldntReachHere.
        /// </summary>
        /// <exception cref="ShouldntReachHereException">Always</exception>
        public static void IfReachHere()
        {
            throw new ShouldntReachHereException();
        }

        private static int Count(IEnumerable enumerable)
        {
            if (enumerable is ICollection)
            {
                return ((ICollection)enumerable).Count;
            }
            else
            {
                var count = 0;
                var enumerator = enumerable.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                        ++count;
                }
                finally
                {
                    var disposable = enumerator as IDisposable;
                    if (disposable != null)
                        disposable.Dispose();
                }
                return count;
            }
        }

        private static object Default(Type t)
        {
            return t.IsValueType ? Activator.CreateInstance(t) : null;
        }
    }
}
