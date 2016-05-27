using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.PageObjectFramework
{
    public static class PageObjectFactory
    {
        private static Dictionary<Type, PageObject> _instanceList = new Dictionary<Type, PageObject>();

        public static PageObject Instance(Type type)
        {
            if (!_instanceList.ContainsKey(type))
            {
                var driver = DriverFactory.Driver();
                var page = (PageObject)Activator.CreateInstance(type, driver);
                PageFactory.InitElements(driver, page);
                _instanceList.Add(type, page);
            }
            return _instanceList[type];
        }

        public static void Close()
        {
            _instanceList = new Dictionary<Type, PageObject>();
            DriverFactory.CloseCurrent();
        }
    }
}
