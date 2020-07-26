using System.Threading.Tasks;

namespace Accuweather.Indices
{
	/// <summary>
	/// Get Indices information for a specific location.
	/// </summary>
	public interface IIndices
	{

		/// <summary>
		/// Returns 5 days of daily index data for a specific group of indices, by location key.
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="group">Index group ID.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns></returns>
		Task<string> FiveDaysOfDailyIndexValuesByGroupIndex(int locationKey, int group, bool details = false);

		/// <summary>
		/// Returns 5 days of daily index data for a specific index, by location key.
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="specific">Specific Index ID.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns></returns>
		Task<string> FiveDaysOfDailyIndexValuesBySpecificIndex(int locationKey, int specific, bool details = false);

		/// <summary>
		/// Returns 5 days of daily index data for all indices, by location key.
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns></returns>
		Task<string> FiveDaysOfDailyIndexValues(int locationKey, bool details = false);
	}
}
