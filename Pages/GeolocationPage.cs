using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class GeolocationPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement WhereAmIButton => driver.FindElement(By.CssSelector("button[onclick='getLocation()']"));
        public IWebElement Latitude => driver.FindElement(By.Id("lat-value"));
        public IWebElement Longitude => driver.FindElement(By.Id("long-value"));
        public IWebElement GoogleMapsLink => driver.FindElement(By.LinkText("See it on Google"));
        public string expectedLatitude = "44.7589419";
        public string expectedLongitude = "20.4144432";

        public string[] ActualCoordinates()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementExists(By.Id("lat-value")));
            wait.Until(ExpectedConditions.ElementExists(By.Id("long-value")));
            string latitude = Latitude.Text;
            string longitude = Longitude.Text;
            return new string[] { latitude, longitude };
        }
    }
}
