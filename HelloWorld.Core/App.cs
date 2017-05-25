using HelloWorld.Core.Services;
using HelloWorld.Core.Services.Impl;
using HelloWorld.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace HelloWorld.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<HomeViewModel>());
        }
    }
}
