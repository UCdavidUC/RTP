using Acr.MvvmCross.Plugins.UserDialogs;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RTP.ViewModels
{
	public class ConductorViewModel : MvxViewModel
	{
		private string usuario;
		public string Usuario
		{
			get { return usuario; }
			set { usuario = value; RaisePropertyChanged(() => Usuario); }
		}

		private string password;
		public string Password
		{
			get { return password; }
			set { password = value; RaisePropertyChanged(() => Password); }
		}

		private readonly IUserDialogService dialogs;
		public ConductorViewModel(IUserDialogService dialogService)
		{
			this.dialogs = dialogService;
		}

		public ICommand Login
		{
			get
			{
				return new MvxCommand(async () =>
				{
					try
					{
						await Services.Driver.Login(Usuario, Password);
						ShowViewModel<ExitoLoginViewModel>();
						return;
					}
					catch (Exception) { }

					await dialogs.AlertAsync("Usuario o contraseña incorrectos", "Error");
				});
			}
		}
	}
}
