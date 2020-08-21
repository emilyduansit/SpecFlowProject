using System;
using TechTalk.SpecFlow;
using TestTrademe;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class TestluckykeySteps
    {
        [Given(@"I  goto homepage")]
        public void GivenIGotoHomepage()
        {
            TestTrademe.Pages.PageInit.Homepage.gotolucky();
           
        }
        
        [Given(@"input  motor in search field")]
        [Obsolete]
        public void GivenInputMotorInSearchField()
        {
            TestTrademe.Pages.PageInit.Motor.lucky();
         
        }
        
        [When(@"click lucky key")]
        public void WhenClickLuckyKey()
        {
            
        }
        
        [Then(@"get lucky  results")]
        public void ThenGetLuckyResults()
        {
            TestTrademe.Pages.Browser.back();
        }
    }
}
