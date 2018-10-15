using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyUsers
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class User
    {
        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets Programs
        /// </summary>
        [DataMember(Name = "programs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "programs")]
        public List<UserPrograms> Programs { get; set; }

        /// <summary>
        ///     Gets or Sets Optins
        /// </summary>
        [DataMember(Name = "optins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "optins")]
        public List<ProgramOptin> Optins { get; set; }
    }
}