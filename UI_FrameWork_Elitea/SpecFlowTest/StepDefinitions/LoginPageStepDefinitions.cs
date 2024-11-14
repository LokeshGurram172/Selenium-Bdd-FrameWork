using Framework.Core;
using OpenQA.Selenium;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private readonly LoginPage loginPage;

        public LoginPageStepDefinitions(IWebDriver driver)
        {
            loginPage = new LoginPage(driver);
        }

        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            loginPage.NavigateToLoginPage();
        }

        [When("I enter valid credentials and submit")]
        public void WhenIEnterValidCredentialsAndSubmit()
        {
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
            loginPage.ClickLoginButton();
        }

        [When("I enter invalid credentials and submit")]
        public void WhenIEnterInvalidCredentialsAndSubmit()
        {
            loginPage.EnterUsername("invalid_user");
            loginPage.EnterPassword("wrong_password");
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Assert that the user is on the products page
        }

        [Then("I should remain on the login page and see an error message")]
        public void ThenIShouldRemainOnTheLoginPageAndSeeAnErrorMessage()
        {
            // Assert that the error message is displayed
        }
    }
}
