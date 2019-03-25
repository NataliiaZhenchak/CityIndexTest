using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CityIndex.Automation.Pages.iOS
{
    public class IOSLoginPage : LoginPage
    {
       
        public IOSLoginPage(IApp app): base(app)
        {
            PageHeader = c => c.Class("UILabel").Index(0);
            EmailField = c => c.Class("UITextField").Index(0);
            PasswordField = c => c.Class("UITextField").Index(1);
            LoginButton = c => c.Class("UIButtonLabel");
            LoginPopUp = c => c.Class("UIView").Descendant("UILabel").Index(0);

        }


    }
}
