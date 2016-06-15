using MathOperations.PageObjectFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccptanceTests.Web.Pages
{
    public class CalculatorPage : PageObject
    {
        public CalculatorPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.Id, Using = "number1")]
        public IWebElement Number1 { get; set; }

        [FindsBy(How = How.Id, Using = "number2")]
        public IWebElement Number2 { get; set; }

        [FindsBy(How = How.Id, Using = "equals")]
        public IWebElement EqualsButton { get; set; }

        [FindsBy(How = How.Id, Using = "add")]
        public IWebElement AddButton { get; set; }

        [FindsBy(How = How.Id, Using = "divide")]
        public IWebElement DivideButton { get; set; }

        [FindsBy(How = How.Id, Using = "multiply")]
        public IWebElement MultiplyButton { get; set; }

        [FindsBy(How = How.Id, Using = "substract")]
        public IWebElement SubstractButton { get; set; }

        [FindsBy(How = How.Id, Using = "result")]
        private IWebElement _result;

        [FindsBy(How = How.Id, Using = "0history")]
        public IWebElement history0 { get; set; }
        [FindsBy(How = How.Id, Using = "1history")]
        public IWebElement history1 { get; set; }
        [FindsBy(How = How.Id, Using = "2history")]
        public IWebElement history2 { get; set; }
        [FindsBy(How = How.Id, Using = "3history")]
        public IWebElement history3 { get; set; }
        [FindsBy(How = How.Id, Using = "4history")]
        public IWebElement history4 { get; set; }
        public IWebElement Result
        {
            get
            {
                try
                {
                    var wait = new WebDriverWait(this.Webdriver, TimeSpan.FromSeconds(2));
                    wait.Until(driver => !string.IsNullOrEmpty(_result.Text));
                }
                catch (Exception ex)
                {

                }

                return _result;
            }
        }

        public void Navigate()
        {
            base.VisitPage(ConfigurationManager.AppSettings["WebUrl"]);
        }
    }
}
