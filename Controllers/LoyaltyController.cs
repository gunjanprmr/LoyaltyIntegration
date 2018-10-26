using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using LoyaltyIntegration.Models.Core;
using LoyaltyIntegration.Models.Loyalty;
using LoyaltyIntegration.Models.LoyaltyRewards;
using LoyaltyIntegration.Models.LoyaltyTiers;
using LoyaltyIntegration.Models.LoyaltyUsers;

namespace LoyaltyIntegration.Controllers
{
    public class LoyaltyController : ApiController
    {
        private readonly LoyaltyManager _loyaltyManager;

        public LoyaltyController()
        {
            _loyaltyManager = new LoyaltyManager();
        }

        [HttpGet]
        [Route("programs")]
        public LoyaltyPrograms GetAllLoyalties()
        {
            var getAllLoyalties = _loyaltyManager.GetAllLoyalties();
            return getAllLoyalties;
        }

        [HttpGet]
        [Route("programs/{loyaltyId}")]
        public LoyaltyProgram GetLoyaltyById(string loyaltyId)
        {
            var getLoyaltyById = _loyaltyManager.GetLoyaltyById(loyaltyId);
            return getLoyaltyById;
        }

        [HttpPost]
        [Route("programs")]
        public LoyaltyProgram CreateLoyalty([FromBody] LoyaltyProgram loyaltyRequest)
        {
            var savedLoyalty = _loyaltyManager.CreateLoyalty(loyaltyRequest);
            return savedLoyalty;
        }

        [HttpPut]
        [Route("programs/{loyaltyId}")]
        public LoyaltyProgram UpdateLoyaltyById([FromBody] LoyaltyProgram loyaltyRequest)
        {
            var updatedLoyalty = _loyaltyManager.UpdateLoyaltyById(loyaltyRequest);
            return updatedLoyalty;
        }

        [HttpGet]
        [Route("programs/{loyaltyId}/tiers")]
        public Tiers GetAllTiersForSpecificLoyalty(string loyaltyId)
        {
            var allTiers = _loyaltyManager.GetAllTiers(loyaltyId);
            return allTiers;
        }

        [HttpGet]
        [Route("programs/{loyaltyId}/tiers/{tierId}")]
        public Tier GetTierById(string loyaltyId, string tierId)
        {
            var tier = _loyaltyManager.GetTierById(loyaltyId, tierId);
            return tier;
        }

        [HttpPost]
        [Route("programs/{loyaltyId}/tiers")]
        public Tier CreateTier(Tier tierRequest)
        {
            var createdTier = _loyaltyManager.CreateTier(tierRequest);
            return createdTier;
        }

        [HttpPut]
        [Route("programs/{loyaltyId}/tiers/{tierId}")]
        public Tier UpdateTierById(Tier tierRequest)
        {
            var updatedTier = _loyaltyManager.UpdateTierById(tierRequest);
            return updatedTier;
        }

        [HttpGet]
        [Route("programs/{loyaltyId}/rewards")]
        public Rewards GetAllRewards(string loyaltyId)
        {
            var allRewards = _loyaltyManager.GetAllRewards(loyaltyId);
            return allRewards;
        }

        [HttpGet]
        [Route("programs/{loyaltyId}/rewards/{rewardId}")]
        public Reward GetRewardById(string loyaltyId, string rewardId)
        {
            var getRewardById = _loyaltyManager.GetRewardById(loyaltyId, rewardId);
            return getRewardById;
        }

        [HttpPost]
        [Route("programs/{loyaltyId}/rewards")]
        public Reward CreateReward(Reward rewardRequest)
        {
            var createdReward = _loyaltyManager.CreateReward(rewardRequest);
            return createdReward;
        }

        [HttpPut]
        [Route("programs/{loyaltyId}/rewards/{rewardId}")]
        public Reward UpdateRewardById(Reward rewardRequest)
        {
            var updatedRewardById = _loyaltyManager.UpdateRewardById(rewardRequest);
            return updatedRewardById;
        }

        [HttpGet]
        [Route("users/{page:int?}/{size:int?}")]
        public Users GetUsers([FromUri]int? page = null, [FromUri]int? size = null)
        {
            var allUsers = _loyaltyManager.GetUsers();
            return allUsers;
        }
    }
}