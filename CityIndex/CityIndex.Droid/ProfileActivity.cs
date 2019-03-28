using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using CityIndex.Droid.Services;

namespace CityIndex.Droid
{
    [Activity(Label = "@string/profile")]
    public class ProfileActivity : Activity
    {
        TextView _txtvName;
        Button  _btnLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_profile);

            _txtvName = FindViewById<TextView>(Resource.Id.txtvName);
            _btnLogin = FindViewById<Button>(Resource.Id.btnLogout);

            User u = UserLoginService.Current.CurrentUser;
            _txtvName.Text = $"{u.FirstName} {u.LastName}";

            _btnLogin.Click += _btnLogin_Click;
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            //intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
            StartActivity(intent);
        }
    }
}