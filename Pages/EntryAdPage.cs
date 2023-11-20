using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class EntryAdPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ModalWindow => driver.FindElement(By.CssSelector("div[class='modal']"));
        public IWebElement CloseButton => driver.FindElement(By.CssSelector("div[class='modal-footer'] p"));

        public bool WaitModalWindow()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[class='modal-footer'] p")));
            return true;
        }
    }
}

