using AccptanceTests.Web.Pages;
using MathOperations.PageObjectFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AccptanceTests.Web.Steps
{
    [Binding]
    public sealed class OperationHistory : Step
    {

        [When(@"I performed five operations")]
        public void WhenIPerformedFiveOperations()
        {
            for (var i = 0; i < 5; i++) { 
            On<CalculatorPage>().Number1.SendKeys((i+1).ToString());
            On<CalculatorPage>().AddButton.Click();
            On<CalculatorPage>().Number2.SendKeys((i+2).ToString());
            On<CalculatorPage>().EqualsButton.Click();
            }
        }

        [Then(@"the result are shown in history operations")]
        public void ThenTheResultAreShownInHistoryOperations()
        {
            Assert.AreEqual(On<CalculatorPage>().history0.Text, "12345 + 23456 = 35801");
            Assert.AreEqual(On<CalculatorPage>().history1.Text, "1234 + 2345 = 3579");
            Assert.AreEqual(On<CalculatorPage>().history2.Text, "123 + 234 = 357");
            Assert.AreEqual(On<CalculatorPage>().history3.Text, "12 + 23 = 35");
            Assert.AreEqual(On<CalculatorPage>().history4.Text, "1 + 2 = 3");
        }
    }
}

