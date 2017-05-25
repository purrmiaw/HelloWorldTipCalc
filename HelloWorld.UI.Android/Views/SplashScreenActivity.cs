using Android.App;
using MvvmCross.Droid.Views;

namespace HelloWorld.UI.Android.Views
{
    [Activity(Label = "Hello World", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity() : base(Resource.Layout.splashscreen_view)
        {
        }
    }
}