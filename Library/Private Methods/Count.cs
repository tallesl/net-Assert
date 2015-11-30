namespace AssertLibrary
{
    using System;
    using System.Collections;

    public static partial class Assert
    {
        private static int Count(IEnumerable enumerable)
        {
            var collection = enumerable as ICollection;
            if (collection == null)
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
            else
            {
                return collection.Count;
            }
        }
    }
}
