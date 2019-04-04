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

#if DEBUG_ANDROID
        Platform _platform = Platform.Android;
#else   
        Platform _platform = Platform.iOS;
#endif

        [BeforeScenario]
        void ScenarioSetup()
        {
            IApp app = AppInitializer.StartApp(_platform);
            ScenarioContext.Current.Set(app);
            
            if(_platform == Platform.Android)
            {
                ScenarioContext.Current.RegisterPage<LoginPage, DroidLoginPage>(new DroidLoginPage(app));
                ScenarioContext.Current.RegisterPage<ProfilePage, DroidProfilePage>(new DroidProfilePage(app));
            }
            else if(_platform == Platform.iOS)
            {
                ScenarioContext.Current.RegisterPage<LoginPage, iOSLoginPage>(new iOSLoginPage(app));
                ScenarioContext.Current.RegisterPage<ProfilePage, iOSProfilePage>(new iOSProfilePage(app));
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
            var app = ScenarioContext.Current.Get<IApp>();
            //nothing to clean up
        }
    }
}
