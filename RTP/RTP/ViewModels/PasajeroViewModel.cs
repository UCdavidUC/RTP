using Acr.MvvmCross.Plugins.BarCodeScanner;
using Acr.MvvmCross.Plugins.UserDialogs;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using RTP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RTP.ViewModels
{
	public class PasajeroViewModel : MvxViewModel
	{
		public decimal Saldo
		{
			get { return UserSettings.Saldo; }
		}

		private readonly IUserDialogService dialogs;
		private readonly IBarCodeService scanner;

		public PasajeroViewModel(IBarCodeService scanner, IUserDialogService dialogService)
		{
			this.scanner = scanner;
			this.dialogs = dialogService;

			//BarCodeReadConfiguration.Default.Formats = new List<BarCodeFormat>
			//{
			//	BarCodeFormat.QR_CODE
			//};
		}

		public ICommand Recarga
		{
			get { return new MvxCommand(() => ShowViewModel<RecargaSaldoViewModel>()); }
		}

		public ICommand Paga
		{
			get
			{
				return new MvxCommand(async () =>
				{
                    var result = await this.scanner.Read();
					if (result.Success)
					{
						//Guid code = Guid.Parse(result.Code);
						Guid code = default(Guid);
						bool valid = await Services.Passenger.SendPayment(code);
						if (valid)
						{
							OnMadeVisible();
							await dialogs.AlertAsync("El pago fue aceptado", "Pagado");
						}
						else
						{
							await dialogs.AlertAsync("El pago fue rechazado", "Error");
						}
					}
					else
					{
						this.dialogs.Alert("No se pudo leer el código");
					}
				});
			}
		}

		// No MvvmCross.
		public void OnMadeVisible()
		{
			RaisePropertyChanged(() => Saldo);
		}
	}
}
