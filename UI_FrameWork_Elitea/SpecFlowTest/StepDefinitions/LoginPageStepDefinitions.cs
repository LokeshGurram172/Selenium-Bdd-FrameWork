using TechTalk.SpecFlow;
using Framework.Core.Pages;
using OpenQA.Selenium;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private readonly LoginPage _loginPage;

        public LoginPageStepDefinitions(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
        }

        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            _loginPage.NavigateTo("https://www.saucedemo.com/");
        }

        [When("I enter valid username and password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            _loginPage.EnterUsername("standard_user");
            _loginPage.EnterPassword("secret_sauce");
        }

        [When("I enter invalid username and password")]
        public void WhenIEnterInvalidUsernameAndPassword()
        {
            _loginPage.EnterUsername("invalid_user");
            _loginPage.EnterPassword("invalid_password");
        }

        [And("I click the login button")]
        public void AndIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Assert that the URL is the products page
        }

        [Then("I should see an error message indicating invalid credentials")]
        public void ThenIShouldSeeAnErrorMessageIndicatingInvalidCredentials()
        {
            // Assert that the error message is displayed
        }
    }
}
