using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyRewards
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class RewardProducts
    {
        /// <summary>
        ///     Ordered Item Identifier
        /// </summary>
        /// <value>Ordered Item Identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Ordered Item Alternate Identifier (used if secondary identification is required)
        /// </summary>
        /// <value>Ordered Item Alternate Identifier (used if secondary identification is required)</value>
        [DataMember(Name = "altId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "altId")]
        public string AltId { get; set; }


        ///// <summary>
        ///// Get the string presentation of the object
        ///// </summary>
        ///// <returns>String presentation of the object</returns>
        //public override string ToString()  {
        //  var sb = new StringBuilder();
        //  sb.Append("class RewardProducts {\n");
        //  sb.Append("  Id: ").Append(Id).Append("\n");
        //  sb.Append("  AltId: ").Append(AltId).Append("\n");
        //  sb.Append("}\n");
        //  return sb.ToString();
        //}

        ///// <summary>
        ///// Get the JSON string presentation of the object
        ///// </summary>
        ///// <returns>JSON string presentation of the object</returns>
        //public string ToJson() {
        //  return JsonConvert.SerializeObject(this, Formatting.Indented);
        //}
    }
}