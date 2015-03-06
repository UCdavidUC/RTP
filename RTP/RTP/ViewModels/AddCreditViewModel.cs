using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTP.ViewModels
{
	public class AddCreditViewModel : MvxViewModel
	{
		private decimal previousBalance;
		public decimal PreviousBalance
		{
			get { return previousBalance; }
			set { previousBalance = value; RaisePropertyChanged(() => PreviousBalance); }
		}

		private decimal newBalance;
		public decimal NewBalance
		{
			get { return newBalance; }
			set { newBalance = value; RaisePropertyChanged(() => NewBalance); }
		}

		private decimal currentBalance;
		public decimal CurrentBalance
		{
			get { return currentBalance; }
			set { currentBalance = value; RaisePropertyChanged(() => CurrentBalance); }
		}
	}
}
