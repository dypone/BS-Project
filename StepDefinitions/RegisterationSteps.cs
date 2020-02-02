using System;
using TechTalk.SpecFlow;

namespace BlueskyProject01.StepDefinitions
{
    [Binding]
    public class RegisterationSteps
    {
        [When(@"I enter a wrong password for the confirm password")]
        public void WhenIEnterAWrongPasswordForTheConfirmPassword()
        {
            Console.WriteLine("Enter Wrong Confirm PassWord");
        }

        [Then(@"I should not be a registered member")]
        public void ThenIShouldNotBeARegisteredMember()
        {
            Console.WriteLine("Should Not be Registered");
        }

        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            Console.WriteLine("Navigate to Website");
        }
        
        [Given(@"i click on Register button")]
        public void GivenIClickOnRegisterButton()
        {
            Console.WriteLine("Click Register");
        }
        
        [When(@"I enter the First name")]
        public void WhenIEnterTheFirstName()
        {
            Console.WriteLine("Enter First Name");
        }
        
        [When(@"I enter the Last name")]
        public void WhenIEnterTheLastName()
        {
            Console.WriteLine("Enter Last Name");
        }
        
        [When(@"I enter an acceptable password")]
        public void WhenIEnterAnAcceptablePassword()
        {
            Console.WriteLine("Password");
        }
        
        [When(@"I enter the confirm password")]
        public void WhenIEnterTheConfirmPassword()
        {
            Console.WriteLine("Confirm Password");
        }
        
        [When(@"I click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            Console.WriteLine("Click on Sign Up"); ;
        }
        
        [Then(@"I should be a registered member")]
        public void ThenIShouldBeARegisteredMember()
        {
            
        }
    }
}
