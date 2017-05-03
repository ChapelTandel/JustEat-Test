using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace JustEat_UI_AcceptanceTest.Page
{
    public class SearchResultPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".o-tile__details>h2")]
        private IList<IWebElement> _listOfRestaurantNameLabels;

        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        public List<string> ListOfRestaurantNames
        {
            get { return _listOfRestaurantNameLabels.Select(restaurantNameLabel => restaurantNameLabel.Text).ToList(); }
        }
    }
}