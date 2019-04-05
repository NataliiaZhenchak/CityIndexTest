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
    
        Platform _platform;

        [BeforeScenario]
        void ScenarioSetup()
        {
            InitPlatform();

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

        void InitPlatform()
        {
            var platformEnv = Environment.GetEnvironmentVariable("XTC_PLATFORM");
            Console.WriteLine($"XTC_PLATFORM={platformEnv}");
            switch (platformEnv)
            {
                case "android":
                    _platform = Platform.Android;
                    break;
                case "ios":
                    _platform = Platform.iOS;
                    break;
                default:
                    throw new NotSupportedException($"Platform {platformEnv} is not supported.");
            }
        }
    }
}
