using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class DynamicLoadingPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Example_1 => driver.FindElement(By.LinkText("Example 1: Element on page that is hidden"));
        public IWebElement Example_2 => driver.FindElement(By.LinkText("Example 2: Element rendered after the fact"));
        public IWebElement StartButton => driver.FindElement(By.CssSelector("div[id='start'] button"));
        public IWebElement HelloWorld => driver.FindElement(By.CssSelector("#finish h4"));

        public string HelloWorldMessage()
        {
            return HelloWorld.Text;
        }

        public bool WaitForMessage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#finish h4")));
            return true;
        }
    }
}

