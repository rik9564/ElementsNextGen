using OpenQA.Selenium;
using Protractor;

namespace ElementsNextGen.Drivers.Intitializer
{
    [Binding]
    public class WebDriverHooks
    {
        private readonly WebDriverFixture _fixture;

        private WebDriverHooks(WebDriverFixture fixture) => _fixture = fixture;
        public NgWebDriver? Driver => _fixture.Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _fixture.initializeDriver();
        }
        [AfterScenario]
        public void AfterScenario() { }
    }

}
