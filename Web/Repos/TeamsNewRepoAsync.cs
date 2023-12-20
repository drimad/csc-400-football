using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Repos;

public class TeamsNewRepoAsync : ITeamsRepo
{
    private readonly AppDbContext _db;

    public TeamsNewRepoAsync(AppDbContext db)
    {
        _db = db;
    }

    public async Task CreateAsync(Team team)
    {
        await _db.Teams.AddAsync(team);
        await _db.SaveChangesAsync();
    }

    public async Task<Team?> GetAsync(int id)
    {
        return await _db.Teams.FindAsync(id);
    }

    public async Task<List<Team>> GetAllAsync()
    {
        return await _db.Teams.ToListAsync();
    }

    public async Task UpdateAsync(Team team)
    {
        _db.Teams.Update(team);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var team = await GetAsync(id);
        _db.Teams.Remove(team);
        await _db.SaveChangesAsync();
    }
}