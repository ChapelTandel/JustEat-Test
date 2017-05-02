using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace JustEat_UI_AcceptanceTest.Page
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".o-btn.o-btn--primary")]
        private IWebElement _findTakeAwayButton;

        [FindsBy(How = How.Id, Using = "postcode")]
        private IWebElement _postCodeInput;

        [FindsBy(How = How.CssSelector, Using = ".errorMessage")]
        private IWebElement _postCodeValidationLabel;

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public string PostCodeValidationMessage
        {
            get { return _postCodeValidationLabel.Text; }
        }

        public HomePage Open()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
            return this;
        }

        public HomePage WaitForPageLoad()
        {
            //WaitFor10Seconds.Until(driver => _findTakeAwayButton.Displayed);
            WaitFor(10).Until(driver => _findTakeAwayButton.Displayed);
            return this;
        }

        public void ClickFindTakeAwaysButton()
        {
            _findTakeAwayButton.Click();
        }

        public HomePage EnterPostCode(string postCode)
        {
            _postCodeInput.SendKeys(postCode);
            return this;
        }
    }
}