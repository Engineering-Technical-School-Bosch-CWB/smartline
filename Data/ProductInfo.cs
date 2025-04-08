using SQLite;

namespace SmartLine.Data;

public class ProductInfo
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
}
