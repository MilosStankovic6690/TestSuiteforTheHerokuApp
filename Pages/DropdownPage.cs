using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TheHerokuApp.driver;

namespace TheHerokuApp.Pages
{
    public class DropdownPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement DropdownList => driver.FindElement(By.CssSelector(".example #dropdown"));

        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(DropdownList);
            element.SelectByValue(text);
        }

        public string GetSelectedOption()
        {
            SelectElement element = new SelectElement(DropdownList);
            return element.SelectedOption.Text;
        }
    }
}

