using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace JustEat_UI_AcceptanceTest.Page
{
    public class MenuPage : BasePage
    {
        private readonly By _addButton = By.CssSelector(".addButton");

        [FindsBy(How = How.CssSelector, Using = ".basketItemDescription")] 
        private readonly IList<IWebElement> _listOfProductsInBasketLabel = new List<IWebElement>();

        private readonly By _productName = By.CssSelector("h4.name");

        [FindsBy(How = How.CssSelector, Using = ".product")] 
        private readonly IList<IWebElement> ProductList = new List<IWebElement>();

        [FindsBy(How = How.XPath, Using = ".//label[contains(text(),'Item successfully added')]")] 
        private IWebElement _addNotification;

        public MenuPage(IWebDriver driver) : base(driver)
        {
        }

        public List<string> ListOfProductsInBasket
        {
            get
            {
                return
                    _listOfProductsInBasketLabel.Select(
                        listOfProductsInBasketLabel => listOfProductsInBasketLabel.Text).ToList();
            }
        }

        public MenuPage AddAnItemToTheBasket()
        {
            Driver.Manage().Cookies.AddCookie(new Cookie("je-location", "AR51 1AA"));
            ScenarioContext.Current.Add("product", ProductList.First().FindElement(_productName).Text);

            ProductList.First().FindElement(_addButton).Click();
            return this;
        }

        public MenuPage Open(string restaurant)
        {
            Driver.Navigate().GoToUrl(restaurant);
            return this;
        }
    }
}