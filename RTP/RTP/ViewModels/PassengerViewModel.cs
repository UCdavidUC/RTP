using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RTP.ViewModels
{
	public class PassengerViewModel : MvxViewModel
	{
		private decimal balance;

		public decimal Balance
		{
			get { return balance; }
			set { balance = value; RaisePropertyChanged(() => Balance); }
		}

		public ICommand AddCredit
		{
			get { return new MvxCommand(() => ShowViewModel<AddCreditViewModel>()); }
		}

		public ICommand Pay
		{
			get { return new MvxCommand(() => ShowViewModel<PayViewModel>()); }
		}
	}
}
