using SullivanFoundation.ViewModels;

namespace Tests.Unit.ViewModels
{
    public class MainViewModelTests
    {
        private IMainViewModel _unit;

        public MainViewModelTests()
        {
            _unit = new MainViewModel();
        }

        [Fact]
        public void Should_Greet()
        {
            var greeting = "foo";
            Assert.Equal("Good morning, Dave.", _unit.Greeting);

            _unit.Greeting = greeting;
            Assert.Equal(_unit.Greeting, greeting);
        }
    }
}
