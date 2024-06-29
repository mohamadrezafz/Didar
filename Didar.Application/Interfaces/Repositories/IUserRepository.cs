using Didar.Domain.Entities;

namespace Didar.Application.Interfaces.Repositories;

public interface IUserRepository
{
    Task<bool> HasFacilityAccessAsync(string userId, string facilityName);
}
