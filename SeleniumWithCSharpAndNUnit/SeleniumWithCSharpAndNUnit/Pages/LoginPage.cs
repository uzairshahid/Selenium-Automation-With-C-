using OpenQA.Selenium;
using SeleniumWithCSharpAndNUnit.Base;
using SeleniumWithCSharpAndNUnit.Commons;

namespace SeleniumWithCSharpAndNUnit.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement LoginLink => _driver.FindElement(By.Id("loginLink"));
        IWebElement TextUserName => _driver.FindElement(By.Id("UserName"));
        IWebElement TextPassword => _driver.FindElement(By.Id("Password"));
        IWebElement BtnLogin => _driver.FindElement(By.CssSelector(".btn"));


        public LoginPage Load()
        {
            _driver.Navigate().GoToUrl(Constants.URL_HOME_PAGE);
            return this;
        }

        public LoginPage ClickLogin()
        {
            LoginLink.ClickElement();
            return this;
        }

        public void Login(string UserName, string Password)
        {
            TextUserName.EnterTextElement(UserName);
            TextPassword.EnterTextElement(Password);
            BtnLogin.SubmitElement();
        }
    }
}
