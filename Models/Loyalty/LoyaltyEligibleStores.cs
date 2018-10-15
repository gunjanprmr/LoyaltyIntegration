using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.Loyalty
{
    [DataContract]
    public class LoyaltyEligibleStores
    {
        /// <summary>
        /// Include = true, Exclude = false to say whether these items are included or excluded
        /// </summary>
        /// <value>Include = true, Exclude = false to say whether these items are included or excluded</value>
        [DataMember(Name = "inclusive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inclusive")]
        public bool? Inclusive { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<string> Stores { get; set; }
    }
}
