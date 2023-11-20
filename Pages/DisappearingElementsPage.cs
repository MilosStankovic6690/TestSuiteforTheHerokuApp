using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class DisappearingElementsPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement AboutButton => driver.FindElement(By.LinkText("About"));
        public IWebElement ContactUsButton => driver.FindElement(By.LinkText("Contact Us"));
        public IWebElement PortfolioButton => driver.FindElement(By.LinkText("Portfolio"));
        public IWebElement GalleryButton => driver.FindElement(By.LinkText("Gallery"));

        public bool TryFindElement(IWebElement element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

