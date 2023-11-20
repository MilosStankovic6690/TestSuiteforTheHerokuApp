using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class JQueryUIMenusPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        private WebDriverWait wait;

        public IWebElement Enabled => driver.FindElement(By.LinkText("Enabled"));
        public IWebElement Downloads => driver.FindElement(By.LinkText("Downloads"));
        public IWebElement BackToJQueryUI => driver.FindElement(By.LinkText("Back to JQuery UI"));
        public IWebElement JQueryUIPage => driver.FindElement(By.CssSelector(".example h3"));
        public string ExpectedPageTitle = "JQuery UI";

        public void MoveToElement()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            Actions move = new Actions(driver);
            move.MoveToElement(Enabled).Perform();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Downloads")));
            move.MoveToElement(Downloads).Perform();
            move.MoveToElement(BackToJQueryUI).Click().Perform();
        }

        public string ActualPageTitle()
        {
            return JQueryUIPage.Text;
        }
    }
}

