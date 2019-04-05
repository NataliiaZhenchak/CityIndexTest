using CityIndex.Automation.Pages.iOS;
using CityIndex.Automation.Utils;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CityIndex.Automation.Pages.Droid
{
    public class iOSProfilePage : ProfilePage
    {
   

        public iOSProfilePage(IApp app): base(app)
        {
            LoginText = c => c.Class("UILabell").Index(0);
            LogoutButton = c => c.Class("UIButtonLabel").Index(0);
        }

    }
}
