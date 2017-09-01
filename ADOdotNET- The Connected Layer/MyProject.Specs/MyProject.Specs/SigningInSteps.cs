using System;
using TechTalk.SpecFlow;

namespace MyProject.Specs
{
    [Binding]
    public class SigningInSteps
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the right credentials")]
        public void WhenIEnterTheRightCredentials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click the login button")]
        public void WhenClickTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"two accounts return")]
        public void WhenTwoAccountsReturn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be taken into my account")]
        public void ThenIShouldBeTakenIntoMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be prompted to pick an account")]
        public void ThenIShouldBePromptedToPickAnAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be taken to that account")]
        public void ThenIShouldBeTakenToThatAccount()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
