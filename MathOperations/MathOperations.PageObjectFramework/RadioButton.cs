using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MathOperations.PageObjectFramework
{
    public class RadioButton : IWrapsElement
    {
        private readonly IWebElement _wrapped;

        public RadioButton(IWebElement wrapped)
        {
            _wrapped = wrapped;
        }

        public IWebElement WrappedElement
        {
            get
            {
                return _wrapped;
            }
        }

        public Set
    }
}
