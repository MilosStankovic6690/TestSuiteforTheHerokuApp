using OpenQA.Selenium;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ABTesting => driver.FindElement(By.LinkText("A/B Testing"));
        public IWebElement AddRemoveElements => driver.FindElement(By.LinkText("Add/Remove Elements"));
        public IWebElement BasicAuth => driver.FindElement(By.LinkText("Basic Auth"));
        public IWebElement BrokenImage => driver.FindElement(By.LinkText("Broken Images"));
        public IWebElement ChallengingDOM => driver.FindElement(By.LinkText("Challenging DOM"));
        public IWebElement Checkboxes => driver.FindElement(By.LinkText("Checkboxes"));
        public IWebElement ContexMenu => driver.FindElement(By.LinkText("Context Menu"));
        public IWebElement DigestAuthentication => driver.FindElement(By.LinkText("Digest Authentication"));
        public IWebElement DisappearingElements => driver.FindElement(By.LinkText("Disappearing Elements"));
        public IWebElement DragAndDrop => driver.FindElement(By.LinkText("Drag and Drop"));
        public IWebElement DropDown => driver.FindElement(By.LinkText("Dropdown"));
        public IWebElement DynamicContent => driver.FindElement(By.LinkText("Dynamic Content"));
        public IWebElement DynamicControls => driver.FindElement(By.LinkText("Dynamic Controls"));
        public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        public IWebElement EntryAd => driver.FindElement(By.LinkText("Entry Ad"));
        public IWebElement ExitIntent => driver.FindElement(By.LinkText("Exit Intent"));
        public IWebElement FileDownload => driver.FindElement(By.LinkText("File Download"));
        public IWebElement FileUpload => driver.FindElement(By.LinkText("File Upload"));
        public IWebElement FloatingMenu => driver.FindElement(By.LinkText("Floating Menu"));
        public IWebElement ForgotPassword => driver.FindElement(By.LinkText("Forgot Password"));
        public IWebElement FormAuthentication => driver.FindElement(By.LinkText("Form Authentication"));
        public IWebElement Frames => driver.FindElement(By.LinkText("Frames"));
        public IWebElement Geolocation => driver.FindElement(By.LinkText("Geolocation"));
        public IWebElement HorizontalSlider => driver.FindElement(By.LinkText("Horizontal Slider"));
        public IWebElement Hovers => driver.FindElement(By.LinkText("Hovers"));
        public IWebElement InfiniteScroll => driver.FindElement(By.LinkText("Infinite Scroll"));
        public IWebElement Inputs => driver.FindElement(By.LinkText("Inputs"));
        public IWebElement JQueryUIMenus => driver.FindElement(By.LinkText("JQuery UI Menus"));
        public IWebElement JavaScriptAlerts => driver.FindElement(By.LinkText("JavaScript Alerts"));
        public IWebElement JavaScriptOnLoadEventError => driver.FindElement(By.LinkText("JavaScript onload event error"));
        public IWebElement KeyPresses => driver.FindElement(By.LinkText("Key Presses"));
        public IWebElement LargeAndDeepDOM => driver.FindElement(By.LinkText("Large & Deep DOM"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
        //public IWebElement DynamicLoading => driver.FindElement(By.LinkText("Dynamic Loading"));
    }
}

