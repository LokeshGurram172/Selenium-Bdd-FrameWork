using TechTalk.SpecFlow;

namespace SpecFlowTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
       
    [BeforeScenario("Login")]
public void BeforeLoginScenario()
{
	// Initialize browser and navigate to the login page
	Browser.Initialize();
	LoginPage.GoTo();
}

[AfterScenario("Login")]
public void AfterLoginScenario()
{
	// Cleanup browser and session
	Browser.Cleanup();
}
}
[BeforeScenario("Login")]
public void BeforeLoginScenario()
{
	// Initialize browser and navigate to the login page
	Browser.Initialize();
	LoginPage.GoTo();
}

[AfterScenario("Login")]
public void AfterLoginScenario()
{
	// Cleanup browser and session
	Browser.Cleanup();
}
}