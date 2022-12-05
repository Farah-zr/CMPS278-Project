using CakePops.Models;

namespace CakePopsRepo.Interfaces;

public interface ICakePopRepo
{
    Task<List<CakePop>> GetCakePopsAsync();
    Task<CakePop?> GetByIdAsync(int id); 
    Task<CakePop?> AddCakePopAsync(CakePop cakePop);
    Task<bool> DeleteCakePopAsync(int id);
    Task<CakePop?> UpdateCakePopAsync(CakePop CakePop, int id);
}