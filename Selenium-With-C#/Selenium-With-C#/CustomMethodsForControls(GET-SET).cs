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
    

        [SetUp]
        public void Initialize()
        {

            // Initialize the driver
            PropertiesCollection.driver = new ChromeDriver();
            //  driver.Navigate().GoToUrl("https://www.techlistic.com/p/selenium-practice-form.html");
            PropertiesCollection.driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Console.WriteLine("URL Opening");
        }

        [Test]  // Click on drop down and select Option // drop down
        public void DropDownTestExecute()
        {
            PropertiesCollection.driver.Navigate().GoToUrl(PropertiesCollection.driver.Url + "dropdown");
            SeleniumSetMethods.Click("dropdown", PropertiesCollection.PropertyType.Id);
            SeleniumSetMethods.SelectDropDown("dropdown", "Option 2", PropertiesCollection.PropertyType.Id);
            SeleniumSetMethods.Click("dropdown", PropertiesCollection.PropertyType.Id);
            Console.WriteLine(SeleniumGetMethods.GetText("dropdown", PropertiesCollection.PropertyType.Id));

        }

        [Test]
        public void InputBoxTestExecute()
        {
            PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
            PropertiesCollection.driver.Navigate().GoToUrl(PropertiesCollection.driver.Url + "inputs");
            SeleniumSetMethods.Click("//*[@id=\"content\"]/div/div/div/input", PropertiesCollection.PropertyType.XPath);
            SeleniumSetMethods.EnterText("//*[@id=\"content\"]/div/div/div/input", "1234", PropertiesCollection.PropertyType.XPath);
        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();

        }




    }
}
