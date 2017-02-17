namespace PHM.Math.Words.Droid.UI.Tests
{
    using NUnit.Framework;
    using Xamarin.UITest;

    [TestFixture(Platform.Android)]
    public class FizzBuzzUITest
    {
        IApp app;
        Platform platform;

        public FizzBuzzUITest(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void Should_FizzBuzzUI_When_Enter_Multiples_Of_Three_Label_Fizz()
        {
            app.Repl();
        }
    }
}
