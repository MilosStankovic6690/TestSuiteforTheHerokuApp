using TheHerokuApp.driver;
using TheHerokuApp.Pages;

namespace TheHerokuApp.Tests
{
    public class InteractiveElementTests
    {
        private HomePage _homePage;
        private ABTestControlPage _abTestControlPage;
        private ChallengingDOMPage _challengingDOMPage;
        private GeolocationPage _geolocationPage;
        private HorizontalSliderPage _horizontalSliderPage;
        private JavaScriptAlertsPage _javaScriptAlertsPage;
       
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            _homePage = new HomePage();
            _abTestControlPage = new ABTestControlPage();
            _challengingDOMPage = new ChallengingDOMPage();
            _geolocationPage = new GeolocationPage();
            _horizontalSliderPage = new HorizontalSliderPage();
            _javaScriptAlertsPage = new JavaScriptAlertsPage();
        }

        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.Shutdown();
        }

        [Test]
        public void TC01_GoToTheABTestControlPage_PageShouldDisplayed()
        {
            _homePage.ABTesting.Click();
            Assert.That(_abTestControlPage.ABTestingUrl, Is.EqualTo(WebDrivers.Instance.Url));
        }

        [Test]
        public void TC02_FindElement_LocatorShouldBeFound()
        {
            _homePage.ChallengingDOM.Click();
            _challengingDOMPage.barButton.Click();
            Assert.That(_challengingDOMPage.Definiebas8.Displayed, Is.True);
        }

        [Test]
        public void TC03_()
        {
            _homePage.Geolocation.Click();
            _geolocationPage.WhereAmIButton.Click();
            _geolocationPage.ActualCoordinates();
            string[] actualCoordinates = _geolocationPage.ActualCoordinates();
            Assert.Multiple(() =>
            {
                Assert.That(actualCoordinates[0], Is.EqualTo(_geolocationPage.expectedLatitude));
                Assert.That(actualCoordinates[1], Is.EqualTo(_geolocationPage.expectedLongitude));
            });
        }

        [Test]
        public void TC04_()
        {
            _homePage.HorizontalSlider.Click();
            //_horizontalSliderPage.MoveSlider(0, 3);
            //_horizontalSliderPage.MoveSlider(-3,0);
            _horizontalSliderPage.ScrollingWithTheKeyboard();
            _horizontalSliderPage.RangeValue();
            string rangeValue = _horizontalSliderPage.RangeValue();
            Assert.That(rangeValue, Is.EqualTo(_horizontalSliderPage.ExpectedValue));
        }

        [Test]
        public void TC05_Alert()
        {
            _homePage.JavaScriptAlerts.Click();
            _javaScriptAlertsPage.JSAlertButton.Click();
            _javaScriptAlertsPage.Alert();
            _javaScriptAlertsPage.ActualMessage();
            Assert.That(_javaScriptAlertsPage.ActualMessage(), Is.EqualTo(_javaScriptAlertsPage.ExpectedMessage1));
        }

        [Test]
        public void TC06_Alert()
        {
            _homePage.JavaScriptAlerts.Click();
            _javaScriptAlertsPage.JSConfirmButton.Click();
            _javaScriptAlertsPage.Alert();
            _javaScriptAlertsPage.ActualMessage();
            Assert.That(_javaScriptAlertsPage.ActualMessage(), Is.EqualTo(_javaScriptAlertsPage.ExpectedMessage2));
        }

        [Test]
        public void TC07_Alert()
        {
            _homePage.JavaScriptAlerts.Click();
            _javaScriptAlertsPage.JSPromptButton.Click();
            _javaScriptAlertsPage.AlertTextField("Ja sam Milos");
            _javaScriptAlertsPage.ActualMessage();
            Assert.That(_javaScriptAlertsPage.ActualMessage(), Is.EqualTo(_javaScriptAlertsPage.ExpectedMessage3));
        }
    }
}
