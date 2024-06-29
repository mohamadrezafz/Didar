using Didar.Domain.Entities;
namespace Didar.Application.Interfaces.Repositories;

public interface IApplicationRepository
{
    Task<Didar.Domain.Entities.Application> CreateApplicationAsync(Didar.Domain.Entities.Application application);
    Task<Didar.Domain.Entities.Application> GetApplicationByIdAsync(string applicationId);
    Task<List<Didar.Domain.Entities.Application>> GetApplicationsByUserIdAsync(string userId);
    Task<Didar.Domain.Entities.Application> UpdateApplicationAsync(Didar.Domain.Entities.Application application);
    Task DeleteApplicationAsync(string applicationId);
}
