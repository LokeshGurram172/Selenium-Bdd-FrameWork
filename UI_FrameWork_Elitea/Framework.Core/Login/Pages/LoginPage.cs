using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;
    private By usernameField = By.Id("user-name");
    private By passwordField = By.Id("password");
    private By loginButton = By.Id("login-button");
    private By errorMessage = By.CssSelector("h3[data-test='error']");

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void EnterUsername(string username)
    {
        driver.FindElement(usernameField).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        driver.FindElement(passwordField).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        driver.FindElement(loginButton).Click();
    }

    public bool IsErrorMessageDisplayed()
    {
        return driver.FindElement(errorMessage).Displayed;
    }
}