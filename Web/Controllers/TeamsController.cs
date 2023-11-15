using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

// /teams/
public class TeamsController : Controller
{
    private static List<string> Teams { get; set; } = new()
    {
        "Barcelona", "PSG", "BayerMunich"
    }; // maintain encapsulation


    // /teams/index
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Teams = Teams;
        return View();
    }

    // /teams/delete/id
    [HttpGet]
    public IActionResult Delete(int id)
    {
        // Delete the team from the list based on its index
        Teams.RemoveAt(id);
        return RedirectToAction("Index");
    }

    // /teams/add
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    // /teams/add
    [HttpPost]
    public IActionResult Add(string teamName)
    {
        Teams.Add(teamName);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        // retrieve the current team name at the specified id index
        var oldName = Teams[id];
        // send both id & current team name to the view through ViewBag
        ViewBag.id = id;
        ViewBag.name = oldName;
        return View();
    }

    [HttpPost]
    public IActionResult Edit(int id, string newTeamName)
    {
        // replace the current team name with the new team name at the specified id/index
        Teams[id] = newTeamName;
        return RedirectToAction("Index");
    }
}