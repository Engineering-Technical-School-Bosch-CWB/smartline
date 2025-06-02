using SQLite;

namespace SmartLine.Model;

public class Demand
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int Stock { get; set; }
    public int DemandProduct { get; set; }
    public DateTime DeadLine { get; set; }
    public int ProductId { get; set; }
}