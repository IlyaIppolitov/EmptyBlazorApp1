namespace EmptyBlazorApp1.Services
{
    public interface ICurrentTime
    {
        /// <summary>
        /// Получить текущее время
        /// </summary>
        /// <returns>текущее время</returns>
        DateTime getCurrentTime();
    }
}
