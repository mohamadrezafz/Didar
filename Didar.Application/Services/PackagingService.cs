
using Didar.Application.Interfaces.Repositories;
using Didar.Application.Interfaces.Services;
using Didar.Domain.Entities;
using Didar.Domain.Enums;

namespace Didar.Application.Services;

public class PackagingService : IPackagingService
{
    private readonly IPackageRepository _packageRepository;
    private readonly ISubscriptionRepository _subscriptionRepository;
    private readonly IUserRepository _userRepository;

    public PackagingService(IPackageRepository packageRepository , ISubscriptionRepository subscriptionRepository , IUserRepository userRepository)
    {
        _packageRepository = packageRepository;
        _subscriptionRepository = subscriptionRepository;
        _userRepository = userRepository;

    }
    public async Task<bool> CanAccessFacilityAsync(string userId, string facilityName)=>
         await _userRepository.HasFacilityAccessAsync(userId, facilityName);
    

    public async Task<bool> CanCreateFacilityAsync(string userId)
    {
        var subscription = await _subscriptionRepository.GetSubscriptionByUserIdAsync(userId);
        
        return default(bool);
    }

    public async Task<SubscriptionPlan> GetSubscriptionPlanAsync(string userId)
    {
        var res = await _subscriptionRepository.GetSubscriptionByUserIdAsync(userId);
        return default;
    }
    public async Task<Package> CreatePackageAsync(string userId, Package package)
    {
        // Implement business logic for package creation
        // ... 
        package.UserId = userId;
        await _packageRepository.CreatePackageAsync(package);
        return package;
    }

    public async Task<Package> GetPackageDetailsAsync(string packageId)=>
         await _packageRepository.GetPackageByIdAsync(packageId);

    public async Task<List<Package>> GetPackagesByUserAsync(string userId)=>
         await _packageRepository.GetPackagesByUserIdAsync(userId);
    

    public async Task<Package> UpdatePackageAsync(Package package)
    {
        // Implement business logic for package update
        // ... 
        await _packageRepository.UpdatePackageAsync(package);
        return package;
    }

    public async Task DeletePackageAsync(string packageId)
    {
        await _packageRepository.DeletePackageAsync(packageId);
    }
}