using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using static Selenium_With_C_.PropertiesCollection;

namespace Selenium_With_C_
{
    internal class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(String element, String value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            else if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            else if (elementType == PropertyType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            else if (elementType == PropertyType.CssName)
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            else if (elementType == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
            else if (elementType == PropertyType.LinkText)
                PropertiesCollection.driver.FindElement(By.LinkText(element)).SendKeys(value);
        }


        // Click on Button, Text Box, Check Box, Radio, Options etc
        public static void Click( String element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            else if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            else if (elementType == PropertyType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
            else if (elementType == PropertyType.CssName)
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
            else if (elementType == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();
            else if (elementType == PropertyType.LinkText)
                PropertiesCollection.driver.FindElement(By.LinkText(element)).Click();
        }


        // Selecting a drop down control 
        public static void SelectDropDown( String element, String value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            else if (elementType == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            else if (elementType == PropertyType.XPath)
                new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
            else if (elementType == PropertyType.CssName)
                new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
            else if (elementType == PropertyType.ClassName)
                new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).SelectByText(value);
            else if (elementType == PropertyType.LinkText)
                new SelectElement(PropertiesCollection.driver.FindElement(By.LinkText(element))).SelectByText(value);
        }
    }
}
