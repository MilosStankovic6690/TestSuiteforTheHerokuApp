using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class LargeAndDeepDOMPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Sibling1 => driver.FindElement(By.Id("sibling-9.3"));
        public IWebElement SiblingFromTable => driver.FindElement(By.CssSelector(".row-9 td:nth-child(3)"));

        public void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public bool isSibling1Displayed => Sibling1.Displayed;
        public bool isSiblingFromTableDisplayed => SiblingFromTable.Displayed;
    }
}

