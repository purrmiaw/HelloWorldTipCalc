using HelloWorld.Core.Services;
using MvvmCross.Core.ViewModels;

namespace HelloWorld.Core.ViewModels
{
    public class TipCalcViewModel : MvxViewModel
    {
        private ICalculationService _calculationService;

        public TipCalcViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public override void Start()
        {
            this.SubTotal = 100;
            this.Generosity = 20;
            base.Start();
        }

        private double _subTotal;
        public double SubTotal
        {
            get
            {
                return _subTotal;
            }
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get
            {
                return _generosity;
            }
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalculate();
            }
        }

        private double _tip;
        public double Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        private void Recalculate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Generosity);
        } 
    }
}
