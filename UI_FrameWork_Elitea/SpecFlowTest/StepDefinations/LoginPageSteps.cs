using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class LoginPageSteps
    {
        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            // Code to navigate to Swag Labs login page
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            // Code to enter username and password
        }

        [When("I enter invalid username '(.*)' and password '(.*)'")]
        public void WhenIEnterInvalidUsernameAndPassword(string username, string password)
        {
            // Code to enter invalid username and password
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            // Code to click the login button
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Code to verify redirection to products page
        }

        [Then("I should see an error message '(.*)'")]
        public void ThenIShouldSeeAnErrorMessage(string message)
        {
            // Code to verify the error message
        }
    }
}