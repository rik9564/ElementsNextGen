using ElementsNextGen.Drivers.ConfigSettings;
using ElementsNextGen.Drivers.Intitializer;
using ElementsNextGen.PageDefinitions;
using OpenQA.Selenium;

namespace ElementsNextGen.StepDefinitions
{
    [Binding]
    public sealed class loginStepDefinitions
    {
        private loginPageDefinitions? _loginPageDefinitions { get; }
        private loginStepDefinitions(loginPageDefinitions loginPageDefinitions) => _loginPageDefinitions = loginPageDefinitions;

        [Then(@"Lets wait for (.*) seconds")]
        public void ThenLetsWaitForSeconds(int p0)
        {
            Task.Delay(p0 * 1000).Wait();
        }

        [Given(@"I am Logged in to TMS")]
        public void GivenIAmLoggedInToTMS()
        {
            _loginPageDefinitions?.login();

        }

        [When(@"I Select Application (.*) from App switch Over")]
        public void WhenISelectApplicationRAMXFromAppSwitchOver(string app)
        {
            _loginPageDefinitions?.NavigateToDesiredAppSwitch(app);
        }
    }
}