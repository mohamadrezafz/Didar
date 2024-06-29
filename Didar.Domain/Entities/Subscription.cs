
using Didar.Domain.Common;
using Didar.Domain.Enums;

namespace Didar.Domain.Entities;

public class Subscription : BaseEntity
{
    public SubscriptionPlan Plan { get; set; }
}
