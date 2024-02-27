using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenium_With_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_With_C_
{
    internal class CustomMethodsForControls_SET_
    {

        // here we will write custom methods of controls to SET values in them like
        // Text Box
        // Drop Down Box
        // Check Box etc

        // Initialize the driver
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            //  driver.Navigate().GoToUrl("https://www.techlistic.com/p/selenium-practice-form.html");
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Console.WriteLine("URL Opening");
        }

        [Test]  // Click on drop down and select Option // drop down
        public void DropDownTestExecute()
        {
            driver.Navigate().GoToUrl(driver.Url + "dropdown");
            SeleniumSetMethods.Click(driver, "dropdown", "ID");
            SeleniumSetMethods.SelectDropDown(driver, "dropdown", "Option 2", "ID");
            SeleniumSetMethods.Click(driver, "dropdown", "ID");
            Console.WriteLine(SeleniumGetMethods.GetText(driver, "dropdown", "ID"));

        }

        [Test]
        public void InputBoxTestExecute()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl(driver.Url + "inputs");
            SeleniumSetMethods.Click(driver, "//*[@id=\"content\"]/div/div/div/input", "XPath");
            SeleniumSetMethods.EnterText(driver, "//*[@id=\"content\"]/div/div/div/input", "1234", "XPath");
        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }




    }
}
