namespace Assert.Tests
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

                case Methods.IsNotDefault:
                    IsNotDefault();
                    break;

                case Methods.IsNotNullMessage:
                    IsNotNullMessage();
                    break;

                case Methods.IsNotSingle:
                    IsNotSingle();
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

        private static void IsSingle()
        {
            ValidNext();
            AssertThat.IsSingle(new[] { 1, });

            InvalidNext();
            AssertThat.IsSingle(new[] { 1, 2, });
        }
    }
}
