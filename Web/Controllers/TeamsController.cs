using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

// /teams/
public class TeamsController : Controller
{
    public static List<string> Teams { get; set; } = new(); // maintain encapsulation

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

    public IActionResult Delete(int id)
    {
        // Delete the team from the list based on its index
        Teams.RemoveAt(id);
        return RedirectToAction("Index");
    }
}