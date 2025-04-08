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

    public Task<ProductInfo> GetCalendarDayAsync(int calendarId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductInfo>> GetCalendarDayAsync()
    {
        throw new NotImplementedException();
    }
}