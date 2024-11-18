using TechTalk.SpecFlow;

namespace SpecFlowTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
       
    [BeforeScenario("Login")]
        public void BeforeLoginScenario()
        {
            // Code to setup login test environment
        }

        [AfterScenario("Login")]
        public void AfterLoginScenario()
        {
            // Code to cleanup after login test
        }
    }
[BeforeScenario("Login")]
        public void BeforeLoginScenario()
        {
            // Code to setup login test environment
        }

        [AfterScenario("Login")]
        public void AfterLoginScenario()
        {
            // Code to cleanup after login test
        }
    }