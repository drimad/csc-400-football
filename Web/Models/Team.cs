using System.ComponentModel.DataAnnotations;

namespace Web.Models;

public class Team
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please provide a name for the team")]
    [MinLength(5)]
    public string Name { get; set; } = "";

    public string Location { get; set; } = string.Empty;

    [Required] [Range(6, 22)] public int NumberOfPlayers { get; set; }

    public decimal Income { get; set; }
}