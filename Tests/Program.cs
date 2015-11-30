namespace AssertLibrary.Tests
{
    using PromptLibrary;
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Prompt.Title("Assert tests");
            Prompt.ClearBetweenSays();

            #if DEBUG

            var method = Prompt.Ask<Methods>("Method name");

            switch (method)
            {
                case Methods.DoesNotReachHere:
                    DoesNotReachHere();
                    break;
       
                case Methods.HasElements:
                    HasElements();
                    break;

                case Methods.HasExactly:
                    HasExactly();
                    break;

                case Methods.HasLess:
                    HasLess();
                    break;

                case Methods.HasMore:
                    HasMore();
                    break;

                case Methods.IsIn:
                    IsIn();
                    break;

                case Methods.IsInEnum:
                    IsInEnum();
                    break;

                case Methods.IsLess:
                    IsLess();
                    break;

                case Methods.IsNegative:
                    IsNegative();
                    break;

                case Methods.IsNotDefault:
                    IsNotDefault();
                    break;

                case Methods.IsNotNullMessage:
                    IsNotNullMessage();
                    break;

                case Methods.IsNotSingle:
                    IsNotSingle();
                    break;

                case Methods.IsNotZero:
                    IsNotZero();
                    break;

                case Methods.IsMore:
                    IsMore();
                    break;

                case Methods.IsPositive:
                    IsPositive();
                    break;

                case Methods.IsSingle:
                    IsSingle();
                    break;
            }

            #else

            Prompt.Say("Run in debug!");

            #endif
        }

        private static void ValidNext()
        {
            Prompt.Say("Asserting a valid example (you should NOT see an assertion error box now).");
        }

        private static void InvalidNext()
        {
            Prompt.Say("Now asserting an invalid one (you should see an assertion error box now).");
        }

        private static void DoesNotReachHere()
        {
            try
            {
                AssertThat.DoesNotReachHere();
            }
            catch (ShouldNotReachHereException e)
            {
                Prompt.Say("{0} was catch!", e.GetType().Name);
            }
        }

        private static void HasElements()
        {
            ValidNext();
            AssertThat.HasElements(new[] { 1, });

            InvalidNext();
            AssertThat.HasElements(new int[] { });
        }

        private static void HasExactly()
        {
            ValidNext();
            AssertThat.HasExactly(3, new[] { 1, 2, 3, });

            InvalidNext();
            AssertThat.HasExactly(3, new[] { 1, 2, });
        }

        private static void HasLess()
        {
            ValidNext();
            AssertThat.HasLess(3, new[] { 1, 2, });

            InvalidNext();
            AssertThat.HasLess(3, new[] { 1, 2, 3, });
        }

        private static void HasMore()
        {
            ValidNext();
            AssertThat.HasMore(3, new[] { 1, 2, 3, 4, });

            InvalidNext();
            AssertThat.HasMore(3, new[] { 1, 2, 3, });
        }

        private static void IsIn()
        {
            ValidNext();
            AssertThat.IsIn(3, new[] { 1, 2, 3, });

            InvalidNext();
            AssertThat.IsIn(3, new[] { 1, 2, });
        }

        private static void IsInEnum()
        {
            ValidNext();
            AssertThat.IsInEnum<Methods>(0);

            InvalidNext();
            AssertThat.IsInEnum<Methods>(int.MaxValue);
        }

        private static void IsLess()
        {
            ValidNext();
            AssertThat.IsLess(-1, 0);
            AssertThat.IsLess(1L, 2L);
            AssertThat.IsLess(0f, 0.1f);
            AssertThat.IsLess(0.05, 0.1);

            InvalidNext();
            AssertThat.IsLess(2, 1);
        }

        private static void IsNegative()
        {
            ValidNext();
            AssertThat.IsNegative(-1);
            AssertThat.IsNegative(-1L);
            AssertThat.IsNegative(-1f);
            AssertThat.IsNegative(-1d);
            AssertThat.IsNegative(-1m);

            InvalidNext();
            AssertThat.IsNegative(1);
        }

        private static void IsNotDefault()
        {
            ValidNext();
            AssertThat.IsNotDefault(Guid.NewGuid());

            InvalidNext();
            AssertThat.IsNotDefault(new Guid());
        }

        private static void IsNotNullMessage()
        {
            ValidNext();
            AssertThat.IsNotNull(string.Empty);

            InvalidNext();
            AssertThat.IsNotNull(null);
        }

        private static void IsNotSingle()
        {
            ValidNext();
            AssertThat.IsNotSingle(new int[] { });
            AssertThat.IsNotSingle(new[] { 1, 2, });

            InvalidNext();
            AssertThat.IsNotSingle(new[] { 1, });
        }

        private static void IsNotZero()
        {
            ValidNext();
            AssertThat.IsNotZero(1);
            AssertThat.IsNotZero(1L);
            AssertThat.IsNotZero(1f);
            AssertThat.IsNotZero(1d);
            AssertThat.IsNotZero(1m);

            InvalidNext();
            AssertThat.IsNotZero(0);
        }

        private static void IsMore()
        {
            ValidNext();
            AssertThat.IsMore(0, -1);
            AssertThat.IsMore(2L, 1L);
            AssertThat.IsMore(0.1f, 0f);
            AssertThat.IsMore(0.1, 0.05);

            InvalidNext();
            AssertThat.IsMore(1, 2);
        }

        private static void IsPositive()
        {
            ValidNext();
            AssertThat.IsPositive(1);
            AssertThat.IsPositive(1L);
            AssertThat.IsPositive(1f);
            AssertThat.IsPositive(1d);
            AssertThat.IsPositive(1m);

            InvalidNext();
            AssertThat.IsPositive(-1);
        }

        private static void IsSingle()
        {
            ValidNext();
            AssertThat.IsSingle(new[] { 1, });

            InvalidNext();
            AssertThat.IsSingle(new[] { 1, 2, });
        }
    }
}
