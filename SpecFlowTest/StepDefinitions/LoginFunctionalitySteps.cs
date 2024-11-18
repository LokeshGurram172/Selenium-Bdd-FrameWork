using TechTalk.SpecFlow;

[Binding]
public class LoginFunctionalitySteps
{
    [Given("I am on the Swag Labs login page")]
    public void GivenIAmOnTheSwagLabsLoginPage()
    {
        // Code to navigate to login page
    }

    [When("I enter valid username '(.*)' and password '(.*)'")]
    public void WhenIEnterValidCredentials(string username, string password)
    {
        // Code to enter credentials
    }

    [When("I enter invalid username '(.*)' and password '(.*)'")]
    public void WhenIEnterInvalidCredentials(string username, string password)
    {
        // Code to enter credentials
    }

    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        // Code to click login button
    }

    [Then("I should be redirected to the products page")]
    public void ThenIShouldBeRedirectedToTheProductsPage()
    {
        // Code to verify redirection
    }

    [Then("I should see an error message '(.*)'")]
    public void ThenIShouldSeeAnErrorMessage(string message)
    {
        // Code to verify error message
    }
}