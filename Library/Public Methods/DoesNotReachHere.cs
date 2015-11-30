namespace AssertLibrary
{
    public static partial class Assert
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
