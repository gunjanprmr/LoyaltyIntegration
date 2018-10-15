using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyUsers
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserPoint
    {
        /// <summary>
        ///     UUID for entry
        /// </summary>
        /// <value>UUID for entry</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

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
        ///     Number of points added or subtracted
        /// </summary>
        /// <value>Number of points added or subtracted</value>
        [DataMember(Name = "points", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "points")]
        public int? Points { get; set; }

        /// <summary>
        ///     In the case of a transaction for which an offer or bonus concurrently awards points, each addition of points is
        ///     listed separately
        /// </summary>
        /// <value>
        ///     In the case of a transaction for which an offer or bonus concurrently awards points, each addition of points is
        ///     listed separately
        /// </value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     Optional explanation of type
        /// </summary>
        /// <value>Optional explanation of type</value>
        [DataMember(Name = "typeDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "typeDescription")]
        public string TypeDescription { get; set; }

        /// <summary>
        ///     ID of transaction, event, customer service log event, redemption, offer, or bonus
        /// </summary>
        /// <value>ID of transaction, event, customer service log event, redemption, offer, or bonus</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        ///     Time when points were added or subtracted
        /// </summary>
        /// <value>Time when points were added or subtracted</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }

        /// <summary>
        ///     Time when points are available. Applies to added points only
        /// </summary>
        /// <value>Time when points are available. Applies to added points only</value>
        [DataMember(Name = "pendingUntil", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pendingUntil")]
        public DateTime? PendingUntil { get; set; }

        /// <summary>
        ///     Time when points expire. Applies to added points only
        /// </summary>
        /// <value>Time when points expire. Applies to added points only</value>
        [DataMember(Name = "timeExpires", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeExpires")]
        public DateTime? TimeExpires { get; set; }
    }
}