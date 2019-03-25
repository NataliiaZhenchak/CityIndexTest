using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using CityIndex.Droid.Services;
using Android.Content;
using AlertDialog = Android.App.AlertDialog;

namespace CityIndex.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText _txtEmail;
        EditText _txtPass;
        Button _btnLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _txtEmail = FindViewById<EditText>(Resource.Id.login_input_email);
            _txtPass = FindViewById<EditText>(Resource.Id.txtPassword);
            _btnLogin = FindViewById<Button>(Resource.Id.btnLogin);

            _btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            var loginSuccess = UserLoginService.Current.TryLogin(_txtEmail.Text, _txtPass.Text);
            if (loginSuccess)
            {
                //navigate
                var intent = new Intent(this, typeof(ProfileActivity));
                //intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            }
            else
            {

                var dialogBuilder = new AlertDialog.Builder(this);
                AlertDialog alert = dialogBuilder.Create();
                alert.SetTitle("Login");
                alert.SetMessage("Incorrect credentials.");

                alert.SetButton("OK", (c, ev) => { });
                alert.Show();
            }
        }
    }
}