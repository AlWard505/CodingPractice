using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;

namespace _15_Xamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public float clicks = 0;
        public float clickpower = 1;
        public float upgradecost = 10;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;


            SetContentView(Resource.Layout.content_main);
            Android.Widget.Button button = FindViewById<Android.Widget.Button>(Resource.Id.MyButton);
            Android.Widget.TextView textview = FindViewById<Android.Widget.TextView>(Resource.Id.TimesClicked);
            Android.Widget.Button Upgradebutton = FindViewById<Android.Widget.Button>(Resource.Id.MyButton2);
            button.Click += delegate {
                clicks += clickpower;
                textview.Text = "Clicks: " + clicks;
            };
            Upgradebutton.Click += delegate
            {
                if (clicks >= upgradecost)
                {
                    clicks -= upgradecost;
                    clickpower += clickpower;
                    upgradecost = (float)(Math.Round((decimal)(upgradecost * 2.5f),0));
                    Upgradebutton.Text = "Increase click power\nCost: " + upgradecost;
                    textview.Text = "Clicks: " + clicks;
                }
            };
            
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}
