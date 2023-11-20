using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class CheckboxesPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Checkbox1 => driver.FindElement(By.CssSelector("#checkboxes input[type=\"checkbox\"]:nth-child(1)"));
        public IWebElement Checkbox2 => driver.FindElement(By.CssSelector("#checkboxes input[type=\"checkbox\"]:nth-child(3)"));
    }
}

