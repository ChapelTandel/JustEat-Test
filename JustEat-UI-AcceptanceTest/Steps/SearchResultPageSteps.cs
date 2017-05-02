using System;
using FluentAssertions;
using JustEat_UI_AcceptanceTest.Page;
using TechTalk.SpecFlow;

namespace JustEat_UI_AcceptanceTest.Steps
{
    [Binding]
    public class SearchResultPageSteps
    {
        [Then(@"I should see some restaurants in ""(.*)""")]
        public void ThenIShouldSeeSomeRestaurantsIn(string p0)
        {
            var searResultPage = new SearchResultPage(Context.Driver);
            searResultPage.ListOfRestaurantNames.Count.Should().BeGreaterThan(1);
        }
    }
}