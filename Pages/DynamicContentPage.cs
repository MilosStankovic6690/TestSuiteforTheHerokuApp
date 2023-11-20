using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class DynamicContentPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ClickHere => driver.FindElement(By.LinkText("click here"));
        public IWebElement Content => driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/div[2]"));

        public string InitialContent()
        {
            return Content.Text;
        }

        public string RefreshedContent()
        {
            return Content.Text;
        }
    }
}

