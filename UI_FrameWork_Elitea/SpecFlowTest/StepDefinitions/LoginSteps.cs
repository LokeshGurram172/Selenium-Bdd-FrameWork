using TechTalk.SpecFlow;
using OpenQA.Selenium;
using UI_FrameWork_Elitea.Framework.Core.Login.Pages;

[Binding]
public class LoginSteps
{
    private readonly IWebDriver driver;
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

    [When("I enter valid username '(.*)' and password '(.*)'")]
    public void WhenIEnterValidUsernameAndPassword(string username, string password)
    {
        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
    }

    [When("I enter invalid username '(.*)' and password '(.*)'")]
    public void WhenIEnterInvalidUsernameAndPassword(string username, string password)
    {
        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
    }

    [And("I click the login button")]
    public void AndIClickTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then("I should be redirected to the products page")]
    public void ThenIShouldBeRedirectedToTheProductsPage()
    {
        // Assert URL or page title
    }

    [Then("I should see an error message '(.*)'")]
    public void ThenIShouldSeeAnErrorMessage(string message)
    {
        Assert.IsTrue(loginPage.IsErrorMessageDisplayed());
        // Assert error message text
    }
}