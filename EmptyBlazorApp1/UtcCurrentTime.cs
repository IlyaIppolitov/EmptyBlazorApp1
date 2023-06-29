using EmptyBlazorApp1.Services;

namespace EmptyBlazorApp1
{
	/// <summary>
	/// Генератор UTC времени 
	/// </summary>
	public class UtcCurrentTime : ICurrentTime
	{

		/// <summary>
		/// Получить текущее UTC время
		/// </summary>
		/// <returns>Текущее UTC время</returns>
		public DateTime getCurrentTime()
		{
			return DateTime.UtcNow;
		}
	}
}
