namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
       
    [StepDefinition("I am on the Swag Labs login page")]
public void GivenIAmOnTheSwagLabsLoginPage()
{
	// Navigate to the login page
	Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
}

[StepDefinition("I enter valid username '(.*)' and password '(.*)'")]
public void WhenIEnterValidCredentials(string username, string password)
{
	LoginPage.EnterCredentials(username, password);
}

[StepDefinition("I click the login button")]
public void AndIClickTheLoginButton()
{
	LoginPage.ClickLoginButton();
}

[StepDefinition("I should be redirected to the products page")]
public void ThenIShouldBeRedirectedToTheProductsPage()
{
	Assert.IsTrue(Driver.Url.Contains("inventory.html"));
}

[StepDefinition("an error message should be displayed '(.*)'")]
public void ThenAnErrorMessageShouldBeDisplayed(string message)
{
	Assert.IsTrue(LoginPage.GetErrorMessage().Contains(message));
}
}
[StepDefinition("I am on the Swag Labs login page")]
public void GivenIAmOnTheSwagLabsLoginPage()
{
	// Navigate to the login page
	Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
}

[StepDefinition("I enter valid username '(.*)' and password '(.*)'")]
public void WhenIEnterValidCredentials(string username, string password)
{
	LoginPage.EnterCredentials(username, password);
}

[StepDefinition("I click the login button")]
public void AndIClickTheLoginButton()
{
	LoginPage.ClickLoginButton();
}

[StepDefinition("I should be redirected to the products page")]
public void ThenIShouldBeRedirectedToTheProductsPage()
{
	Assert.IsTrue(Driver.Url.Contains("inventory.html"));
}

[StepDefinition("an error message should be displayed '(.*)'")]
public void ThenAnErrorMessageShouldBeDisplayed(string message)
{
	Assert.IsTrue(LoginPage.GetErrorMessage().Contains(message));
}
}
