using Cirrious.CrossCore.Platform;
using Cirrious.CrossCore.Plugins;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsPhone.Platform;
using Microsoft.Phone.Controls;

namespace RTP.WinPhone
{
    public class Setup : MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new RTP.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		public override void LoadPlugins(IMvxPluginManager pluginManager)
		{
			base.LoadPlugins(pluginManager);

			pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Messenger.PluginLoader>();
			pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.BarCodeScanner.PluginLoader>();
			pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.UserDialogs.PluginLoader>();
		//	pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Messenger.PluginLoader>();

		//	//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.DeviceInfo.PluginLoader>();
		//	//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.Settings.PluginLoader>();
		//	//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.FileSystem.PluginLoader>();
		//	//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.SignaturePad.PluginLoader>();
		//	//pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Color.PluginLoader>();
		//	//pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.File.PluginLoader>();
		}
    }
}