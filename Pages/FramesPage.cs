using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class FramesPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement NestedFrames => driver.FindElement(By.LinkText("Nested Frames"));
        public IWebElement iFrame => driver.FindElement(By.LinkText("iFrame"));
        public IWebElement LeftFrame => driver.FindElement(By.CssSelector("frame[name='frame-left']"));
        public IWebElement MiddleFrame => driver.FindElement(By.CssSelector("frame[name='frame-middle']"));
        public IWebElement RightFrame => driver.FindElement(By.CssSelector("frame[name='frame-right']"));
        public IWebElement BottomFrame => driver.FindElement(By.CssSelector("frame[name='frame-bottom']"));
        public IWebElement TextArea => driver.FindElement(By.Id("tinymce"));
        public IWebElement BoldButton => driver.FindElement(By.CssSelector("button[aria-label='Bold'] span"));
        public IWebElement IFrame => driver.FindElement(By.Id("mce_0_ifr"));
        public string ExpectedText = "Milos Stankovic.";

        public string ActualText()
        {
            return TextArea.Text;
        }

        public bool IsFrameDisplayed()
        {
            driver.SwitchTo().ParentFrame();
            return true;
        }

        public bool FrameIsDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.Id("frame[name='frame-bottom']")));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public void SwitchToFrame(string text)
        {
            driver.SwitchTo().Frame(IFrame);
            TextArea.Clear();
            TextArea.SendKeys(text);
        }
    }
}

