﻿namespace Assert
{
    using System;

    public static partial class AssertThat
    {
        private static object Default<T>(T obj)
        {
            var t = obj == null ? typeof(T) : obj.GetType();
            return t.IsValueType && t != typeof(string) ? Activator.CreateInstance(t) : null;
        }
    }
}