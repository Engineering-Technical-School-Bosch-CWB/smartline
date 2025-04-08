using SQLite;

namespace SmartLine.Model;

public class CalendarDay
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public int ProductId1 { get; set; }
    public int ProductId2 { get; set; }
    public int CellCalendarId { get; set; }
}
