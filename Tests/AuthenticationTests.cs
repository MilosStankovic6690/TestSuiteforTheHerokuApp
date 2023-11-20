using TheHerokuApp.driver;
using TheHerokuApp.Pages;

namespace TheHerokuApp.Tests
{
    public class AuthenticationTests
    {
        private HomePage _homePage;
        private BasicAuthPage _basicAuthPage;
        private DigestAuthenticationPage _digestAuthenticationPage;
        private ForgotPasswordPage _forgotPasswordPage;
        private FormAuthenticationPage _formAuthenticationPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            _homePage = new HomePage();
            _basicAuthPage = new BasicAuthPage();
            _digestAuthenticationPage = new DigestAuthenticationPage();
            _forgotPasswordPage = new ForgotPasswordPage();
            _formAuthenticationPage = new FormAuthenticationPage();
        }

        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.Shutdown();
        }

        [Test]
        public void TC01_FillUsernameAndPasswordWithValidData_SuccessfullyDisplaysPage()
        {
            _homePage.BasicAuth.Click();
            _basicAuthPage.AlertPopUpLogin("admin", "admin");
            Assert.That(_basicAuthPage.SuccessfulLoginText, Is.EqualTo(_basicAuthPage.SuccessfulLoginContent.Text));
        }

        [Test]
        public void TC02_FillUsernameAndPasswordWithValidData_ShouldSuccessfullyLogIn()
        {
            _homePage.BasicAuth.Click();
            _basicAuthPage.AlertPopUpLogin("admin", "admin");
            Assert.That(_digestAuthenticationPage.SuccessfulLoginText, Is.EqualTo(_digestAuthenticationPage.SuccessfulLoginContent.Text));
        }

        [Test]
        public void TC03_()
        {
            _homePage.ForgotPassword.Click();
            _forgotPasswordPage.RetrievePasswordButton.Submit();
        }

        [Test]
        public void TC04_()
        {
            _homePage.FormAuthentication.Click();
            _formAuthenticationPage.Login("tomsmith", "SuperSecretPassword!");
            _formAuthenticationPage.WaitSuccessMesage();
            Assert.That(_formAuthenticationPage.SuccessMessage(), Is.EqualTo(_formAuthenticationPage.ExpectedMessage));
        }
    }
}

