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
            homepage.ClickFindRestaurantsButton();
        }

        [When(@"I search for restaurats in ""(.*)""")]
        public void WhenISearchForRestauratsIn(string postCode)
        {
            var homepage = new HomePage(Context.Driver);
            homepage.Open().WaitForPageLoad().EnterPostCode(postCode).ClickFindRestaurantsButton();
        }

        [Then(@"I should see validation ""(.*)""")]
        public void ThenIShouldSeeValidation(string message)
        {
            var homePage = new HomePage(Context.Driver);

            homePage.WaitForValidationMessageToAppear();

            homePage.PostCodeValidationMessage.Should().Be(message);
        }
    }
}