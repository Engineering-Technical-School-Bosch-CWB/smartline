using SmartLine.Model;
using SQLite;

namespace SmartLine.Services.CalendarService;

public class CalendarDayService : ICalendarDayRepository
{
    public Task<bool> AddUpdateCalendarDayAsync(CalendarDay calendarDay)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCalendarDayAsync(int calendarId)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetCalendarDayAsync(int calendarId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetCalendarDayAsync()
    {
        throw new NotImplementedException();
    }

    Task<Product> ICalendarDayRepository.GetCalendarDayAsync(int calendarId)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Product>> ICalendarDayRepository.GetCalendarDayAsync()
    {
        throw new NotImplementedException();
    }
}