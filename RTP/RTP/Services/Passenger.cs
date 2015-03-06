using RestSharp.Portable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RTP.Services
{
	public class Passenger
	{
		static RestClient client = new RestClient("http://example.com");
		static Guid loginId = default(Guid);

		public static async Task CreateUser()
		{
#if DEBUG
			loginId = Guid.NewGuid();
			return;
#else
			var request = new RestRequest("api/CreatePassenger", HttpMethod.Post);
			var id = Guid.NewGuid();
			request.AddParameter("guid", id);

			try
			{
				var result = await client.Execute(request);
				loginId = id;
			}
			catch (Exception)
			{
				loginId = default(Guid);
			}
#endif
		}

		public static async Task<bool> AddCredit(decimal amount)
		{
#if DEBUG
			return true;
#else
			var request = new RestRequest("api/AddCredit", HttpMethod.Post);
			request.AddParameter("amount", amount);

			request.AddHeader("Authentication", loginId);

			var result = await client.Execute<bool>(request);
			return result.Data;
#endif
		}

		public static async Task<bool> SendPayment(Guid paymentId)
		{
#if DEBUG
			UserSettings.Saldo -= 5.00M;
			return true;
#else
			var request = new RestRequest("api/SendPayment", HttpMethod.Post);
			request.AddParameter("paymentId", paymentId);

			request.AddHeader("Authentication", loginId);

			var result = await client.Execute<bool>(request);
			return result.Data;
#endif
		}
	}
}
