using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTP.ViewModels
{
	public class Pago : MvxViewModel
	{
		private DateTime date;
		public DateTime Date
		{
			get { return date; }
			set { date = value; RaisePropertyChanged(() => Date); }
		}

		private int numPassengers;
		public int NumPassengers
		{
			get { return numPassengers; }
			set { numPassengers = value; RaisePropertyChanged(() => NumPassengers); }
		}

		private decimal totalIncome;
		public decimal TotalIncome
		{
			get { return totalIncome; }
			set { totalIncome = value; RaisePropertyChanged(() => TotalIncome); }
		}
	}
}
