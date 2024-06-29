

using Didar.Domain.Entities;
using Didar.Domain.Enums;

namespace Didar.Application.Interfaces.Services;

public interface IPackagingService
{
    Task<SubscriptionPlan> GetSubscriptionPlanAsync(string userId);
    Task<bool> CanAccessFacilityAsync(string userId, string facilityName);
    Task<bool> CanCreateFacilityAsync(string userId);
    Task<Package> CreatePackageAsync(string userId, Package package);
    Task<Package> GetPackageDetailsAsync(string packageId);
    Task<List<Package>> GetPackagesByUserAsync(string userId);
    Task<Package> UpdatePackageAsync(Package package);
    Task DeletePackageAsync(string packageId);
}