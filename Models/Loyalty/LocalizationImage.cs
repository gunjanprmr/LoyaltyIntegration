using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.Loyalty
{
    [DataContract]
    public class LocalizationImage
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

        /// <summary>
        /// Description of image size
        /// </summary>
        /// <value>Description of image size</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }
    }
}
