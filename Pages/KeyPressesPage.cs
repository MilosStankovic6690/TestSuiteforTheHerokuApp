using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class KeyPressesPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement InputField => driver.FindElement(By.CssSelector("#target"));
        public IWebElement Result => driver.FindElement(By.CssSelector("#result"));
        public string ExpectedResult = "You entered: ESCAPE";

        public void SendKeysToField()
        {
            InputField.SendKeys(Keys.Escape);
        }

        public string ActualResult()
        {
            return Result.Text;
        }
    }
}

