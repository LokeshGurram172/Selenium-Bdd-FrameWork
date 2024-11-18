using TechTalk.SpecFlow;

namespace SpecFlowTest.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Setup logic before each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Teardown logic after each scenario
        }
    }
}