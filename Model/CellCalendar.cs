using SQLite;

namespace SmartLine.Model;

public class CellCalendar
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public required string CellName { get; set; }
}
