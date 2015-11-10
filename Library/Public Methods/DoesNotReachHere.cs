namespace AssertLibrary
{
    public static partial class AssertThat
    {
        /// <summary>
        /// Throws ShouldntReachHereExeption.
        /// </summary>
        /// <exception cref="ShouldNotReachHereException">Always</exception>
        public static void DoesNotReachHere()
        {
            throw new ShouldNotReachHereException();
        }
    }
}
