using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using static Google.Android.Material.BottomNavigation.BottomNavigationView;

namespace NavBarEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        private TextView _myText;
        private BottomNavigationView _mybtV;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            _myText = FindViewById<TextView>(Resource.Id.textView1);
            _mybtV = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView1);

            _mybtV.SetOnNavigationItemSelectedListener(this);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {

                case Resource.Id.action_home:
                    _myText.SetText(Resource.String.home);
                    break;

                case Resource.Id.action_fav:
                    _myText.SetText(Resource.String.favourite);
                    break;

                case Resource.Id.action_notification:
                    _myText.SetText(Resource.String.notification);
                    break;

            }

            return true;
        }
    }
}