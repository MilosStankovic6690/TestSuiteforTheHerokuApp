using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class ChallengingDOMPage
    {
        IWebDriver driver = WebDrivers.Instance;

        public IWebElement barButton => driver.FindElement(By.CssSelector("a[class='button']"));
        public IWebElement Definiebas8 => driver.FindElement(By.XPath("//*[@class='large-10 columns']/table/tbody/tr[9]/td[4]"));
        public IWebElement Phaedrum3 => driver.FindElement(By.XPath("//*[@class='large-10 columns']/table/tbody/tr[4]/td[6]"));
    }
}

