using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Repos;

public class Teams3Repo
{
    private readonly AppDbContext _db;

    public Teams3Repo(AppDbContext db)
    {
        _db = db;
    }

    public void Create(Team team)
    {
        _db.Teams.Add(team);
        _db.SaveChanges();
    }

    public List<Team> GetAll()
    {
        return _db.Teams.ToList();
    }

    public Team Get(int id)
    {
        return _db.Teams.Find(id);
    }

    public void Update(Team team)
    {
        _db.Teams.Update(team);
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        var team = Get(id);
        _db.Teams.Remove(team);
        _db.SaveChanges();
    }
}