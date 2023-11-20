using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class JavaScriptAlertsPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        private WebDriverWait wait;

        public IWebElement JSAlertButton => driver.FindElement(By.CssSelector("button[onclick='jsAlert()']"));
        public IWebElement JSConfirmButton => driver.FindElement(By.CssSelector("button[onclick='jsConfirm()']"));
        public IWebElement JSPromptButton => driver.FindElement(By.CssSelector("button[onclick='jsPrompt()']"));
        public IWebElement ResultMessage => driver.FindElement(By.CssSelector("p[id='result']"));
        public string ExpectedMessage1 = "You successfully clicked an alert";
        public string ExpectedMessage2 = "You clicked: Ok";
        public string ExpectedMessage3 = "You entered: Ja sam Milos";

        public void Alert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void AlertTextField(string text)
        {
            driver.SwitchTo().Alert().SendKeys(text);
            driver.SwitchTo().Alert().Accept();
        }

        public string ActualMessage()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("p[id='result']")));
            return ResultMessage.Text;
        }
    }
}

