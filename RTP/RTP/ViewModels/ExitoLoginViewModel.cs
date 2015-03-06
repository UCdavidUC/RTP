using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RTP.ViewModels
{
	public class ExitoLoginViewModel : MvxViewModel
	{
		public ICommand Cobrar
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<CobroViewModel>());
			}
		}

		public ICommand Historial
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<HistorialViewModel>());
			}
		}
	}
}
