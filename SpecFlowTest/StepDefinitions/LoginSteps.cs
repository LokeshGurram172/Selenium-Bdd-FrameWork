using TechTalk.SpecFlow;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            // Implementation for navigating to the login page
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            // Implementation for entering credentials
        }

        [When("I enter invalid username '(.*)' and password '(.*)'")]
        public void WhenIEnterInvalidUsernameAndPassword(string username, string password)
        {
            // Implementation for entering credentials
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Implementation for verifying redirection
        }

        [Then("I should see an error message '(.*)'")]
        public void ThenIShouldSeeAnErrorMessage(string message)
        {
            // Implementation for verifying error message
        }
    }
}