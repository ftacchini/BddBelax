using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MathOperations.PageObjectFramework
{
    public class Step
    {
        public T On<T>() where T : PageObject
        {
            return (T)PageObjectFactory.Instance(typeof(T));
        }

        [AfterScenario("web")]
        public void AfterScenario()
        {
            PageObjectFactory.Close();
        }
    }
}
