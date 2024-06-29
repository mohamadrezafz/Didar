using Didar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didar.Application.Interfaces.Repositories;

public interface ISubscriptionRepository
{
    Task<Subscription> GetSubscriptionByUserIdAsync(string userId);
}
