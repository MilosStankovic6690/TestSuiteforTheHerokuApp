using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class FloatingMenuPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement News => driver.FindElement(By.LinkText("News"));
        public IWebElement About => driver.FindElement(By.LinkText("About"));
        public IWebElement ElementToScroll => driver.FindElement(By.CssSelector("div[class='scroll large-10 columns large-centered'] p:nth-child(10)"));

        public bool elementIsDisplayed()
        {
            return About.Displayed;
        }

        public void MoveToElement()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(News).MoveToElement(About).Perform();
        }

        public void ScrollToElement()
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            scroll.ExecuteScript("arguments[0].scrollIntoView(true);", ElementToScroll);
        }
    }
}

