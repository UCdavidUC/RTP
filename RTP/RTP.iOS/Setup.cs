using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;
using UIKit;
using Cirrious.CrossCore.Plugins;

namespace RTP.iOS
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
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

			//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.BarCodeScanner.PluginLoader>();
			//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.DeviceInfo.PluginLoader>();
			//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.Settings.PluginLoader>();
			pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.UserDialogs.PluginLoader>();
			//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.FileSystem.PluginLoader>();
			//pluginManager.EnsurePluginLoaded<Acr.MvvmCross.Plugins.SignaturePad.PluginLoader>();
			//pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Color.PluginLoader>();
			//pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.File.PluginLoader>();
			//pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Messenger.PluginLoader>();
		}
	}
}