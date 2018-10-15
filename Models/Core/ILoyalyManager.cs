using LoyaltyIntegration.Models.Loyalty;
using LoyaltyIntegration.Models.LoyaltyRewards;
using LoyaltyIntegration.Models.LoyaltyTiers;

namespace LoyaltyIntegration.Models.Core
{
    public interface ILoyalyManager
    {
        LoyaltyPrograms GetAllLoyalties();
        LoyaltyProgram GetLoyaltyById(string loyaltyId);
        LoyaltyProgram CreateLoyalty(LoyaltyProgram loyaltyRequest);
        LoyaltyProgram UpdateLoyaltyById(LoyaltyProgram loyaltyRequest);

        Tiers GetAllTiers(string loyaltyId);
        Tier GetTierById(string loyaltyId, string tierId);
        Tier CreateTier(Tier tierRequest);
        Tier UpdateTierById(Tier tierRequest);

        Rewards GetAllRewards(string loyaltyId);
        Reward GetRewardById(string loyaltyId, string rewardId);
        Reward CreateReward(Reward rewardRequest);
        Reward UpdateRewardById(Reward rewardRequest);
    }
}