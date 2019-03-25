using CityIndex.Automation.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CityIndex.Automation.Pages.Droid
{
    public class DroidLoginPage : LoginPage
    {

        public DroidLoginPage(IApp app): base(app)
        {
            PageHeader = c => c.Id("action_bar").Child("AppCompatTextView");
            EmailField = c => c.Id("login_input_email");
            PasswordField = c => c.Id("txtPassword");
            LoginButton = c => c.Id("btnLogin");
            LoginPopUp = c => c.Id("alertTitle");
        }

        //public override void ClickLogin()
        //{
        //    //todo: click logout


        //    ScenarioContext.Current.SetCurrentPage(new DroidProfilePage(App));
        //}
    }
}
