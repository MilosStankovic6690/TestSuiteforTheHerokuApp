using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class DynamicControlsPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement CheckBox => driver.FindElement(By.CssSelector("input[type='checkbox']"));
        public IWebElement RemoveButton => driver.FindElement(By.CssSelector("button[onclick='swapCheckbox()']"));
        public IWebElement EnableButton => driver.FindElement(By.CssSelector("button[onclick='swapInput()']"));
        public IWebElement TextField => driver.FindElement(By.CssSelector("input[type='text']"));
        public IWebElement Message => driver.FindElement(By.CssSelector("p#message"));
        public string DisableMessage = "It's disabled!";
        public string EnableMessage = "It's enabled!";

        public string ActualMessage()
        {
            return Message.Text;
        }

        public bool WaitForCheckBoxToDisappear()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("input[type='checkbox']")));
            return true;
        }

        public bool WaitForMessage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("p#message")));
            return true;
        }
    }
}

