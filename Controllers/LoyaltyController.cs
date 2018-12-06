using LoyaltyIntegration.Models.Core;
using LoyaltyIntegration.Models.Loyalty;
using LoyaltyIntegration.Models.LoyaltyRewards;
using LoyaltyIntegration.Models.LoyaltyTiers;
using LoyaltyIntegration.Models.LoyaltyUsers;
using System.Web.Http;

namespace LoyaltyIntegration.Controllers
{
    /// <inheritdoc />
    public class LoyaltyController : ApiController
    {
        private readonly LoyaltyManager _loyaltyManager;

        /// <inheritdoc />
        public LoyaltyController()
        {
            _loyaltyManager = new LoyaltyManager();
        }

        /// <summary>
        /// Retrieves all loyalty programs.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("programs")]
        public LoyaltyPrograms GetAllLoyalties()
        {
            var getAllLoyalties = _loyaltyManager.GetAllLoyalties();
            return getAllLoyalties;
        }

        /// <summary>
        /// Get specific loyalty program.
        /// </summary>
        /// <param name="loyaltyId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("programs/{loyaltyId}")]
        public LoyaltyProgram GetLoyaltyById(string loyaltyId)
        {
            var getLoyaltyById = _loyaltyManager.GetLoyaltyById(loyaltyId);
            return getLoyaltyById;
        }

        /// <summary>
        /// Create new loyalty program.
        /// </summary>
        /// <param name="loyaltyRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("programs")]
        public LoyaltyProgram CreateLoyalty([FromBody] LoyaltyProgram loyaltyRequest)
        {
            var savedLoyalty = _loyaltyManager.CreateLoyalty(loyaltyRequest);
            return savedLoyalty;
        }

        /// <summary>
        /// Update specific loyalty program.
        /// </summary>
        /// <param name="loyaltyRequest"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("programs/{loyaltyId}")]
        public LoyaltyProgram UpdateLoyaltyById([FromBody] LoyaltyProgram loyaltyRequest)
        {
            var updatedLoyalty = _loyaltyManager.UpdateLoyaltyById(loyaltyRequest);
            return updatedLoyalty;
        }

        /// <summary>
        /// Get all tiers for a loyalty program.
        /// </summary>
        /// <param name="loyaltyId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("programs/{loyaltyId}/tiers")]
        public Tiers GetAllTiersForSpecificLoyalty(string loyaltyId)
        {
            var allTiers = _loyaltyManager.GetAllTiers(loyaltyId);
            return allTiers;
        }

        /// <summary>
        /// Get specific tier for a loyalty program.
        /// </summary>
        /// <param name="loyaltyId"></param>
        /// <param name="tierId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("programs/{loyaltyId}/tiers/{tierId}")]
        public Tier GetTierById(string loyaltyId, string tierId)
        {
            var tier = _loyaltyManager.GetTierById(loyaltyId, tierId);
            return tier;
        }

        /// <summary>
        /// Create new tier for a loyalty program.
        /// </summary>
        /// <param name="tierRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("programs/{loyaltyId}/tiers")]
        public Tier CreateTier(Tier tierRequest)
        {
            var createdTier = _loyaltyManager.CreateTier(tierRequest);
            return createdTier;
        }

        /// <summary>
        /// Update new tier for a loyalty program.
        /// </summary>
        /// <param name="tierRequest"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("programs/{loyaltyId}/tiers/{tierId}")]
        public Tier UpdateTierById(Tier tierRequest)
        {
            var updatedTier = _loyaltyManager.UpdateTierById(tierRequest);
            return updatedTier;
        }

        /// <summary>
        /// Get all rewards for a loyalty program.
        /// </summary>
        /// <param name="loyaltyId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("programs/{loyaltyId}/rewards")]
        public Rewards GetAllRewards(string loyaltyId)
        {
            var allRewards = _loyaltyManager.GetAllRewards(loyaltyId);
            return allRewards;
        }

        /// <summary>
        /// Get specific reward for a loyalty program.
        /// </summary>
        /// <param name="loyaltyId"></param>
        /// <param name="rewardId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("programs/{loyaltyId}/rewards/{rewardId}")]
        public Reward GetRewardById(string loyaltyId, string rewardId)
        {
            var getRewardById = _loyaltyManager.GetRewardById(loyaltyId, rewardId);
            return getRewardById;
        }

        /// <summary>
        /// Create new reward for a loyalty program.
        /// </summary>
        /// <param name="rewardRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("programs/{loyaltyId}/rewards")]
        public Reward CreateReward(Reward rewardRequest)
        {
            var createdReward = _loyaltyManager.CreateReward(rewardRequest);
            return createdReward;
        }

        /// <summary>
        /// Update new reward for a loyalty program.
        /// </summary>
        /// <param name="rewardRequest"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("programs/{loyaltyId}/rewards/{rewardId}")]
        public Reward UpdateRewardById(Reward rewardRequest)
        {
            var updatedRewardById = _loyaltyManager.UpdateRewardById(rewardRequest);
            return updatedRewardById;
        }

        /// <summary>
        /// Get all users.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("users/{page:int?}/{size:int?}")]
        public Users GetUsers([FromUri]int? page = null, [FromUri]int? size = null)
        {
            var allUsers = _loyaltyManager.GetUsers();
            return allUsers;
        }
    }
}