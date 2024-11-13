public class LoginPage
{
    private IWebDriver _driver;

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void NavigateToLoginPage()
    {
        _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    public void EnterUsername(string username)
    {
        _driver.FindElement(By.Id("user-name")).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        _driver.FindElement(By.Id("password")).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        _driver.FindElement(By.Id("login-button")).Click();
    }
}