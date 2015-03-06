using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RTP.ViewModels
{
	public class PasajeroViewModel : MvxViewModel
	{
		private decimal saldo = 0.00M;

		public decimal Saldo
		{
			get { return saldo; }
			set { saldo = value; RaisePropertyChanged(() => Saldo); }
		}

		public ICommand Recarga
		{
			get { return new MvxCommand(() => ShowViewModel<RecargaSaldoViewModel>()); }
		}

		public ICommand Paga
		{
			get { return new MvxCommand(() => ShowViewModel<PayViewModel>()); }
		}
	}
}
