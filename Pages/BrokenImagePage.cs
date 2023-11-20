using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class BrokenImagePage
    {
        IWebDriver driver = WebDrivers.Instance;

        public IWebElement Image1 => driver.FindElement(By.CssSelector("div[class='example'] img[src='asdf.jpg']"));
        public IWebElement Image2 => driver.FindElement(By.CssSelector("div[class='example'] img[src='hjkl.jpg']"));
        public IWebElement Image3 => driver.FindElement(By.CssSelector("div[class='example'] img[src='img/avatar-blank.jpg']"));

        public bool IsImageBroken(IWebElement element)
        {
            return element.GetAttribute("naturalWidth") == "0";
        }

        public bool IsImageDisplayed(IWebElement element)
        {
            return element.Displayed;
        }

        public void ImageTest()
        {
            if (Image1 == Image3)
            {
                Assert.That(Image1.Displayed);
            }
            else
            {
                Assert.That(Image1, Is.Empty);
            }
        }
    }
}
