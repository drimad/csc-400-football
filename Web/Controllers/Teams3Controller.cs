using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Web.Data;
using Web.Models;
using Web.Repos;

namespace Web.Controllers;

public class Teams3Controller : Controller
{
    private readonly Teams3Repo _repo;

    public Teams3Controller(Teams3Repo repo)
    {
        _repo = repo;
    }

    public IActionResult Index()
    {
        var teams = _repo.GetAll();
        return View(teams);
    }

    public IActionResult Get(int id)
    {
        var team = _repo.Get(id);
        return View(team);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        _repo.Delete(id);
        return RedirectToAction("index");
    }

    [HttpPost]
    public IActionResult Create(Team team)
    {
        if (ModelState.IsValid)
            _repo.Create(team);
        return RedirectToAction("index");
    }

    [HttpPost]
    public IActionResult Update(Team team)
    {
        _repo.Update(team);
        return RedirectToAction("index");
    }
}