namespace Web.Models;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Location { get; set; } = string.Empty;
    public int NumberOfPlayers { get; set; }
    public decimal Income { get; set; }
}