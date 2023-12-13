using Web.Data;
using Web.Models;

namespace Web.Repos;

public class TeamsRepo
{
    private readonly AppDbContext _db;

    public TeamsRepo(AppDbContext db)
    {
        _db = db;
    }

    public void Create(Team team)
    {
        _db.Teams.Add(team);
        _db.SaveChanges();
    }

    public Team Get(int id)
    {
        return _db.Teams.Find(id);
    }

    public List<Team> GetAll()
    {
        return _db.Teams.ToList();
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