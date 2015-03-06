using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RTP.ViewModels
{
	public class HistorialViewModel : MvxViewModel
	{
		private List<Pago> pagos;
		public List<Pago> Pagos
		{
			get { return pagos; }
			set { pagos = value; RaisePropertyChanged(() => Pagos); }
		}

		private decimal totalAcumulado;
		public decimal TotalAcumulado
		{
			get { return totalAcumulado; }
			set { totalAcumulado = value; RaisePropertyChanged(() => TotalAcumulado); }
		}

		public async void Init()
		{
			Pagos = await Services.Driver.GetHistory();
			TotalAcumulado = Pagos.Sum(a => a.TotalIncome);
		}
	}
}
