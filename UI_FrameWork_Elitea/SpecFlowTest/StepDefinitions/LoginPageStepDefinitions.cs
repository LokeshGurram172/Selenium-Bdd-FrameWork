namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
       
    [Given("I am on the Swag Labs login page")]
public void GivenIAmOnTheSwagLabsLoginPage()
{
	// Navigate to the login page
	LoginPage.GoTo();
}

[When("I enter valid credentials")]
public void WhenIEnterValidCredentials()
{
	LoginPage.EnterCredentials("standard_user", "secret_sauce");
}

[When("I enter invalid credentials")]
public void WhenIEnterInvalidCredentials()
{
	LoginPage.EnterCredentials("invalid_user", "invalid_password");
}

[Then("I should be redirected to the products page")]
public void ThenIShouldBeRedirectedToTheProductsPage()
{
	Assert.IsTrue(ProductsPage.IsVisible());
}

[Then("I should see an error message 'Username and password do not match any user in this service'")]
public void ThenIShouldSeeAnErrorMessage()
{
	Assert.IsTrue(LoginPage.IsErrorMessageVisible("Username and password do not match any user in this service"));
}
}
[Given("I am on the Swag Labs login page")]
public void GivenIAmOnTheSwagLabsLoginPage()
{
	// Navigate to the login page
	LoginPage.GoTo();
}

[When("I enter valid credentials")]
public void WhenIEnterValidCredentials()
{
	LoginPage.EnterCredentials("standard_user", "secret_sauce");
}

[When("I enter invalid credentials")]
public void WhenIEnterInvalidCredentials()
{
	LoginPage.EnterCredentials("invalid_user", "invalid_password");
}

[Then("I should be redirected to the products page")]
public void ThenIShouldBeRedirectedToTheProductsPage()
{
	Assert.IsTrue(ProductsPage.IsVisible());
}

[Then("I should see an error message 'Username and password do not match any user in this service'")]
public void ThenIShouldSeeAnErrorMessage()
{
	Assert.IsTrue(LoginPage.IsErrorMessageVisible("Username and password do not match any user in this service"));
}
}
