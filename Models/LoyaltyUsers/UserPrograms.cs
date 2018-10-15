using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyUsers
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserPrograms
    {
        /// <summary>
        ///     Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "balance")]
        public int? Balance { get; set; }

        /// <summary>
        ///     Gets or Sets Earnings
        /// </summary>
        [DataMember(Name = "earnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "earnings")]
        public List<UserEarnings> Earnings { get; set; }

        /// <summary>
        ///     Gets or Sets Offers
        /// </summary>
        [DataMember(Name = "offers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offers")]
        public List<UserEarnings> Offers { get; set; }

        /// <summary>
        ///     Gets or Sets PointsToNextReward
        /// </summary>
        [DataMember(Name = "pointsToNextReward", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pointsToNextReward")]
        public int? PointsToNextReward { get; set; }

        /// <summary>
        ///     Gets or Sets ProgramId
        /// </summary>
        [DataMember(Name = "programId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "programId")]
        public string ProgramId { get; set; }

        /// <summary>
        ///     Gets or Sets TierId
        /// </summary>
        [DataMember(Name = "tierId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tierId")]
        public string TierId { get; set; }

        /// <summary>
        ///     Gets or Sets Optin
        /// </summary>
        [DataMember(Name = "optin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "optin")]
        public bool? Optin { get; set; }

        /// <summary>
        ///     Gets or Sets Points
        /// </summary>
        [DataMember(Name = "points", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "points")]
        public List<UserPoint> Points { get; set; }

        /// <summary>
        ///     Gets or Sets Rewards
        /// </summary>
        [DataMember(Name = "rewards", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rewards")]
        public List<UserReward> Rewards { get; set; }
    }
}