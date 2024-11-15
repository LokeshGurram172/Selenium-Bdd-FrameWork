using TechTalk.SpecFlow;
using FrameWork.Core.LoginPage;
using AutomationFrameWorkUtilities;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class LoginPageStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private LoginPage loginPage;
        private IWebDriver driver;

        public LoginPageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            driver = DriverUtility.InitializeDriver("chrome"); // Assuming Chrome as default for simplicity
            loginPage = new LoginPage(driver);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver.Navigate().GoToUrl("http://example.com/login"); // Assuming a placeholder URL
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            loginPage.EnterCredentials("validUser", "validPass"); // Assuming placeholder credentials
        }

        [When(@"I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            loginPage.EnterCredentials("invalidUser", "invalidPass"); // Assuming placeholder credentials
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should be redirected to the dashboard")]
        public void ThenIShouldBeRedirectedToTheDashboard()
        {
            // Implementation for checking redirection can be added here
        }

        [Then(@"I should see an error message indicating invalid credentials")]
        public void ThenIShouldSeeAnErrorMessageIndicatingInvalidCredentials()
        {
            var errorMessage = loginPage.GetErrorMessage();
            Assert.AreEqual("Invalid credentials", errorMessage); // Assuming placeholder error message
        }
    }
}
