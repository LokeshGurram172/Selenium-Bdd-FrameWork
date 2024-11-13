namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly LoginPage.Pages _loginPage;

        public LoginPageStepDefinitions(ScenarioContext scenarioContext, LoginPage.Pages loginPage)
        {
            _scenarioContext = scenarioContext;
            _loginPage = loginPage;
        }

        [Given("the user is on the SauceDemo login page")]
        public void GivenTheUserIsOnTheSauceDemoLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("the user enters valid credentials and clicks login")]
        public void WhenTheUserEntersValidCredentialsAndClicksLogin()
        {
            _loginPage.Login("standard_user", "secret_sauce");
        }

        [Then("the user should be directed to the products page")]
        public void ThenTheUserShouldBeDirectedToTheProductsPage()
        {
            _loginPage.VerifySuccessfulLogin();
        }

        [When("the user enters invalid credentials and clicks login")]
        public void WhenTheUserEntersInvalidCredentialsAndClicksLogin()
        {
            _loginPage.Login("invalid_user", "wrong_sauce");
        }

        [Then("the user should see an error message")]
        public void ThenTheUserShouldSeeAnErrorMessage()
        {
            _loginPage.VerifyLoginFailure();
        }
    }
}
