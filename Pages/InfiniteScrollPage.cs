using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class InfiniteScrollPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        private WebDriverWait wait;

        public IWebElement Content => driver.FindElement(By.CssSelector("div[class='jscroll-added']"));

        public void ScrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }

        public bool isContentDisplayed()
        {
            return Content.Displayed;
        }

        public void ScrollUntilContentEnds()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            bool isContentDisplayed = true;
            int previousHeight = 0;

            while (isContentDisplayed)
            {
                int currentHeight = Content.Size.Height;
                if (currentHeight == previousHeight)
                {
                    isContentDisplayed = false;
                }
                else
                {
                    ScrollToBottom();
                    wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
                    previousHeight = currentHeight;
                }
            }
        }
    }
}

