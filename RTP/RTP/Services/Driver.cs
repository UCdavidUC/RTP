using RestSharp.Portable;
using RTP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RTP.Services
{
	public class Driver
	{
		static RestClient client = new RestClient("http://example.com");
		static Guid loginId = default(Guid);

		public static async Task Login(string username, string password)
		{
#if DEBUG
			loginId = Guid.NewGuid();
			return;
#else
			var request = new RestRequest("api/LoginDriver", HttpMethod.Post);
			request.AddParameter("username", username);
			request.AddParameter("password", password);

			try
			{
				var result = await client.Execute<Guid>(request);
				loginId = result.Data;
			}
			catch (Exception)
			{
				loginId = default(Guid);
				throw;
			}
#endif
		}

		public static async Task<Guid> RequestPayment(int passengerCount, int passengerWithDiscountCount)
		{
			var request = new RestRequest("api/RequestPayment", HttpMethod.Post);
			request.AddParameter("passengerCount", passengerCount);
			request.AddParameter("passengerWithDiscountCount", passengerWithDiscountCount);

			request.AddHeader("Authentication", loginId);

			var result = await client.Execute<Guid>(request);
			return result.Data;
		}

		public static async Task<bool> ReceivePayment(Guid paymentId)
		{
			var request = new RestRequest("api/ReceivePayment", HttpMethod.Post);
			request.AddParameter("paymentId", paymentId);

			request.AddHeader("Authentication", loginId);

			var result = await client.Execute<bool>(request);
			return result.Data;
		}

		public static async Task<List<PaymentViewModel>> GetHistory()
		{
			var request = new RestRequest("api/GetHistory", HttpMethod.Get);

			request.AddHeader("Authentication", loginId);

			var result = await client.Execute<List<PaymentViewModel>>(request);
			return result.Data;
		}
	}
}
