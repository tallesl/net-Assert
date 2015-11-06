namespace ThrowIf
{
    public static partial class Throw
    {
        /// <summary>
        /// Throws if the given object has the type's default value.
        /// </summary>
        /// <param name="obj">Object to check</param>
        /// <param name="name">Variable name to include in the exception message (optional)</param>
        /// <exception cref="ShouldntBeDefaultException">If the given object has the type's default value</exception>
        public static void IfDefault<T>(T obj, string name = null)
        {
            var @default = Default<T>(obj);
            if ((@default == null && obj == null) || @default.Equals(obj))
                throw (name == null ? new ShouldntBeDefaultException() : new ShouldntBeDefaultException(name));
        }
    }
}
