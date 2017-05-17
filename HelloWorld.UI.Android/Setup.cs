using Android.Content;
using HelloWorld.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace HelloWorld.UI.Android
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
        : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}