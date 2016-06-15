using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.PageObjectFramework
{
    public static class DriverFactory
    {
        private static RemoteWebDriver _instance;

        private static RemoteWebDriver GetDriver()
        {
            switch (ConfigurationManager.AppSettings["Browser"])
            {
                case "Chrome":
                    return new ChromeDriver(@"C:\chromedriver");
                case "IE":
                    return new InternetExplorerDriver(@"C:\IEDriverServer");
                case "Firefox":
                default:
                    return new FirefoxDriver();
            }
        }

        public static RemoteWebDriver Driver()
        {
            if (_instance == null) _instance = GetDriver();
            return _instance;
        }

        public static void CloseCurrent()
        {
            if (_instance != null)
            {
                _instance.Quit();
                _instance = null;
            }
        }
    }
}
