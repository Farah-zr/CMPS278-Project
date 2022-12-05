using Cupcakes.Models;

namespace CupcakesRepo.Interfaces;

public interface ICupcakeRepo
{
    Task<List<Cupcake>> GetCupcakesAsync();
    Task<Cupcake?> GetByIdAsync(int id); 
    Task<Cupcake?> AddCupcakeAsync(Cupcake Cupcake);
    Task<bool> DeleteCupcakeAsync(int id);
    Task<Cupcake?> UpdateCupcakeAsync(Cupcake Cupcake, int id);
}