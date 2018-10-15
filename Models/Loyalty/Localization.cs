using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace LoyaltyIntegration.Models.Loyalty
{
    [DataContract]
    public class Localization
    {
        /// <summary>
        /// Culture code (en-US)
        /// </summary>
        /// <value>Culture code (en-US)</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Localized string
        /// </summary>
        /// <value>Localized string</value>
        [DataMember(Name = "translation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "translation")]
        public string Translation { get; set; }
    }
}
