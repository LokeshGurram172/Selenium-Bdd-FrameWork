namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private readonly LoginPage loginPage;

        public LoginPageStepDefinitions(LoginPage loginPage)
        {
            this.loginPage = loginPage;
        }

        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            loginPage.NavigateToLoginPage();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Assert that the user is on the products page
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            loginPage.EnterUsername("invalid_user");
            loginPage.EnterPassword("wrong_password");
            loginPage.ClickLoginButton();
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Assert that an error message is displayed
        }
    }
}
