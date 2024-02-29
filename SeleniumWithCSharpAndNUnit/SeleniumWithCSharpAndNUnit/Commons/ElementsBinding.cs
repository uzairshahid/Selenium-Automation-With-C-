using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharpAndNUnit.Commons
{
    public static class ElementsBinding
    {

        public static void ClickElement(this IWebElement element)
        {
            element.Click();
        }
        public static void SubmitElement(this IWebElement element)
        {
            element.Submit();
        }
        public static void EnterTextElement(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        

        public static void ClearElement(this IWebElement element)
        {
            element.Clear();
        }

        public static void TypeToElement(this IWebElement element, string textToType)
        {
            element.SendKeys(textToType);
        }

        public static string GetElementText(this IWebElement element)
        {
            string elemText = element.Text;
            return elemText;
        }

        public static void SelectDropboxByVisibleText(this IWebElement element, string textToType)
        {

            SelectElement dropDown = new SelectElement(element);
            dropDown.SelectByText(textToType);
        }

        public static void SelectDropboxByValue(this IWebElement element, string optionValue)
        {
            SelectElement dropDown = new SelectElement(element);
            dropDown.SelectByValue(optionValue);
        }

        public static void SelectDropboxByOptionIndex(this IWebElement element, int optionIndex)
        {
            SelectElement dropDown = new SelectElement(element);
            dropDown.SelectByIndex(optionIndex);
        }
    }
}
