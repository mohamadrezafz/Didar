using Didar.Domain.Entities;

namespace Didar.Application.Interfaces.Services;

public interface ISubscriptionService
{
    Task<Subscription> GetSubscriptionByUserIdAsync(string userId);
}