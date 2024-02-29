using OpenQA.Selenium;
using SeleniumWithCSharpAndNUnit.Base;
using SeleniumWithCSharpAndNUnit.Commons;

namespace SeleniumWithCSharpAndNUnit.Pages
{
    public class RegisterPage
    {
        private readonly IWebDriver _driver;

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }
        IWebElement RegisterLink => _driver.FindElement(By.Id("registerLink"));
        IWebElement TextUserName => _driver.FindElement(By.Id("UserName"));
        IWebElement TextPassword => _driver.FindElement(By.Id("Password"));
        IWebElement TextConfirmPassword => _driver.FindElement(By.Id("ConfirmPassword"));
        IWebElement TextEmail => _driver.FindElement(By.Id("Email"));
        IWebElement BtnRegister => _driver.FindElement(By.CssSelector(".btn"));


        public RegisterPage Load()
        {
            _driver.Navigate().GoToUrl(Constants.URL_HOME_PAGE);
            return this;
        }

        public RegisterPage ClickRegister()
        {
            RegisterLink.ClickElement();
            return this;
        }

        public void Register(string UserName, string Password, string Email)
        {
            TextUserName.EnterTextElement(UserName);
            TextPassword.EnterTextElement(Password);
            TextConfirmPassword.EnterTextElement(Password);
            TextEmail.EnterTextElement(Email);
            BtnRegister.SubmitElement();
        }
    }
}
