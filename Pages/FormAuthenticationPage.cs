using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class FormAuthenticationPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.CssSelector("#username"));
        public IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        public IWebElement LoginButton => driver.FindElement(By.CssSelector(".radius i"));
        public IWebElement TextForSuccessfulLogout => driver.FindElement(By.CssSelector("#flash"));
        public IWebElement TextForSuccessfulLogin => driver.FindElement(By.CssSelector("#flash"));
        public IWebElement LogoutButton => driver.FindElement(By.CssSelector(".button.secondary.radius i"));
        public string ExpectedMessage = "You logged into a secure area!\n×";

        public void Login(string uName, string pass)
        {
            UserName.SendKeys(uName);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }

        public string SuccessMessage()
        {
            return TextForSuccessfulLogin.Text;
        }

        public void WaitSuccessMesage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#flash")));
        }
    }
}

