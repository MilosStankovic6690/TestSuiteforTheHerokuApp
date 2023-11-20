using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TheHerokuApp.driver
{
    public class WebDrivers
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Instance.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        }

        public static void Shutdown()
        {
            Instance.Quit();
        }
    }
}

