using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CityIndex.Automation.Pages.iOS
{
    public class iOSLoginPage : LoginPage
    {
       
        public iOSLoginPage(IApp app): base(app)
        {
            PageHeader = c => c.Class("UILabel").Index(0);
            EmailField = c => c.Class("UITextField").Index(1);
            PasswordField = c => c.Class("UITextField").Index(0);
            LoginButton = c => c.Class("UIButtonLabel");
            LoginPopUp = c => c.Class("UILabel").Marked("Login Failed");
            OKButton = c => c.Class("UILabel").Index(2);

        }


    }
}
