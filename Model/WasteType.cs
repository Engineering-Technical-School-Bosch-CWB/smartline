using SQLite;

namespace SmartLine.Model;

public class TipoDePerda
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool Pattern { get; set; }
}
