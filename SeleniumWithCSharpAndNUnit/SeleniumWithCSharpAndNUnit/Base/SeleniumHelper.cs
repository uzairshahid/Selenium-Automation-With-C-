using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharpAndNUnit.Base
{
    public class SeleniumHelper
    {
        private IWebDriver _driver;

        public SeleniumHelper(IWebDriver driver)
        {
            _driver = driver;
        }


    }
}
