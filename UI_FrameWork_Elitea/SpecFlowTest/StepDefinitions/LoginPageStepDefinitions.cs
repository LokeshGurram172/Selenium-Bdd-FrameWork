namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
       
    [Given("I am on the Swag Labs login page")]
public void GivenIAmOnTheSwagLabsLoginPage()
{
	// Navigate to the login page
	LoginPage.NavigateTo();
}

[When("I enter valid username '(.*)' and password '(.*)'")]
public void WhenIEnterValidCredentials(string username, string password)
{
	LoginPage.EnterCredentials(username, password);
}

[When("I enter invalid username '(.*)' and password '(.*)'")]
public void WhenIEnterInvalidCredentials(string username, string password)
{
	LoginPage.EnterCredentials(username, password);
}

[Then("I should be redirected to the products page")]
public void ThenIShouldBeRedirectedToTheProductsPage()
{
	Assert.IsTrue(LoginPage.IsAtProductsPage());
}

[Then("an error message should be displayed '(.*)'")]
public void ThenAnErrorMessageShouldBeDisplayed(string message)
{
	Assert.IsTrue(LoginPage.IsErrorMessageDisplayed(message));
}
}
[Given("I am on the Swag Labs login page")]
public void GivenIAmOnTheSwagLabsLoginPage()
{
	// Navigate to the login page
	LoginPage.NavigateTo();
}

[When("I enter valid username '(.*)' and password '(.*)'")]
public void WhenIEnterValidCredentials(string username, string password)
{
	LoginPage.EnterCredentials(username, password);
}

[When("I enter invalid username '(.*)' and password '(.*)'")]
public void WhenIEnterInvalidCredentials(string username, string password)
{
	LoginPage.EnterCredentials(username, password);
}

[Then("I should be redirected to the products page")]
public void ThenIShouldBeRedirectedToTheProductsPage()
{
	Assert.IsTrue(LoginPage.IsAtProductsPage());
}

[Then("an error message should be displayed '(.*)'")]
public void ThenAnErrorMessageShouldBeDisplayed(string message)
{
	Assert.IsTrue(LoginPage.IsErrorMessageDisplayed(message));
}
}
