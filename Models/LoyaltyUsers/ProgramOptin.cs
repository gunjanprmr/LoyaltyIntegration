using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyUsers
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ProgramOptin
    {
        /// <summary>
        ///     Program ID
        /// </summary>
        /// <value>Program ID</value>
        [DataMember(Name = "programId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "programId")]
        public string ProgramId { get; set; }

        /// <summary>
        ///     True or False if user is opted in or not
        /// </summary>
        /// <value>True or False if user is opted in or not</value>
        [DataMember(Name = "optin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "optin")]
        public bool? Optin { get; set; }
    }
}