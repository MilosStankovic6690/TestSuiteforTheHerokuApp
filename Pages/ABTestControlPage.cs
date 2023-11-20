using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class ABTestControlPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement TestControlText => driver.FindElement(By.CssSelector(".example h3"));
        public string ABTestingUrl = "http://the-internet.herokuapp.com/abtest";
    }
}

