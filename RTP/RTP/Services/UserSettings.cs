using Refractored.Xam.Settings;
using Refractored.Xam.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTP.Services
{
	public static class UserSettings
	{
		private static ISettings AppSettings
		{
			get { return CrossSettings.Current; }
		}

		public static bool InicióSesión
		{
			get { return	AppSettings.GetValueOrDefault	("InicióSesión", false); }
			set {	AppSettings.AddOrUpdateValue	("InicióSesión", value); }
		}

		public static bool EsPasajero
		{
			get { return	AppSettings.GetValueOrDefault	("EsPasajero", true); }
			set {	AppSettings.AddOrUpdateValue	("EsPasajero", value); }
		}

		public static Guid UserId
		{
			get { return	AppSettings.GetValueOrDefault	("UserId", default(Guid)); }
			set {	AppSettings.AddOrUpdateValue	("UserId", value); }
		}

		public static decimal Saldo
		{
			get { return	AppSettings.GetValueOrDefault	("Saldo", 0.00M); }
			set {	AppSettings.AddOrUpdateValue	("Saldo", value); }
		}
	}
}
