namespace ThrowIf
{
    using System;
    using System.Collections;

    public static partial class Throw
    {
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
    }
}
