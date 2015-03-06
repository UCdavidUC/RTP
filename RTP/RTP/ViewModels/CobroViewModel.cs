using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace RTP.ViewModels
{
    class CobroViewModel : MvxViewModel
    {
        private int numeroPasajeros = 1;

        public int NumeroPasajeros
        {
            get { return numeroPasajeros; }
            set { numeroPasajeros = value; RaisePropertyChanged(() => NumeroPasajeros); }
        }

        public ICommand plusAction
        {
            get { return new MvxCommand(() => 
            {
                NumeroPasajeros++;
            }); }
        }

        public ICommand minusAction
        {
            get
            {
                return new MvxCommand(() =>
                {
                    NumeroPasajeros--;
                });
            }
        }

        public ICommand Cobro
        {
            get { return new MvxCommand(() => ShowViewModel<QRViewModel>()); }
        }
    }
}
