using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoyaltyIntegration.Models;
using LoyaltyIntegration.Models.Enum;
using LoyaltyIntegration.Models.Loyalty;
using LoyaltyIntegration.Models.LoyaltyRewards;
using LoyaltyIntegration.Models.LoyaltyTiers;

namespace LoyaltyIntegration.CommonObjects
{
    public interface IPlatformLoyaltyServiceApi
    {
        LoyaltyPrograms LoyaltyProgramsResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method);

        LoyaltyProgram LoyaltyProgramResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method);

        LoyaltyProgram LoyaltyProgramResponse(LoyaltyProgram loyaltyRequest,
            PlatformLoyaltyServiceRequestType requestType, string method);

        Tiers TiersResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method);

        Tier TierResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method);

        Tier TierResponse(Tier tierRequest, PlatformLoyaltyServiceRequestType requestType, 
            string method);

        Rewards RewardsResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method);

        Reward RewardResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method);

        Reward RewardResponse(Reward rewardRequest, PlatformLoyaltyServiceRequestType requestType, 
            string method);
    }
}
