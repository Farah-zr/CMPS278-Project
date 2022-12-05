using Brownies.Models;

namespace BrowniesRepo.Interfaces;

public interface IBrownieRepo
{
    Task<List<Brownie>> GetBrowniesAsync();
    Task<Brownie?> GetByIdAsync(int id); 
    Task<Brownie?> AddBrownieAsync(Brownie brownie);
    Task<bool> DeleteBrownieAsync(int id);
    Task<Brownie?> UpdateBrownieAsync(Brownie brownie, int id);
}