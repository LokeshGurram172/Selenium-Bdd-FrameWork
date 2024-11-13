[Binding]
public class LoginSteps
{
    private readonly LoginPage _loginPage;
    private readonly ProductsPage _productsPage;

    public LoginSteps(LoginPage loginPage, ProductsPage productsPage)
    {
        _loginPage = loginPage;
        _productsPage = productsPage;
    }

    [Given(@"I am on the Swag Labs login page")]
    public void GivenIAmOnTheSwagLabsLoginPage()
    {
        _loginPage.NavigateToLoginPage();
    }

    [When(@"I enter valid username \"(.*)\" and password \"(.*)\"")]
    public void WhenIEnterValidUsernameAndPassword(string username, string password)
    {
        _loginPage.EnterUsername(username);
        _loginPage.EnterPassword(password);
    }

    [When(@"I click on the login button")]
    public void WhenIClickOnTheLoginButton()
    {
        _loginPage.ClickLoginButton();
    }

    [Then(@"I should be redirected to the products page")]
    public void ThenIShouldBeRedirectedToTheProductsPage()
    {
        _productsPage.VerifyOnProductsPage();
    }
}