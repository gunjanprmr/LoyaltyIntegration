using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoyaltyIntegration.Models.LoyaltyUsers
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserPoints : List<UserPoint>
    {
    }
}