using OpenQA.Selenium;
using TheHerokuApp.driver;
using TheHerokuApp.Pages;

namespace TheHerokuApp.Tests
{
    public class UIElementsTests
    {
        private HomePage _homePage;
        private AddRemoveElementsPage _addRemoveElementsPage;
        private BrokenImagePage _brokenImagePage;
        private CheckboxesPage _checkboxesPage;
        private ContexMenuPage _contexMenuPage;
        private DisappearingElementsPage _disappearingElementsPage;
        private DragandDropPage _dragandDropPage;
        private DropdownPage _dropdownPage;
        private DynamicContentPage _dynamicContentPage;
        private DynamicControlsPage _dynamicControlsPage;
        private DynamicLoadingPage _dynamicLoadingPage;
        private EntryAdPage _entryAdPage;
        private ExitIntentPage _exitIntentPage;
        private FileDownloadPage _fileDownloadPage;
        private FileUploadPage _fileUploadPage;
        private FloatingMenuPage _floatingMenuPage;
        private FramesPage _framesPage;
        private HoversPage _hoversPage;
        private InfiniteScrollPage _infiniteScrollPage;
        private InputsPage _inputsPage;
        private JQueryUIMenusPage _JQueryUIMenusPage;
        private JavaScriptOnloadEventErrorPage _JavaScriptOnloadEventErrorPage;
        private KeyPressesPage _keyPressesPage;
        private LargeAndDeepDOMPage _LargeAndDeepDOMPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            _homePage = new HomePage();
            _addRemoveElementsPage = new AddRemoveElementsPage();
            _brokenImagePage = new BrokenImagePage();
            _checkboxesPage = new CheckboxesPage();
            _contexMenuPage = new ContexMenuPage();
            _disappearingElementsPage = new DisappearingElementsPage();
            _dragandDropPage = new DragandDropPage();
            _dropdownPage = new DropdownPage();
            _dynamicContentPage = new DynamicContentPage();
            _dynamicControlsPage = new DynamicControlsPage();
            _dynamicLoadingPage = new DynamicLoadingPage();
            _entryAdPage = new EntryAdPage();
            _exitIntentPage = new ExitIntentPage();
            _fileDownloadPage = new FileDownloadPage();
            _fileUploadPage = new FileUploadPage();
            _floatingMenuPage = new FloatingMenuPage();
            _framesPage = new FramesPage();
            _hoversPage = new HoversPage();
            _infiniteScrollPage = new InfiniteScrollPage();
            _inputsPage = new InputsPage();
            _JQueryUIMenusPage = new JQueryUIMenusPage();
            _JavaScriptOnloadEventErrorPage = new JavaScriptOnloadEventErrorPage();
            _keyPressesPage = new KeyPressesPage();
            _LargeAndDeepDOMPage = new LargeAndDeepDOMPage();
        }

        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.Shutdown();
        }

        [Test]
        public void TC01_AddAndDeleteElement_ElementShouldBeDeleted()
        {
            _homePage.AddRemoveElements.Click();
            _addRemoveElementsPage.AddElementButton.Click();
            _addRemoveElementsPage.DeleteButton.Click();
            bool IsElementDeleted = _addRemoveElementsPage.IsDeleteButtonPresent();
            Assert.IsTrue(IsElementDeleted, "Element should be deleted");
        }

        [Test]
        public void TC02_VerifyImageValidity_ImagesShouldBeValid()
        {
            _homePage.BrokenImage.Click();
            Assert.IsTrue(_brokenImagePage.IsImageBroken(_brokenImagePage.Image1));
            Assert.IsTrue(_brokenImagePage.IsImageBroken(_brokenImagePage.Image2));
            Assert.IsTrue(_brokenImagePage.IsImageDisplayed(_brokenImagePage.Image3));
        }

        [Test]
        public void TC03_SelectCheckbox_CheckboxShouldBeSelected()
        {
            _homePage.Checkboxes.Click();
            _checkboxesPage.Checkbox1.Click();
            _checkboxesPage.Checkbox2.Click();
            Assert.That(_checkboxesPage.Checkbox1.Selected);
        }

        [Test]
        public void TC04_VerifyAlertPopupOnBoxClick_PopupShouldConfirmContextMenuSelection()
        {
            _homePage.ContexMenu.Click();
            _contexMenuPage.RightClick(_contexMenuPage.HotSpot);
            // _contexMenuPage.Alert();
            string alertText = _contexMenuPage.AlertText();
            Assert.That(_contexMenuPage.AlertText(), Is.EqualTo(_contexMenuPage.ExpectedText));
        }

        [Test]
        public void TC05_FindTheDisappearingLocators_ElementsShouldBeFound()
        {
            _homePage.DisappearingElements.Click();
            try
            {
                _disappearingElementsPage.GalleryButton.Click();
                Assert.IsTrue(true, "element found");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Element not found");
            }
        }

        [Test]
        public void TC06_MoveTheBoxToAnother_BoxShouldMove()
        {
            _homePage.DragAndDrop.Click();
            _dragandDropPage.MoveObject();
            string BoxbText = _dragandDropPage.BoxB.Text;
            Assert.That(BoxbText, Is.EqualTo("A"), "Box A should have moved to Box B");
        }

        [Test]
        public void TC07_SelectAnOptionFromTheDropdown_ItShouldBeSelected()
        {
            _homePage.DropDown.Click();
            _dropdownPage.SelectOption("2");
            string selectedOptionText = _dropdownPage.GetSelectedOption();
            Assert.That(selectedOptionText, Is.EqualTo("Option 2"), "Selected option should be 'Option 2'");

        }

        [Test]
        public void TC08_VerifyThatTheContentChangesAfterRefreshingThePage_TheContentShouldChangeUponRefreshingThePage()
        {
            _homePage.DynamicContent.Click();
            _dynamicContentPage.InitialContent();
            _dynamicContentPage.ClickHere.Click();
            _dynamicContentPage.RefreshedContent();
            Assert.AreNotEqual(_dynamicContentPage.InitialContent, _dynamicContentPage.RefreshedContent);
        }

        [Test]
        public void TC09_VerifyThatTheCheckboxAndTextBoxCanBeRemovedAndEnabled_TheCheckboxAndTextboxShouldBeRemovableAndEnableable()
        {
            _homePage.DynamicControls.Click();
            _dynamicControlsPage.CheckBox.Click();
            _dynamicControlsPage.RemoveButton.Click();
            _dynamicControlsPage.WaitForCheckBoxToDisappear();
            _dynamicControlsPage.EnableButton.Click();
            _dynamicControlsPage.WaitForMessage();
            bool isCheckboxRemoved = _dynamicControlsPage.WaitForCheckBoxToDisappear();
            string actualMessage = _dynamicControlsPage.ActualMessage();
            bool isCorrectMessageDisplayed = _dynamicControlsPage.ActualMessage().Contains(_dynamicControlsPage.EnableMessage);
            Assert.Multiple(() =>
            {
                Assert.IsTrue(isCheckboxRemoved, "Checkbox should be removed after clicking.");
                Assert.IsTrue(isCorrectMessageDisplayed, _dynamicControlsPage.EnableMessage);
            });
        }

        [Test]
        public void TC10_VerifyThatTheHiddenElementShouldBecomeVisibleAfterStartingTheAction_TheElementShouldBecomeVisible()
        {
            _homePage.DynamicLoading.Click();
            //_dynamicLoadingPage.Example_1.Click();
            _dynamicLoadingPage.Example_2.Click();
            _dynamicLoadingPage.StartButton.Click();
            _dynamicLoadingPage.WaitForMessage();
            bool elementIsDisplayed = _dynamicLoadingPage.HelloWorld.Displayed;
            Assert.IsTrue(elementIsDisplayed, "Element should be visible after loading.");
        }

        [Test]
        public void TC11_()
        {
            _homePage.EntryAd.Click();
            _entryAdPage.WaitModalWindow();
            _entryAdPage.CloseButton.Click();
            bool modalWindowIsDisplayed = _entryAdPage.ModalWindow.Displayed;
            Assert.IsFalse(modalWindowIsDisplayed, "Modal window is closed");
        }

        [Test]
        public void TC12_()
        {
            _homePage.ExitIntent.Click();
            _exitIntentPage.MoveMouse();
            _exitIntentPage.WaitModalWindow();
            bool modalWindowIsDisplayed = _entryAdPage.ModalWindow.Displayed;
            Assert.IsTrue(modalWindowIsDisplayed, "Modal window is displayed");
        }

        [Test]
        public void TC13_()
        {
            _homePage.FileDownload.Click();
            _fileDownloadPage.FileForDownload.Click();
            _fileDownloadPage.WaitElement("Test.jpg");
            Assert.IsTrue(File.Exists(_fileDownloadPage.FilePath("Test.jpg")));
        }

        [Test]
        public void TC14_()
        {
            _homePage.FileUpload.Click();
            _fileUploadPage.FileForUpload("/Users/Dragan_Kevkic/Downloads/screenshot.png");
            Assert.That(_fileUploadPage.SuccessMessageText(), Is.EqualTo(_fileUploadPage.ExpectedMessage));
        }

        [Test]
        public void TC15_()
        {
            _homePage.FloatingMenu.Click();
            _floatingMenuPage.MoveToElement();
            _floatingMenuPage.ScrollToElement();
            Assert.IsTrue(_floatingMenuPage.elementIsDisplayed());
        }

        [Test]
        public void TC16_()
        {
            _homePage.Frames.Click();
            _framesPage.NestedFrames.Click();
            Assert.IsTrue(_framesPage.IsFrameDisplayed());
        }

        [Test]
        public void TC17_()
        {
            _homePage.Frames.Click();
            _framesPage.iFrame.Click();
            _framesPage.SwitchToFrame("Milos Stankovic.");
            Assert.That(_framesPage.ActualText, Is.EqualTo(_framesPage.ExpectedText)); ;
        }

        [Test]
        public void TC18_()
        {
            _homePage.Hovers.Click();
            _hoversPage.MoveToElement();
            _hoversPage.WaitElement();
            Assert.IsNotNull(_hoversPage.ViewProfileLink);
        }

        [Test]
        public void TC19_()
        {
            _homePage.InfiniteScroll.Click();
            //_infiniteScrollPage.ScrollToBottom();
            _infiniteScrollPage.ScrollUntilContentEnds();
        }

        [Test]
        public void TC20_()
        {
            _homePage.Inputs.Click();
            // _inputsPage.ScrollingWithTheKeyboard();
            _inputsPage.InputNumbersInField("3");
            _inputsPage.ActualNumber();
            Assert.That(_inputsPage.ActualNumber, Is.EqualTo("3"));
        }

        [Test]
        public void TC21_()
        {
            _homePage.JQueryUIMenus.Click();
            _JQueryUIMenusPage.MoveToElement();
            _JQueryUIMenusPage.ActualPageTitle();
            Assert.That(_JQueryUIMenusPage.ActualPageTitle, Is.EqualTo(_JQueryUIMenusPage.ExpectedPageTitle));
        }

        [Test]
        public void TC22_()
        {
            _homePage.JavaScriptOnLoadEventError.Click();
            _JavaScriptOnloadEventErrorPage.ActualErrorMessage();
            Assert.That(_JavaScriptOnloadEventErrorPage.ActualErrorMessage, Is.EqualTo(_JavaScriptOnloadEventErrorPage.ExpectedMessage));
        }

        [Test]
        public void TC23_()
        {
            _homePage.KeyPresses.Click();
            _keyPressesPage.SendKeysToField();
            _keyPressesPage.ActualResult();
            Assert.That(_keyPressesPage.ActualResult(), Is.EqualTo(_keyPressesPage.ExpectedResult));
        }

        [Test]
        public void TC24_()
        {
            _homePage.LargeAndDeepDOM.Click();
            _LargeAndDeepDOMPage.ScrollToElement(_LargeAndDeepDOMPage.Sibling1);
            _LargeAndDeepDOMPage.ScrollToElement(_LargeAndDeepDOMPage.SiblingFromTable);
            Assert.Multiple(() =>
            {
                Assert.IsTrue(_LargeAndDeepDOMPage.isSibling1Displayed, "Sibling 1 is not displayed.");
                Assert.IsTrue(_LargeAndDeepDOMPage.isSiblingFromTableDisplayed, "Sibling from table is not displayed.");
            });

        }

        [Test]
        public void TC25_()
        {
            _homePage.KeyPresses.Click();
            _keyPressesPage.SendKeysToField();
            _keyPressesPage.ActualResult();
            Assert.That(_keyPressesPage.ActualResult(), Is.EqualTo(_keyPressesPage.ExpectedResult));
        }
    }
}

