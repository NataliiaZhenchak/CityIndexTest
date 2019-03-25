using System;
using CityIndex.Automation.Pages;
using CityIndex.Automation.Pages.Droid;
using CityIndex.Automation.Pages.iOS;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace CityIndex.Automation
{
    [Binding]
    public class TestSetupSteps
    {
        Platform _platform = Platform.Android;

        [BeforeScenario]
        void ScenarioSetup()
        {
            IApp app = AppInitializer.StartApp(_platform);
            ScenarioContext.Current.Set(app);

            if(_platform == Platform.Android)
            {
                ScenarioContext.Current.SetCurrentPage(new DroidLoginPage(app));
            }
            else if(_platform == Platform.iOS)
            {
                ScenarioContext.Current.SetCurrentPage(new IOSLoginPage(app));
            }
        }

        [StepDefinition(@"I Launch Repl")]
        public void LaunchRepl()
        {
            var app = ScenarioContext.Current.Get<IApp>();
            app.Repl();
        }

        [AfterScenario]
        void ScenarioCleanup()
        {
            //nothing to clean up
        }
    }
}
