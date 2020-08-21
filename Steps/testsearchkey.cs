using System;
using TechTalk.SpecFlow;
using TestTrademe;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class TestsearchkeySteps
    {
        [Given(@"I goto homepage")]
        public void GivenIGotoHomepage()
        {
            TestTrademe.Pages.PageInit.Homepage.gotomotor();
 
        }
        
        [Given(@"input motor in search field")]
        [Obsolete]
        public void GivenInputMotorInSearchField()
        {
            TestTrademe.Pages.PageInit.Motor.search();          
        }
        
        [When(@"click search key")]
        public void WhenClickSearchKey()
        {
           
        }
        
        [Then(@"get search  results")]
        public void ThenGetSearchResults()
        {
            TestTrademe.Pages.Browser.close();
        }
    }
}
