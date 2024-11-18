using TechTalk.SpecFlow;

namespace SpecFlowTest.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Code to setup scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Code to teardown scenario
        }
    }
}