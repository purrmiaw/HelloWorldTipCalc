using MvvmCross.Core.ViewModels;
using MvvmCross.Uwp.Platform;
using Windows.UI.Xaml.Controls;

namespace HelloWorld.UI.Uwp
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
