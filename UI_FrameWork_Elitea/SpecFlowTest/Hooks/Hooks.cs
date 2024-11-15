using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AutomationFrameWorkUtilities;

namespace SpecFlowTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario("@login, @invalid_login")]
        public void BeforeScenario()
        {
            _driver = DriverUtility.InitializeDriver("chrome"); // Assuming Chrome as default for simplicity
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario("@login, @invalid_login")]
        public void AfterScenario()
        {
            if (_driver != null)
            {
                DriverUtility.CloseDriver(_driver);
            }
        }
    }
}