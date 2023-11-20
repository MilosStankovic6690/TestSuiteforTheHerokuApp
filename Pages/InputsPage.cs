using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class InputsPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement InputField => driver.FindElement(By.CssSelector("input[type='number']"));

        public void ScrollingWithTheKeyboard()
        {
            InputField.Click();
            Actions action = new Actions(driver);
            action.SendKeys(Keys.ArrowUp).Build().Perform();
            action.SendKeys(Keys.ArrowUp).Build().Perform();
            action.SendKeys(Keys.ArrowUp).Build().Perform();
        }

        public void InputNumbersInField(string num)
        {
            InputField.SendKeys(num);
        }

        public string ActualNumber()
        {
            return InputField.GetAttribute("value");
        }
    }
}
