using OpenQA.Selenium;
using SeleniumWithCSharpAndNUnit.Base;
using SeleniumWithCSharpAndNUnit.Pages;

namespace SeleniumWithCSharpAndNUnit.Tests
{
    [TestFixture]
    public class RegisterUserTest 
    {
        private IWebDriver _driver;

        [SetUp]
        public void StartBrowser()
        {
            _driver = new WebBase().CreateDriver();
        }


        [Test]
        public void RegisterUser()
        {

            new RegisterPage(_driver)
                .Load()
                .ClickRegister()
                .Register("admin", "password", "abc123@gmail.com");
        }
        
        [TearDown]
        public void CloseBrowser()
        {
            _driver.Dispose();
            _driver.Quit();
        }
    }
}
