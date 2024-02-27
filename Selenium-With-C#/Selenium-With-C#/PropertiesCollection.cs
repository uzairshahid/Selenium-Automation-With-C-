using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_With_C_
{
    internal class PropertiesCollection
    {
        // Auto-Implemented properties
        public static IWebDriver driver { get; set; }

       public enum PropertyType
        {
           Id,
           Name,
           ClassName,
           CssName,
           XPath,
           LinkText
        }
    }
}
