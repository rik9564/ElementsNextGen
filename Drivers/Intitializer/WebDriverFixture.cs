using ElementsNextGen.Drivers.ConfigSettings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsNextGen.Drivers.Intitializer
{
    public class WebDriverFixture : IDisposable
    {
        private IWebDriver? driver { get; set; }
        public NgWebDriver? Driver { get; set; }
        public void initializeDriver()
        {
            if (Settings.DriverType.ToLower().Equals("standalone"))
            {
                switch (Settings.browser.ToLower())
                {
                    case
                    "chrome":

                        ChromeOptions chromeOptions = new();
                        chromeOptions.AcceptInsecureCertificates = true;
                        chromeOptions.AddArguments("--start-maximized");
                        chromeOptions.AddArguments("--incognito");
                        driver = new ChromeDriver(chromeOptions);
                        Driver = new(driver);
                        break;

                    case
                    "edge":

                        EdgeOptions edgeOptions = new();
                        edgeOptions.AcceptInsecureCertificates = true;
                        edgeOptions.AddArguments("--start-maximized");
                        edgeOptions.AddArguments("--inPrivate");
                        driver = new EdgeDriver(edgeOptions);
                        Driver = new(driver);
                        break;

                    case
                    "firefox":

                        FirefoxOptions firefoxOptions = new();
                        firefoxOptions.AcceptInsecureCertificates = true;
                        firefoxOptions.AddArguments("--start-maximized");
                        firefoxOptions.AddArguments("--private");
                        driver = new FirefoxDriver(firefoxOptions);
                        Driver = new(driver);
                        break;

                }
            }
        }
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        public void Dispose()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
                Driver = null;
            }
        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}
