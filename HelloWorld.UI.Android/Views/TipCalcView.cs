using MvvmCross.Droid.Views;

namespace HelloWorld.UI.Android.Views
{
    public class TipCalcView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.tipcalc_view);
        }
       
    }
}