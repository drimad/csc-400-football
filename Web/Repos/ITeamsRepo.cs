using Web.Models;

namespace Web.Repos;

public interface ITeamsRepo
{
    Task CreateAsync(Team team);

    Task<Team?> GetAsync(int id);

    Task<List<Team>> GetAllAsync();

    Task UpdateAsync(Team team);

    Task DeleteAsync(int id);
}