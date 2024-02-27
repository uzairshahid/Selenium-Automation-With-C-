using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Selenium_With_C_
{
    internal class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(IWebDriver driver, String element, String value, String elementType)
        {
            if (elementType == "ID")
                driver.FindElement(By.Id(element)).SendKeys(value);
            else if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            else if (elementType == "XPath")
                driver.FindElement(By.XPath(element)).SendKeys(value);
        }


        // Click on Button, Text Box, Check Box, Radio, Options etc
        public static void Click(IWebDriver driver, String element, String elementType)
        {
            if (elementType == "ID")
                driver.FindElement(By.Id(element)).Click();
            else if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
            else if (elementType == "XPath")
                driver.FindElement(By.XPath(element)).Click(); 
            else if (elementType == "Class")
                driver.FindElement(By.ClassName(element)).Click();
        }


        // Selecting a drop down control 
        public static void SelectDropDown(IWebDriver driver, String element, String value, String elementType)
        {
            if (elementType == "ID")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            else if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            else if (elementType == "XPath")
                new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);
        }
    }
}
