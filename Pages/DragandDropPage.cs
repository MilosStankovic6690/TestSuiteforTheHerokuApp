using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class DragandDropPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement BoxA => driver.FindElement(By.Id("column-a"));
        public IWebElement BoxB => driver.FindElement(By.Id("column-b"));

        public void MoveObject()
        {
            var builder = new Actions(driver);
            builder.DragAndDrop(BoxA, BoxB).Build();
            builder.Perform();
        }
    }
}

