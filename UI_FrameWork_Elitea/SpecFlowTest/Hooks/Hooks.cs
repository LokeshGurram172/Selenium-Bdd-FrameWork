using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AutomationFrameworkUtilities;

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

        [BeforeScenario("@login", "@invalid_login")]
        public void BeforeScenario()
        {
            _driver = WebDriverUtility.InitializeDriver("chrome");
            _objectContainer.RegisterInstanceAs(_driver);
        }

        [AfterScenario("@login", "@invalid_login")]
        public void AfterScenario()
        {
            WebDriverUtility.TearDown(_driver);
        }
    }
}