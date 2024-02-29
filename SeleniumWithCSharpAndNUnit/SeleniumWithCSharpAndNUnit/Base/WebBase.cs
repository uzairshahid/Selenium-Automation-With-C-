using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharpAndNUnit.Base
{
    public class WebBase
    {
        private IWebDriver driver;
        public IWebDriver CreateDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
