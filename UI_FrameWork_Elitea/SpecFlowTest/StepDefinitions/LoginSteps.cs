using TechTalk.SpecFlow;
using Framework.Core.LoginPage;
using OpenQA.Selenium;

[Binding]
public class LoginSteps
{
    private IWebDriver driver;
    private LoginPage loginPage;

    public LoginSteps(IWebDriver driver)
    {
        this.driver = driver;
        loginPage = new LoginPage(driver);
    }

    [Given("I am on the Swag Labs login page")]
    public void GivenIAmOnTheSwagLabsLoginPage()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        loginPage.EnterUsername("standard_user");
        loginPage.EnterPassword("secret_sauce");
    }

    [And("I click on the login button")]
    public void AndIClickOnTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then("I should be redirected to the products page indicating a successful login")]
    public void ThenIShouldBeRedirectedToTheProductsPage()
    {
        // Assert that the URL is the expected one
    }
}