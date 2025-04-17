using SmartLine.Model;

namespace SmartLine.Services.CalendarService;

public interface ICalendarDayRepository
{
    Task<bool> AddUpdateCalendarDayAsync(CalendarDay calendarDay);
    Task<bool> DeleteCalendarDayAsync(int calendarId);
    Task<Product> GetCalendarDayAsync(int calendarId);
    Task<IEnumerable<Product>> GetCalendarDayAsync();
}
