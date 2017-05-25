using Android.App;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace HelloWorld.UI.Android.Views
{
    [Activity]
    public class HomeView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.home_view);
        }
    }
}