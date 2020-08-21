using System;
using TechTalk.SpecFlow;
using TestTrademe;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class TestimagekeySteps
    {
        [Given(@"I go to homepage")]
        public void GivenIGoToHomepage()
        {
            TestTrademe.Pages.PageInit.Homepage.gotomotor();

        }
        
        [Given(@"input motor in search field and click search key and go to motor page")]
        public void GivenInputMotorInSearchFieldAndClickSearchKeyAndGoToMotorPage()
        {
            TestTrademe.Pages.PageInit.Motor.map();

        }
        
        [When(@"click image key")]
        public void WhenClickImageKey()
        {
            TestTrademe.Pages.PageInit.Car.assermaplink();
       
        }
        
        [Then(@"get search results")]
        public void ThenGetSearchResults()
        {
            TestTrademe.Pages.Browser.back();
        }
    }
}
