using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class AddRemoveElementsPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement AddElementButton => driver.FindElement(By.CssSelector(".example button"));
        public IWebElement DeleteButton => driver.FindElement(By.CssSelector("#elements .added-manually"));

        public bool IsDeleteButtonPresent()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                return wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("#elements .added-manually")));
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

