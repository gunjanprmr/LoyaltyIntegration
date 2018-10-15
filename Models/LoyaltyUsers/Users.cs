using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyUsers
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Users
    {
        /// <summary>
        ///     Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        ///     Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }

        /// <summary>
        ///     Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }

        /// <summary>
        ///     Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public User Items { get; set; }
    }
}