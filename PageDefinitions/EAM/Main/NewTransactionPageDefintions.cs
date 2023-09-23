using ElementsNextGen.Drivers.Intitializer;
using ElementsNextGen.Support;
using OpenQA.Selenium;
using Protractor;

namespace ElementsNextGen.PageDefinitions.EAM.Main
{
    public class NewTransactionPageDefintions
    {
        private NgWebDriver? Driver { get; }
        private NewTransactionPageDefintions(WebDriverHooks hooks) => Driver = hooks.Driver;


        //Write the Locators Here.......
        By Main => By.CssSelector("[test-id='menu-51']");
        By drpTransactionCode => By.CssSelector("[test-id='transaction-select-code'] button");
        By drpTypeOfApplication => By.CssSelector("[test-id='transaction-select-typeOfApplication'] button");


        //Write the Methods Here.......
        internal void navigateMainAndSubMenu(string subMenu)
        {
            Main.Click(Driver);
            By MainMenuSubMenu = By.XPath($"//span[contains(.,'{subMenu}')]");
            MainMenuSubMenu.Click(Driver);
        }
        internal void selectTransactionCode(string Code)
        {
            drpTransactionCode.Select(Driver, Code);
        }
        internal void selectTypeOfApplication(string type)
        {
            drpTypeOfApplication.Select(Driver, type);
        }

    }
}
