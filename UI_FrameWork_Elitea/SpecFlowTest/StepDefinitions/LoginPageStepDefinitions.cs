using Framework.Core.LoginPage;
using OpenQA.Selenium;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private LoginPage _loginPage;
        private IWebDriver _driver;

        public LoginPageStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("I enter valid credentials and submit")]
        public void WhenIEnterValidCredentialsAndSubmit()
        {
            _loginPage.EnterUsername("standard_user");
            _loginPage.EnterPassword("secret_sauce");
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Assert that the URL is the expected one
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", _driver.Url);
        }
    }
}
