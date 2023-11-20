using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class FileUploadPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ChooseFileButton => driver.FindElement(By.CssSelector("#file-upload"));
        public IWebElement UploadButton => driver.FindElement(By.CssSelector("#file-submit"));
        public IWebElement SuccessMessage => driver.FindElement(By.CssSelector(".example h3"));
        public string ExpectedMessage = "File Uploader";

        public void FileForUpload(string pathToFile)
        {
            ChooseFileButton.SendKeys(pathToFile);
        }

        public string SuccessMessageText()
        {
            return SuccessMessage.Text;
        }
    }
}

