using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_With_CSharp
{
   
     class Program
    {
        // Initialize the driver
        IWebDriver driver = new ChromeDriver();
        //static void Main(string[] args)
        //{
           
        //}



        [SetUp]
        public void Initialize()
        {
           // driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

        }

        [Test] 
        public void ExecuteTest()
        {
            IWebElement acceptCookies = driver.FindElement(By.ClassName("sy4vM"));
            acceptCookies.Click();

            IWebElement searchBoxElement = driver.FindElement(By.ClassName("gLFyf"));

            // Perform Operation
            searchBoxElement.SendKeys("Uzair Shahid");
        }



        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }
    }
}
