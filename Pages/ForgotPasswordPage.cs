using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class ForgotPasswordPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement RetrievePasswordButton => driver.FindElement(By.CssSelector("#form_submit i"));
    }
}
