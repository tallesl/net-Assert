namespace AssertLibrary
{
    using System;

    public static partial class Assert
    {
        private static object Default<T>(T obj)
        {
            var t = obj == null ? typeof(T) : obj.GetType();
            return t.IsValueType && t != typeof(string) ? Activator.CreateInstance(t) : null;
        }
    }
}
