using CinnamonRolls.Models;

namespace CinnamonRollsRepo.Interfaces;

public interface ICinnamonRollRepo
{
    Task<List<CinnamonRoll>> GetCinnamonRollsAsync();
    Task<CinnamonRoll?> GetByIdAsync(int id); 
    Task<CinnamonRoll?> AddCinnamonRollAsync(CinnamonRoll CinnamonRoll);
    Task<bool> DeleteCinnamonRollAsync(int id);
    Task<CinnamonRoll?> UpdateCinnamonRollAsync(CinnamonRoll CinnamonRoll, int id);
}