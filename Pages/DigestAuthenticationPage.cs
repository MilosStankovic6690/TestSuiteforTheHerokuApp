using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class DigestAuthenticationPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public void AlertPopUpLogin(string uname, string pass)
        {
            string URL = "http://" + uname + ":" + pass + "@the-internet.herokuapp.com/basic_auth";
            driver.Url = URL;
        }
        public IWebElement SuccessfulLoginContent => driver.FindElement(By.XPath("//*[@id=\"content\"]/div/p"));
        public string SuccessfulLoginText = "Congratulations! You must have the proper credentials.";
    }
}

