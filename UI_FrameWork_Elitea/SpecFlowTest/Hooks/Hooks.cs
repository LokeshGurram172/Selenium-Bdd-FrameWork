using TechTalk.SpecFlow;

namespace SpecFlowTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
       
    [BeforeScenario("Login")]
public void BeforeLoginScenario()
{
	// Setup code specific to login scenarios
	WebDriver.Initialize();
	WebDriver.NavigateTo("https://www.saucedemo.com/");
}

[AfterScenario("Login")]
public void AfterLoginScenario()
{
	// Teardown code specific to login scenarios
	WebDriver.Quit();
}
}
[BeforeScenario("Login")]
public void BeforeLoginScenario()
{
	// Setup code specific to login scenarios
	WebDriver.Initialize();
	WebDriver.NavigateTo("https://www.saucedemo.com/");
}

[AfterScenario("Login")]
public void AfterLoginScenario()
{
	// Teardown code specific to login scenarios
	WebDriver.Quit();
}
}