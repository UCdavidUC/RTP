using Akavache;
using Lager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTP.Services
{
	public class UserSettings : SettingsStorage
	{
		private UserSettings()
			: base("D5702B73-854F-4E92-93DD-99DB026918B4", Cache)
		{ }

		private static IBlobCache Cache = BlobCache.UserAccount;

		public static UserSettings Instance
		{
			get { return new UserSettings(); }
		}

		~UserSettings()
		{
			Cache.Flush();
		}

		public bool InicióSesión
		{
			get { return GetOrCreate(false); }
			set { SetOrCreate(value); }
		}

		public bool EsPasajero
		{
			get { return GetOrCreate(true); }
			set { SetOrCreate(value); }
		}

		public Guid UserId
		{
			get { return GetOrCreate(default(Guid)); }
			set { SetOrCreate(value); }
		}

		public decimal Saldo
		{
			get { return GetOrCreate(0.00M); }
			set { SetOrCreate(value); }
		}
	}
}
