using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class ContexMenuPage
    {
        IWebDriver driver = WebDrivers.Instance;

        public void WaitAlert()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        public string AlertText()
        {
            return driver.SwitchTo().Alert().Text;
        }
        public string ExpectedText = "You selected a context menu";

        public IWebElement HotSpot => driver.FindElement(By.Id("hot-spot"));

        public void RightClick(IWebElement element)
        {
            var action = new Actions(driver);
            action.ContextClick(element).Perform();
        }

        public void Alert()
        {
            driver.SwitchTo().Alert().Accept();
        }
        public void AlertPresent()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();

            }
            catch (NoAlertPresentException)
            {

            }
        }
    }
}

