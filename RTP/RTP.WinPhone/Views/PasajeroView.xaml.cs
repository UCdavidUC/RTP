using Cirrious.MvvmCross.WindowsPhone.Views;
using RTP.ViewModels;

namespace RTP.WinPhone.Views
{
    public partial class PasajeroView : MvxPhonePage
    {
        public PasajeroView()
        {
            InitializeComponent();
        }

		protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);

			(this.DataContext as PasajeroViewModel).OnMadeVisible();
		}
    }
}