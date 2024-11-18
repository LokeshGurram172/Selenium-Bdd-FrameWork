using TechTalk.SpecFlow;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            // Code to navigate to login page
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            // Code to enter username and password
        }

        [When("I enter invalid username '(.*)' and password '(.*)'")]
        public void WhenIEnterInvalidUsernameAndPassword(string username, string password)
        {
            // Code to enter invalid credentials
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            // Code to click login button
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Code to verify redirection to products page
        }

        [Then("I should see an error message '(.*)'")]
        public void ThenIShouldSeeAnErrorMessage(string message)
        {
            // Code to verify error message
        }
    }
}