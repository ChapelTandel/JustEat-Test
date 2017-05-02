using FluentAssertions;
using JustEat_UI_AcceptanceTest.Page;
using TechTalk.SpecFlow;

namespace JustEat_UI_AcceptanceTest.Steps
{
    [Binding]
    public class HomePageSteps
    {
        [Given(@"I want food in ""(.*)""")]
        public void GivenIWantFoodIn(string postCode)
        {
            var homepage = new HomePage(Context.Driver);
            homepage.Open().WaitForPageLoad().EnterPostCode(postCode);
        }

        [Given(@"I am on homepage")]
        public void GivenIAmOnHomepage()
        {
            var homepage = new HomePage(Context.Driver);
            homepage.Open().WaitForPageLoad();
        }

        [When(@"I search for restaurants")]
        public void WhenISearchForRestaurants()
        {
            var homepage = new HomePage(Context.Driver);
            homepage.ClickFindTakeAwaysButton();
        }

        [When(@"I search for restaurats in ""(.*)""")]
        public void WhenISearchForRestauratsIn(string postCode)
        {
            var homepage = new HomePage(Context.Driver);
            homepage.Open().WaitForPageLoad().EnterPostCode(postCode).ClickFindTakeAwaysButton();
        }

        [Given(@"I search and select a restaurant in ""(.*)""")]
        public void GivenISearchAndSelectARestaurantIn(string postCode)
        {
            var homepage = new HomePage(Context.Driver);
            homepage.Open().WaitForPageLoad().EnterPostCode(postCode).ClickFindTakeAwaysButton();

            var searchResultPage = new SearchResultPage(Context.Driver);
            searchResultPage.SelectTheFirstRestaurant();
        }

        [Then(@"I should see validation ""(.*)""")]
        public void ThenIShouldSeeValidation(string message)
        {
            var homePage = new HomePage(Context.Driver);
            homePage.PostCodeValidationMessage.Should().Be(message);
        }
    }
}