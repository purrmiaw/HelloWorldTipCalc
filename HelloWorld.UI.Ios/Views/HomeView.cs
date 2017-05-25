
using System;
using System.Drawing;

using Foundation;
using UIKit;
using MvvmCross.iOS.Views;
using HelloWorld.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.iOS;

namespace HelloWorld.UI.Ios.Views
{
    [MvxFromStoryboard]
    public partial class HomeView : MvxViewController<HomeViewModel>
    {
        public HomeView(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            var set = this.CreateBindingSet<HomeView, HomeViewModel>();
            //set.Bind(ClickHereButton).To(vm => vm.ClickHereButton_Click);
            set.Bind(ClickHereButton).For(x => x.BindTouchUpInside()).To(vm => vm.ClickHereButton_Click);
            set.Apply();

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}