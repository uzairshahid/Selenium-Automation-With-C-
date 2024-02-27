using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_With_C_
{
    internal class SeleniumGetMethods
    {


        public static string GetText(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "ID")
                return driver.FindElement(By.Id(element)).Text;
            else if (elementType == "Name")
                return driver.FindElement(By.Name(element)).Text;
            else if (elementType == "Class")
                return driver.FindElement(By.ClassName(element)).Text;
            else if (elementType == "XPath")
                return driver.FindElement(By.XPath(element)).Text;
            else return String.Empty;

        }

    }
}
