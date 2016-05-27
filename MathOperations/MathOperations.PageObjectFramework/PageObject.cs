using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.PageObjectFramework
{
    public class PageObject
    {
        protected IWebDriver Webdriver { get; set; }

        public PageObject(IWebDriver driver)
        {
            Webdriver = driver;
        }

        protected void VisitPage(string pageURL)
        {
            Webdriver.Navigate().GoToUrl(pageURL);
        }

        public string GetActualURL()
        {
            return Webdriver.Url;
        }
    }
}
