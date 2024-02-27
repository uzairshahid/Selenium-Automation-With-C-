using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Selenium_With_C_.PropertiesCollection;

namespace Selenium_With_C_
{
    internal class SeleniumGetMethods
    {


        public static string GetText(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).Text;
            else if (elementType == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).Text;
            else if (elementType == PropertyType.ClassName)
                return PropertiesCollection.driver.FindElement(By.ClassName(element)).Text;
            else if (elementType == PropertyType.XPath)
                return PropertiesCollection.driver.FindElement(By.XPath(element)).Text;
            else if (elementType == PropertyType.CssName)
                return PropertiesCollection.driver.FindElement(By.CssSelector(element)).Text;
            else if (elementType == PropertyType.LinkText)
                return PropertiesCollection.driver.FindElement(By.LinkText(element)).Text;
            else return String.Empty;

        }

    }
}
