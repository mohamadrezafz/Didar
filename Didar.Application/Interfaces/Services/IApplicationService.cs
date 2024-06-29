namespace Didar.Application.Interfaces.Services;

public interface IApplicationService
{
    Task<Domain.Entities.Application> CreateApplicationAsync(string userId, Domain.Entities.Application application);
    Task<Domain.Entities.Application> GetApplicationDetailsAsync(string applicationId);
    Task<List<Domain.Entities.Application>> GetApplicationsByUserAsync(string userId);
    Task<Domain.Entities.Application> UpdateApplicationAsync(Domain.Entities.Application application);
    Task DeleteApplicationAsync(string applicationId);
}
