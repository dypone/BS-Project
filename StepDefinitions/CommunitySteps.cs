using System;
using TechTalk.SpecFlow;

namespace BlueskyProject01.StepDefinitions
{
    [Binding]
    public class CommunitySteps
    {
        [Given(@"I do not sign in")]
        public void GivenIDoNotSignIn()
        {
            Console.WriteLine("Do Not Sign In");
        }
        
        [Given(@"I Sign In")]
        public void GivenISignIn()
        {
            Console.WriteLine("Sign In With Valid details");
        }
        
        [When(@"I click on Community")]
        public void WhenIClickOnCommunity()
        {
            Console.WriteLine("Click on Community");
        }
        
        [Then(@"I should be able to see how community works")]
        public void ThenIShouldBeAbleToSeeHowCommunityWorks()
        {
            Console.WriteLine("View Page on How Community Works");
        }
        
        [Then(@"I should be able to view all communities")]
        public void ThenIShouldBeAbleToViewAllCommunities()
        {
            Console.WriteLine("View All Communities");
        }
    }
}
