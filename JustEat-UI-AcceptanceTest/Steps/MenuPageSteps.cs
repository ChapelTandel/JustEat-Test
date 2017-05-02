using System.Linq;
using JustEat_UI_AcceptanceTest.Page;
using TechTalk.SpecFlow;

namespace JustEat_UI_AcceptanceTest.Steps
{
    [Binding]
    public class MenuPageSteps
    {
        [When(@"I add an item to the basket")]
        public void WhenIAddAnItemToTheBasket()
        {
            var menuPage = new MenuPage(Context.Driver);
            menuPage.AddAnItemToTheBasket();
        }

        [Then(@"I should see the item in the basket")]
        public void ThenIShouldSeeTheItemInTheBasket()
        {
            var currentProduct = ScenarioContext.Current.Get<string>("product");

            var menuPage = new MenuPage(Context.Driver);

            menuPage.ListOfProductsInBasket.Any().Equals(currentProduct);
        }
    }
}