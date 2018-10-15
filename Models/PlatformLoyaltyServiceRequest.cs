using LoyaltyIntegration.Models.Loyalty;
using LoyaltyIntegration.Models.LoyaltyRewards;
using LoyaltyIntegration.Models.LoyaltyTiers;

namespace LoyaltyIntegration.Models
{
    public class PlatformLoyaltyServiceRequest
    {
        public LoyaltyProgram Loyalty { get; set; }
        public Tier Tier { get; set; }
        public Reward Reward { get; set; }
    }
}