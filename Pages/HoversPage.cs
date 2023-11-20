using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class HoversPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement User1 => driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[1]/img"));
        public IWebElement User2 => driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[2]/img"));
        public IWebElement User3 => driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[3]/img"));
        public IWebElement ViewProfileLink => driver.FindElement(By.LinkText("View profile"));

        public void WaitElement()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("View profile")));
        }

        public void MoveToElement()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(User2).Perform();
        }
    }
}

