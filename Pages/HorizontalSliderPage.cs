using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class HorizontalSliderPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Slider => driver.FindElement(By.CssSelector("input[type='range']"));
        public IWebElement Range => driver.FindElement(By.CssSelector("span#range"));

        public void MoveSlider(int x, int y)
        {
            Actions move = new Actions(driver);
            move.DragAndDropToOffset(Slider, x, y).Perform();
        }

        public string ExpectedValue = "3";

        public string RangeValue()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span#range")));
            string value = Range.Text;

            while (value != "3")
            {
                MoveSlider(1, 0);
                value = Range.Text;
            }
            return value;
        }

        public void ScrollingWithTheKeyboard()
        {
            Slider.Click();
            Actions action = new Actions(driver);
            action.SendKeys(Keys.ArrowLeft).Build().Perform();
            action.SendKeys(Keys.ArrowLeft).Build().Perform();
            action.SendKeys(Keys.ArrowLeft).Build().Perform();
        }
    }
}

