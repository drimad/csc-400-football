using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;
using Web.Repos;

namespace Web.Controllers;

public class Teams2Controller : Controller
{
    private readonly AppDbContext _dbContext;
    private readonly TeamsRepo _repo; //TODO still need to register this class in DI

    public Teams2Controller(AppDbContext dbContext, TeamsRepo repo)
    {
        // Constructor dependency injection
        _dbContext = dbContext;
        _repo = repo;
    }
    // private static List<Team> Teams { get; set; } = new()
    // {
    //     new Team()
    //     {
    //         Id = 0,
    //         Name = "Barcelona",
    //         Location = "Spain",
    //         NumberOfPlayers = 36,
    //         Income = 1000000000000
    //     },
    //     new Team()
    //     {
    //         Id = 1,
    //         Name = "PSG",
    //         Location = "France",
    //         NumberOfPlayers = 34,
    //         Income = 10000000000000
    //     },
    //     new Team()
    //     {
    //         Id = 2,
    //         Name = "Liverpool",
    //         Location = "UK",
    //         NumberOfPlayers = 32,
    //         Income = 10000000000
    //     }
    // };

    public IActionResult Index()
    {
        var teams = _repo.GetAll();
        return View(teams);
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        var team = _repo.Get(id);
        return View(team);
    }

    [HttpDelete("{id:int}")]
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

    [HttpPut("{id:int}")]
    public IActionResult Update(Team team)
    {
        if (ModelState.IsValid)
            _repo.Update(team);
        return RedirectToAction("index");
    }
}