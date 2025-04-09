using SQLite;

namespace SmartLine.Model;

public class WasteTime{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int WasteTypeId { get; set; }
    public int Minutes { get; set; }
    public int WorkShift { get; set; }
    public int CalendarDayId { get; set; }
}
