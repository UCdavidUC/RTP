using Acr.MvvmCross.Plugins.UserDialogs;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RTP.ViewModels
{
	public class RecargaSaldoViewModel : MvxViewModel
	{
		private decimal saldoActual;
		public decimal SaldoActual
		{
			get { return saldoActual; }
			set { saldoActual = value; RaisePropertyChanged(() => SaldoActual); }
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

		/*
		 public DialogsViewModel(IUserDialogService dialogService, IMvxMessenger messenger) { 
	56 			this.dialogs = dialogService; 
	57             
	58             
	59             
	60 
 
	61             this.SendBackgroundAlert = new MvxCommand(() =>  
	62                 messenger.Publish(new BackgroundAlert(this, "Test")) 
	63             ); 
	64 
 
	65             this.ActionSheet = new MvxCommand(() =>  
	66                 dialogService.ActionSheet(new ActionSheetConfig() 
	67                     .SetTitle("Test Title") 
	68                     .Add("Option 1", () => this.Result = "Option 1 Selected") 
	69                     .Add("Option 2", () => this.Result = "Option 2 Selected") 
	70                     .Add("Option 3", () => this.Result = "Option 3 Selected") 
	71                     .Add("Option 4", () => this.Result = "Option 4 Selected") 
	72                     .Add("Option 5", () => this.Result = "Option 5 Selected") 
	73                     .Add("Option 6", () => this.Result = "Option 6 Selected") 
	74                 ) 
	75             ); 

	 
		 */

		public ICommand GooglePlay
		{
			get
			{
				return new MvxCommand(async () =>
				{
					 var r = await dialogs.ConfirmAsync("Pick a choice", "Pick Title", "Yes", "No");
					 var text = (r ? "Yes" : "No");
				});
			}
		}

		//public ICommand SMS
		//{

		//}
	}
}
