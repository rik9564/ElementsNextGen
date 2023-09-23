using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ElementsNextGen.Drivers.ConfigSettings
{
    public static class Settings
    {
        private static string? getParameters(string parameterName)
        {
            try
            {
                XDocument doc = XDocument.Load("C:\\NewElementsNextGen\\ElementsNextGen\\specflow.runsettings");
                var paramElement = doc.Descendants("Parameter").FirstOrDefault(e => e.Attribute("name")?.Value == parameterName);
                if (paramElement != null)
                {
                    return paramElement.Attribute("value")?.Value;
                }
            }
            catch
            {
                return null;
            }
            return null;
        }
        //...............................................................................//
        //return all The Methods Here and Set the String to the Settings variable
        public static string BaseUrl { get { return getUrl(); } }
        public static string DriverType { get { return getDriverType(); } }
        public static string browser { get { return getBrowser(); } }
        public static int ImplicitWait { get { return getImplicitWait(); } }
        public static string Username { get { return getUsername(); } }
        public static string Password { get { return getPassword(); } }
        //................................................................................//

        private static string getUrl()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return getParameters("baseUrl");
#pragma warning restore CS8603 // Possible null reference return.

        }
        private static string getDriverType()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return getParameters("driverType");
#pragma warning restore CS8603 // Possible null reference return.
        }
        private static string getBrowser()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return getParameters("browser");
#pragma warning restore CS8603 // Possible null reference return.
        }
        private static string getUsername()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return getParameters("username");
#pragma warning restore CS8603 // Possible null reference return.
        }
        private static string getPassword()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return getParameters("password");
#pragma warning restore CS8603 // Possible null reference return.
        }
        private static int getImplicitWait()
        {
#pragma warning disable CS8604 // Possible null reference argument.
            return int.Parse(getParameters("implicitWait"));
#pragma warning restore CS8604 // Possible null reference argument.

        }




    }
}

