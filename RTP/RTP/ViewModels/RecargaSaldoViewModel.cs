using Acr.MvvmCross.Plugins.UserDialogs;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using RTP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RTP.ViewModels
{
	public class RecargaSaldoViewModel : MvxViewModel
	{
		public decimal SaldoActual
		{
			get { return UserSettings.Instance.Saldo; }
			set { UserSettings.Instance.Saldo = value; RaisePropertyChanged(() => SaldoActual); }
		}

		private decimal saldoARecargar;
		public decimal SaldoARecargar
		{
			get { return saldoARecargar; }
			set { saldoARecargar = value; RaisePropertyChanged(() => SaldoARecargar); }
		}

		private readonly IUserDialogService dialogs;

		public RecargaSaldoViewModel(IUserDialogService dialogService, IMvxMessenger messenger)
		{
			this.dialogs = dialogService;
		}

		public ICommand GooglePlay
		{
			get
			{
				return new MvxCommand(async () =>
				{
					await dialogs.AlertAsync("Esta es una versión de prueba, por lo que agregará saldo sin cobrarte", "Trabajo en progreso");
					var valid = await Services.Passenger.AddCredit(SaldoARecargar);
					if (valid)
					{
						SaldoActual += SaldoARecargar;
						await dialogs.AlertAsync(String.Format("Se han recargado ${0} a tu cuenta", SaldoARecargar), "Pago validado");
						Close(this);
					}
					else
					{
						SaldoARecargar = 0.00M;
						await dialogs.AlertAsync("No se pudo validar el pago", "Error");
					}
				});
			}
		}

		public ICommand SMS
		{
			get { return GooglePlay; }
		}
	}
}
