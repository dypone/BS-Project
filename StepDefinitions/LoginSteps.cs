using System;
using TechTalk.SpecFlow;

namespace BlueskyProject01.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [When(@"I input an invalid username")]
        public void WhenIInputAnInvalidUsername()
        {
            Console.WriteLine("Input Invalid Username");
        }

        [When(@"i input an valid password")]
        public void WhenIInputAnValidPassword()
        {
            Console.WriteLine("Input a valid Password");
        }

        [Then(@"i should not be logged in")]
        public void ThenIShouldNotBeLoggedIn()
        {
            Console.WriteLine("Not Logged In");
        }

        [Then(@"i should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Console.WriteLine("I Should be Logged in");
        }

        [Given(@"I am a registered user of www\.gifrete\.com")]
        public void GivenIAmARegisteredUserOfWww_Gifrete_Com()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"i navigate to the website")]
        public void WhenINavigateToTheWebsite()
        {
            Console.WriteLine("Navigate to Website");
        }
        
        [When(@"i click on sign in")]
        public void WhenIClickOnSignIn()
        {
            Console.WriteLine("Click on Sign In");
        }
        
        [When(@"I input a valid username")]
        public void WhenIInputAValidUsername()
        {
            Console.WriteLine("Input a Valid Username");
        }
        
        [When(@"i input a valid password")]
        public void WhenIInputAValidPassword()
        {
            Console.WriteLine("Input a Valid Password");
        }
        
        [Then(@"i should be signed in")]
        public void ThenIShouldBeSignedIn()
        {
            Console.WriteLine("I Should be Logged In");
        }
    }
}
