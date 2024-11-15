namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private readonly LoginPage _loginPage;

        public LoginPageStepDefinitions(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            // Navigation logic here
        }

        [When("I enter valid credentials")]
        [When("I enter invalid credentials")]
        public void WhenIEnterCredentials(Table table)
        {
            var username = table.Rows[0]["username"];
            var password = table.Rows[0]["password"];
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Assertion logic here
        }

        [Then("an error message should be displayed")]
        public void ThenAnErrorMessageShouldBeDisplayed()
        {
            // Assertion logic here
        }
    }
}
