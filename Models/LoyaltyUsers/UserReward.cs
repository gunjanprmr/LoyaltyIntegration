using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyUsers
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserReward
    {
        /// <summary>
        ///     UUID for entry
        /// </summary>
        /// <value>UUID for entry</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     UUID for reward
        /// </summary>
        /// <value>UUID for reward</value>
        [DataMember(Name = "rewardId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rewardId")]
        public string RewardId { get; set; }

        /// <summary>
        ///     UUID for program
        /// </summary>
        /// <value>UUID for program</value>
        [DataMember(Name = "programId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "programId")]
        public string ProgramId { get; set; }

        /// <summary>
        ///     UUID for tier
        /// </summary>
        /// <value>UUID for tier</value>
        [DataMember(Name = "tierId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tierId")]
        public string TierId { get; set; }

        /// <summary>
        ///     Reward status
        /// </summary>
        /// <value>Reward status</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        ///     Time when reward was awarded
        /// </summary>
        /// <value>Time when reward was awarded</value>
        [DataMember(Name = "awardedOn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awardedOn")]
        public DateTime? AwardedOn { get; set; }

        /// <summary>
        ///     Time when reward was redeemed
        /// </summary>
        /// <value>Time when reward was redeemed</value>
        [DataMember(Name = "redeemedOn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redeemedOn")]
        public DateTime? RedeemedOn { get; set; }

        /// <summary>
        ///     Time when reward expired
        /// </summary>
        /// <value>Time when reward expired</value>
        [DataMember(Name = "expiredOn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expiredOn")]
        public DateTime? ExpiredOn { get; set; }

        /// <summary>
        ///     Time when reward expires
        /// </summary>
        /// <value>Time when reward expires</value>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expires")]
        public DateTime? Expires { get; set; }

        /// <summary>
        ///     ID of transaction, event, customer service log event, redemption, offer, or bonus
        /// </summary>
        /// <value>ID of transaction, event, customer service log event, redemption, offer, or bonus</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }
    }
}