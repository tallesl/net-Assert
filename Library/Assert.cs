namespace AssertLibrary
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Asserts that some condition is met.
    /// </summary>
    public static partial class Assert
    {
        private static Action<bool, string> Check;

        static Assert()
        {
            UseDebug();
        }

        /// <summary>
        /// Use System.Diagnostics.Debug.Assert.
        /// </summary>
        public static void UseDebug()
        {
            Check = (condition, message) => Debug.Assert(condition, message);
        }

        /// <summary>
        /// Use System.Diagnostics.Trace.Assert.
        /// </summary>
        public static void UseTrace()
        {
            Check = (condition, message) => Trace.Assert(condition, message);
        }

        /// <summary>
        /// Throws AssertLibrary.AssertException when needed.
        /// </summary>
        public static void UseException()
        {
            Check = (condition, message) =>
            {
                if (!condition)
                    throw new AssertException(message);
            };
        }
    }
}
