namespace ThrowIf
{
    using System;

    public static partial class Throw
    {
        private static object Default<T>(T obj)
        {
            var t = obj == null ? typeof(T) : obj.GetType();
            return t.IsValueType && t != typeof(string) ? Activator.CreateInstance(t) : null;
        }
    }
}
