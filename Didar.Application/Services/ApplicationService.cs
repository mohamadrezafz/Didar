using Didar.Application.Interfaces.Repositories;
using Didar.Application.Interfaces.Services;
using Didar.Domain.Enums;

namespace Didar.Application.Services;
public class ApplicationService : IApplicationService
{
    private readonly IApplicationRepository _applicationRepository;
    private readonly IPackagingService _packagingService;

    public ApplicationService(
        IApplicationRepository applicationRepository,
        IPackagingService packagingService)
    {
        _applicationRepository = applicationRepository;
        _packagingService = packagingService;   
    }

    public async Task<Domain.Entities.Application> CreateApplicationAsync(string userId, Domain.Entities.Application application)
    {
        application.UserId = userId;
        await _applicationRepository.CreateApplicationAsync(application);
        return application;
    }

    public async Task<Domain.Entities.Application> GetApplicationDetailsAsync(string applicationId) =>
         await _applicationRepository.GetApplicationByIdAsync(applicationId);
    public async Task<List<Domain.Entities.Application>> GetApplicationsByUserAsync(string userId)=>
         await _applicationRepository.GetApplicationsByUserIdAsync(userId);
    public async Task<Domain.Entities.Application> UpdateApplicationAsync(Domain.Entities.Application application)
    {
        //  business logic ...

        await _applicationRepository.UpdateApplicationAsync(application);
        return application;
    }

    public async Task DeleteApplicationAsync(string applicationId)
    {
        await _applicationRepository.DeleteApplicationAsync(applicationId);
    }

}