using OpenQA.Selenium;
using SeleniumWithCSharpAndNUnit.Base;
using SeleniumWithCSharpAndNUnit.Pages;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithCSharpAndNUnit.Tests
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void StartBrowser()
        {
            _driver = new WebBase().CreateDriver();
        }

        [Test]
        public void Login()
        {

            new LoginPage(_driver)
                .Load()
                .ClickLogin()
                .Login("admin", "password");
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Dispose();
            _driver.Quit();
        }
    }
}
