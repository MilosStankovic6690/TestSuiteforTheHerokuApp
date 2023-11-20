using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class FileDownloadPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement FileForDownload => driver.FindElement(By.LinkText("test.jpg"));

        public string FileName = "test.jpg";
        public string DownloadPath = "/Users/Dragan_Kevkic/Downloads";

        public string FilePath(string fileName)
        {
            return Path.Combine(DownloadPath, FileName);

        }

        public void WaitElement(string fileName)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => File.Exists(FilePath(fileName)));
        }
    }
}

