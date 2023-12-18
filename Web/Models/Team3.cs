using System.ComponentModel.DataAnnotations;

namespace Web.Models;

public class Team3
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a name for the team")]
    [MinLength(5, ErrorMessage = "Please name should be more than 5 characters")]
    [MaxLength(250)]
    public string Name { get; set; } = "";

    public string Location { get; set; } = string.Empty;

    [Required] [Range(5, 22)] public int NumberOfPlayers { get; set; }

    public decimal Income { get; set; }
}