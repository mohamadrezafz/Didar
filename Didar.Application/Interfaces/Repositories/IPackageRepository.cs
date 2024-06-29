using Didar.Domain.Entities;

namespace Didar.Application.Interfaces.Repositories;
public interface IPackageRepository
{
    Task<Package> CreatePackageAsync(Package package);
    Task<Package> GetPackageByIdAsync(string packageId);
    Task<List<Package>> GetPackagesByUserIdAsync(string userId);
    Task<Package> UpdatePackageAsync(Package package);
    Task DeletePackageAsync(string packageId);
}