using NUnit.Framework;
using OpenQA.Selenium;
using UI_FrameWork_Elitea.Framework.Core.pageobjects;

namespace UI_FrameWork_Elitea.SpecFlowTest.stepdefinations
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        public LoginSteps(IWebDriver webDriver)
        {
            driver = webDriver;
            loginPage = new LoginPage(driver);
        }

        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterCredentials(string username, string password)
        {
            loginPage.EnterCredentials(username, password);
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            Assert.IsTrue(driver.Url.Contains("/inventory.html"));
        }

        [Then("I should see an error message '(.*)'")]
        public void ThenIShouldSeeAnErrorMessage(string message)
        {
            Assert.AreEqual(message, loginPage.GetErrorMessage());
        }
    }
}