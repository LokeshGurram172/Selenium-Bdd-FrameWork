using TechTalk.SpecFlow;

namespace SpecFlowTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
       
    [BeforeScenario("Login")]
public void BeforeLoginScenario()
{
	// Setup logic for login scenario
	Console.WriteLine("Setting up test data for login scenario.");
}

[AfterScenario("Login")]
public void AfterLoginScenario()
{
	// Teardown logic for login scenario
	Console.WriteLine("Cleaning up test data after login scenario.");
}
}
[BeforeScenario("Login")]
public void BeforeLoginScenario()
{
	// Setup logic for login scenario
	Console.WriteLine("Setting up test data for login scenario.");
}

[AfterScenario("Login")]
public void AfterLoginScenario()
{
	// Teardown logic for login scenario
	Console.WriteLine("Cleaning up test data after login scenario.");
}
}