using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;
using Web.Repos;

namespace Web.Controllers;

public class TeamsController : Controller
{
    private readonly AppDbContext _dbContext;
    private readonly ITeamsRepo _repo; //TODO still need to register this class in DI

    public TeamsController(AppDbContext dbContext, ITeamsRepo repo)
    {
        // Constructor dependency injection
        _dbContext = dbContext;
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> IndexAsync()
    {
        var teams = await _repo.GetAllAsync();
        return View(teams);
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync(int id)
    {
        var team = await _repo.GetAsync(id);
        return View(team);
    }

    [HttpGet]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        await _repo.DeleteAsync(id);
        return RedirectToAction("index");
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(Team team)
    {
        if (ModelState.IsValid)
            await _repo.CreateAsync(team);
        return RedirectToAction("index");
    }

    [HttpPost]
    public async Task<IActionResult> UpdateAsync(Team team)
    {
        if (ModelState.IsValid)
            await _repo.UpdateAsync(team);
        return RedirectToAction("index");
    }
}