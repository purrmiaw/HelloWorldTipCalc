using HelloWorld.Core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace HelloWorld.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        ICalculationService _calculationService;
        IMvxNavigationService _mvxNavigationService;

        // MVVMCross will pass CalculationService and IMvxNavigationService here in the constructor
        public HomeViewModel(ICalculationService calculationService, IMvxNavigationService mvxNavigationService)
        {
            _calculationService = calculationService;
            _mvxNavigationService = mvxNavigationService;
        }

        public IMvxAsyncCommand ClickHereButton_Click
        {
            get
            {
                IMvxAsyncCommand navigationCommand = new MvxAsyncCommand(() => _mvxNavigationService.Navigate<TipCalcViewModel>());
                return navigationCommand;
            }
        }

        private double AnyFunction()
        {
            // We are now free to refer _calculationService anywhere inside the viewmodel
            return _calculationService.TipAmount(10, 2);
        }

    }
}
