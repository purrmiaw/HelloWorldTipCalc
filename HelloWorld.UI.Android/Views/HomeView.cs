using Android.App;
using MvvmCross.Droid.Views;

namespace HelloWorld.UI.Android.Views
{
    [Activity(MainLauncher=true)]
    public class HomeView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.home_view);
        }
    }
}