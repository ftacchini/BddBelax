using AccptanceTests.Web.Pages;
using MathOperations.PageObjectFramework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AccptanceTests.Web.Steps
{
    [Binding]
    public class WebOperations : Step
    {
        [Given(@"I have navigated to the calculators page")]
        public void GivenIHaveNavigatedToTheCalculatorsPage()
        {
            On<CalculatorPage>().Navigate();
        }

        [Given(@"I have entered (.*) into the calculator as first number")]
        public void GivenIHaveEnteredIntoTheCalculatorAsFirstNumber(int number1)
        {
            On<CalculatorPage>().Number1.SendKeys(number1.ToString());
        }

        [Given(@"I have entered (.*) into the calculator as second number")]
        public void GivenIHaveEnteredIntoTheCalculatorAsSecondNumber(int number2)
        {
            On<CalculatorPage>().Number2.SendKeys(number2.ToString());
        }

        [Given(@"I have pressed the ""(.*)"" button")]
        public void GivenIHavePressedTheButton(string button)
        {
            switch(button)
            {
                case "add":
                    On<CalculatorPage>().AddButton.Click();
                    break;
                case "substract":
                    On<CalculatorPage>().SubstractButton.Click();
                    break;
                case "multiply":
                    On<CalculatorPage>().MultiplyButton.Click();
                    break;
                case "divide":
                    On<CalculatorPage>().DivideButton.Click();
                    break;
            }
            
        }

        [When(@"I press the equals button")]
        public void WhenIPressTheEqualsButton()
        {
            On<CalculatorPage>().EqualsButton.Click();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(On<CalculatorPage>().Result.Text, expectedResult.ToString());
        }

    }
}
