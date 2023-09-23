using ElementsNextGen.Drivers.ConfigSettings;
using ElementsNextGen.Drivers.Intitializer;
using ElementsNextGen.Support;
using OpenQA.Selenium;
using Protractor;

namespace ElementsNextGen.PageDefinitions
{
    public class loginPageDefinitions
    {
        private NgWebDriver? Driver { get; }
        private loginPageDefinitions(WebDriverHooks hooks) => Driver = hooks.Driver;

        private By txtUserName => By.CssSelector("[test-id='login-input-username']");
        private By txtPassword => By.CssSelector("[test-id='login-input-password']");
        private By btnlogin => By.CssSelector("[test-id='login-btn-login']");
        private By AppSwitchDashboard => By.CssSelector("[title='Application Switch'] em");

        internal void login()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Driver.Navigate().GoToUrl(Settings.BaseUrl);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Settings.ImplicitWait);
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(Settings.ImplicitWait);
            txtUserName.type(Driver, Settings.Username);
            txtPassword.type(Driver, Settings.Password);
            btnlogin.Click(Driver);
        }

        internal void NavigateToDesiredAppSwitch(string app)
        {
            AppSwitchDashboard.Click(Driver);
            By.XPath($"(//small[.='{app}']//..//..)[1]").Click(Driver);

        }
    }
}
