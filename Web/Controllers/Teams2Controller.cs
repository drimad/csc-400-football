using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class Teams2Controller : Controller
{
    private static List<Team> Teams { get; set; } = new()
    {
        new Team()
        {
            Id = 0,
            Name = "Barcelona",
            Location = "Spain",
            NumberOfPlayers = 36,
            Income = 1000000000000
        },
        new Team()
        {
            Id = 1,
            Name = "PSG",
            Location = "France",
            NumberOfPlayers = 34,
            Income = 10000000000000
        },
        new Team()
        {
            Id = 2,
            Name = "Liverpool",
            Location = "UK",
            NumberOfPlayers = 32,
            Income = 10000000000
        }
    };

    public IActionResult Index()
    {
        return View();
    }
}