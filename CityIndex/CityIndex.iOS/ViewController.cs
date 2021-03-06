﻿using System;
using CityIndex.Droid.Services;
using UIKit;

namespace CityIndex.iOS
{
    public partial class ViewController : UIViewController
    {

        UserLoginService _userLoginSvc = UserLoginService.Current;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

       partial void BtnLogin_TouchUpInside(UIButton sender)
        {
            var loginSuccess = _userLoginSvc.TryLogin(txtEmail.Text, txtPassword.Text);
            if (loginSuccess)
            {
                PerformSegue("SeqSignedIn", this);
            }
            else
            {
                var alert = UIAlertController.Create("Login Failed", $"Incorrect username or password", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                PresentViewController(alert, true, null);
            }
        }
    }
}
