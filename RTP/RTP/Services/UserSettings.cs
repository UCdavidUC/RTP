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
		public UserSettings()
			: base("D5702B73-854F-4E92-93DD-99DB026918B4", BlobCache.UserAccount)
		{ }

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

		public decimal SaldoActual
		{
			get { return GetOrCreate(0.00M); }
			set { SetOrCreate(value); }
		}

		public decimal SaldoRecargado
		{
			get { return GetOrCreate(0.00M); }
			set { SetOrCreate(value); }
		}

		public decimal SaldoAnterior
		{
			get { return GetOrCreate(0.00M); }
			set { SetOrCreate(value); }
		}
	}
}
