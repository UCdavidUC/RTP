using Cirrious.MvvmCross.ViewModels;
using System;
using System.Windows.Input;

namespace RTP.ViewModels
{
    public class InicialViewModel : MvxViewModel
    {
		public ICommand PassengerCommand
		{
			get
			{
				return new MvxCommand(async () =>
				{
					try
					{
						await Services.Passenger.CreateUser();
						ShowViewModel<PasajeroViewModel>();
					}
					catch (Exception) { }
				});
			}
		}

		public ICommand DriverCommand
		{
			get
			{
				return new MvxCommand(() =>
				{
					ShowViewModel<ConductorViewModel>();
				});
			}
		}
    }
}
