using SQLite;

namespace SmartLine.Model;

public class Product
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string? Name { get; set; }
    public double TimeSideA { get; set; }
    public double TimeSideB { get; set; }
    public string? PartNumber { get; set; }
}
