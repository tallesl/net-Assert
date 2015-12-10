namespace AssertLibrary.Tests
{
    using PromptLibrary;
    using System;

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

                case Methods.IsEqual:
                    IsEqual();
                    break;

                case Methods.IsFalse:
                    IsFalse();
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

                case Methods.IsNotEqual:
                    IsNotEqual();
                    break;

                case Methods.IsNotNull:
                    IsNotNull();
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

                case Methods.IsTrue:
                    IsTrue();
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
                Assert.DoesNotReachHere();
            }
            catch (ShouldNotReachHereException e)
            {
                Prompt.Say("{0} was catch!", e.GetType().Name);
            }
        }

        private static void HasElements()
        {
            ValidNext();
            Assert.HasElements(new[] { 1, });

            InvalidNext();
            Assert.HasElements(new int[] { });
        }

        private static void HasExactly()
        {
            ValidNext();
            Assert.HasExactly(3, new[] { 1, 2, 3, });

            InvalidNext();
            Assert.HasExactly(3, new[] { 1, 2, });
        }

        private static void HasLess()
        {
            ValidNext();
            Assert.HasLess(3, new[] { 1, 2, });

            InvalidNext();
            Assert.HasLess(3, new[] { 1, 2, 3, });
        }

        private static void HasMore()
        {
            ValidNext();
            Assert.HasMore(3, new[] { 1, 2, 3, 4, });

            InvalidNext();
            Assert.HasMore(3, new[] { 1, 2, 3, });
        }

        private static void IsEqual()
        {
            ValidNext();
            Assert.IsEqual(1, 1);

            InvalidNext();
            Assert.IsEqual(1, "1");
        }

        private static void IsFalse()
        {
            ValidNext();
            Assert.IsFalse(false);

            InvalidNext();
            Assert.IsFalse(true);
        }

        private static void IsIn()
        {
            ValidNext();
            Assert.IsIn(3, new[] { 1, 2, 3, });

            InvalidNext();
            Assert.IsIn(3, new[] { 1, 2, });
        }

        private static void IsInEnum()
        {
            ValidNext();
            Assert.IsInEnum<Methods>(0);

            InvalidNext();
            Assert.IsInEnum<Methods>(int.MaxValue);
        }

        private static void IsLess()
        {
            ValidNext();
            Assert.IsLess(-1, 0);
            Assert.IsLess(1L, 2L);
            Assert.IsLess(0f, 0.1f);
            Assert.IsLess(0.05, 0.1);

            InvalidNext();
            Assert.IsLess(2, 1);
        }

        private static void IsNegative()
        {
            ValidNext();
            Assert.IsNegative(-1);
            Assert.IsNegative(-1L);
            Assert.IsNegative(-1f);
            Assert.IsNegative(-1d);
            Assert.IsNegative(-1m);

            InvalidNext();
            Assert.IsNegative(1);
        }

        private static void IsNotDefault()
        {
            ValidNext();
            Assert.IsNotDefault(Guid.NewGuid());

            InvalidNext();
            Assert.IsNotDefault(new Guid());
        }

        private static void IsNotEqual()
        {
            ValidNext();
            Assert.IsNotEqual(1, "1");

            InvalidNext();
            Assert.IsNotEqual(1, 1);
        }

        private static void IsNotNull()
        {
            ValidNext();
            Assert.IsNotNull(string.Empty);

            InvalidNext();
            Assert.IsNotNull(null);
        }

        private static void IsNotSingle()
        {
            ValidNext();
            Assert.IsNotSingle(new int[] { });
            Assert.IsNotSingle(new[] { 1, 2, });

            InvalidNext();
            Assert.IsNotSingle(new[] { 1, });
        }

        private static void IsNotZero()
        {
            ValidNext();
            Assert.IsNotZero(1);
            Assert.IsNotZero(1L);
            Assert.IsNotZero(1f);
            Assert.IsNotZero(1d);
            Assert.IsNotZero(1m);

            InvalidNext();
            Assert.IsNotZero(0);
        }

        private static void IsMore()
        {
            ValidNext();
            Assert.IsMore(0, -1);
            Assert.IsMore(2L, 1L);
            Assert.IsMore(0.1f, 0f);
            Assert.IsMore(0.1, 0.05);

            InvalidNext();
            Assert.IsMore(1, 2);
        }

        private static void IsPositive()
        {
            ValidNext();
            Assert.IsPositive(1);
            Assert.IsPositive(1L);
            Assert.IsPositive(1f);
            Assert.IsPositive(1d);
            Assert.IsPositive(1m);

            InvalidNext();
            Assert.IsPositive(-1);
        }

        private static void IsSingle()
        {
            ValidNext();
            Assert.IsSingle(new[] { 1, });

            InvalidNext();
            Assert.IsSingle(new[] { 1, 2, });
        }

        private static void IsTrue()
        {
            ValidNext();
            Assert.IsTrue(true);

            InvalidNext();
            Assert.IsTrue(false);
        }
    }
}
