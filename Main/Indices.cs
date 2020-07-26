using Accuweather.Core.Helpers;
using Accuweather.Core;
using System.Threading.Tasks;

namespace Accuweather.Indices
{
	/// <summary>
	///	Accuweather Indices Api
	/// </summary>
	public class Indices : AccuweatherApiCore, IIndices
	{
		private const string _baseUrl = "http://dataservice.accuweather.com/indices/v1";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="apiKey">Api key accuweather.</param>
		/// <param name="language">Language.</param>
		/// <returns></returns>
		public Indices(string apiKey, string language = "en-us") : base(apiKey, language)
		{

		}
		private object GetObjectIndices(bool details)
		{
			return new
			{
				language = _language,
				details
			};
		}

		///<inheritdoc cref="IIndices.FiveDaysOfDailyIndexValuesByGroupIndex(int, int, bool)"/>
		public async Task<string> FiveDaysOfDailyIndexValuesByGroupIndex(int locationKey, int group,
		bool details = false)
		{
			var obj = GetObjectIndices(details);
			var url = $"{_baseUrl}/daily/5day/{locationKey}/groups/{group}?apikey={_apiKey}&";

			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		///<inheritdoc cref="IIndices.FiveDaysOfDailyIndexValuesBySpecificIndex(int, int, bool)"/>
		public async Task<string> FiveDaysOfDailyIndexValuesBySpecificIndex(int locationKey, int specific,
		bool details = false)
		{
			var obj = GetObjectIndices(details);
			var url = $"{_baseUrl}/daily/5day/{locationKey}/{specific}?apikey={_apiKey}&";

			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		///<inheritdoc cref="IIndices.FiveDaysOfDailyIndexValues(int, bool)"/>
		public async Task<string> FiveDaysOfDailyIndexValues(int locationKey, bool details = false)
		{
			var obj = GetObjectIndices(details);
			var url = $"{_baseUrl}/daily/5day/{locationKey}?apikey={_apiKey}&";

			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}
	}
}