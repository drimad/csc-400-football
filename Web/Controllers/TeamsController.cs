using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

// /teams/
public class TeamsController : Controller
{
    public List<string> Teams { get; set; } = new(); // maintain encapsulation

    public TeamsController()
    {
        Teams.Add("Barcelona");
        Teams.Add("PSG");
        Teams.Add("BayerMunich");
    }

    public IActionResult Index()
    {
        ViewBag.Teams = Teams;
        return View();
    }
}