using OpenQA.Selenium;
using Protractor;

namespace ElementsNextGen.Support
{
    public static class BySupport
    {
        public static IWebElement get(this By by, IWebDriver driver)
        {
            return driver.FindElement(by);
        }
        public static IWebElement type(this By by, NgWebDriver driver, string val)
        {
            driver.FindElement(by).SendKeys(val);
            return driver.FindElement(by);
        }
        public static void Click(this By by, IWebDriver driver)
        {
            driver.FindElement(by).Click();
        }
        public static void Select(this By by, IWebDriver driver, string val)
        {
            driver.FindElement(by).Click();
            By.XPath($"//li[.='{val}']").Click(driver);
        }
    }
}
