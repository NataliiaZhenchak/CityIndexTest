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
   

        public DroidProfilePage(IApp app): base(app)
        {
            LoginText = c => c.Id("textView1");
            LogoutButton = c => c.Id("textView1");
        }

    }
}
