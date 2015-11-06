namespace ThrowIf
{
    public static partial class Throw
    {
        /// <summary>
        /// Throws ShouldntReachHere.
        /// </summary>
        /// <exception cref="ShouldntReachHereException">Always</exception>
        public static void IfReachHere()
        {
            throw new ShouldntReachHereException();
        }
    }
}
