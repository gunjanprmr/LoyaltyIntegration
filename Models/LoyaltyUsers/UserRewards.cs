using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoyaltyIntegration.Models.LoyaltyUsers
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserRewards : List<UserReward>
    {
    }
}