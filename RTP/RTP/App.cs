using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Plugins;

namespace RTP
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.InicialViewModel>();
        }


		//public override void LoadPlugins(IMvxPluginManager pluginManager)
		//{
		//	base.LoadPlugins(pluginManager);
		//	pluginManager.EnsurePlatformAdaptionLoaded<Cirrious.MvvmCross.Plugins.Messenger.PluginLoader>();
		
		//	//pluginManager.EnsurePlatformAdaptionLoaded<Acr.MvvmCross.Plugins.BarCodeScanner.PluginLoader>();
		//	//pluginManager.EnsurePlatformAdaptionLoaded<Acr.MvvmCross.Plugins.DeviceInfo.PluginLoader>();
		//	//pluginManager.EnsurePlatformAdaptionLoaded<Acr.MvvmCross.Plugins.Settings.PluginLoader>();
		//	pluginManager.EnsurePlatformAdaptionLoaded<Acr.MvvmCross.Plugins.UserDialogs.PluginLoader>();
		//	//pluginManager.EnsurePlatformAdaptionLoaded<Acr.MvvmCross.Plugins.FileSystem.PluginLoader>();
		//	//pluginManager.EnsurePlatformAdaptionLoaded<Acr.MvvmCross.Plugins.SignaturePad.PluginLoader>();
		//	//pluginManager.EnsurePlatformAdaptionLoaded<Cirrious.MvvmCross.Plugins.Color.PluginLoader>();
		//	//pluginManager.EnsurePlatformAdaptionLoaded<Cirrious.MvvmCross.Plugins.File.PluginLoader>();
		//	//pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Messenger.PluginLoader>();
		//}
	}
}