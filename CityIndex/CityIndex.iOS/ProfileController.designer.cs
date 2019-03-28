// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CityIndex.iOS
{
    [Register ("ProfileController")]
    partial class ProfileController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditProfile { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLogout { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblName { get; set; }

        [Action ("btnLogoutTouchUpInsinde:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLogoutTouchUpInsinde (UIKit.UIButton sender);

        [Action ("OnBtnEditProfileTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnBtnEditProfileTouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnEditProfile != null) {
                btnEditProfile.Dispose ();
                btnEditProfile = null;
            }

            if (btnLogout != null) {
                btnLogout.Dispose ();
                btnLogout = null;
            }

            if (lblName != null) {
                lblName.Dispose ();
                lblName = null;
            }
        }
    }
}