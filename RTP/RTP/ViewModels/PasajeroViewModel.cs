using Cirrious.MvvmCross.ViewModels;
using RTP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RTP.ViewModels
{
	public class PasajeroViewModel : MvxViewModel
	{
		public decimal Saldo
		{
			get { return UserSettings.Saldo; }
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
