using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class JavaScriptOnloadEventErrorPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ErrorMessage => driver.FindElement(By.CssSelector("body[onload='loadError()']"));
        public string ExpectedMessage = "This page has a JavaScript error in the onload event. This is often a problem to using normal Javascript injection techniques.";

        public string ActualErrorMessage()
        {
            return ErrorMessage.Text;
        }
    }
}

