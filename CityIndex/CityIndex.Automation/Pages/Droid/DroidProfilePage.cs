using CityIndex.Automation.Utils;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CityIndex.Automation.Pages.Droid
{
    public class DroidProfilePage : ProfilePage
    {
        Func<AppQuery, AppQuery> field = c=>c.Id("login_input_email");

        public DroidProfilePage(IApp app): base(app)
        {

        }

        public override void Logout()
        {
            //IApp app = ScenarioContext.Current.Get<IApp>();
            //app.EnterText(field, userName);

            //var first = ListUtils.First(new List<string>() { "aa" });


        }
    }
}
