using CityIndex.Droid.Services;
using Foundation;
using System;
using UIKit;

namespace CityIndex.iOS
{
    public partial class ProfileController : UIViewController
    {
        UserLoginService _userLoginSvc = UserLoginService.Current;

        public ProfileController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad()
        {
            User u = _userLoginSvc.CurrentUser;
            lblName.Text = $"{u.FirstName} {u.LastName}";
        }

        partial void btnLogoutTouchUpInsinde(UIButton sender)
        {
            var vc = Storyboard.InstantiateViewController("VCSignIn");
            this.PresentViewController(vc, false, () => { });
        }

        partial void OnBtnEditProfileTouchUpInside(UIButton sender)
        {
            PerformSegue("GoEditProfile", this);
        }
    }
}