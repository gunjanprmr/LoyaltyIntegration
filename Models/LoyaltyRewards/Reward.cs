using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using LoyaltyIntegration.Models.Loyalty;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyRewards
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Reward
    {
        /// <summary>
        ///     Marketing name for the reward
        /// </summary>
        /// <value>Marketing name for the reward</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Boolean that determines whether a reward is enabled
        /// </summary>
        /// <value>Boolean that determines whether a reward is enabled</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///     UUID for program
        /// </summary>
        /// <value>UUID for program</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Parent program ID
        /// </summary>
        /// <value>Parent program ID</value>
        [DataMember(Name = "programId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "programId")]
        public string ProgramId { get; set; }

        /// <summary>
        ///     Date in UTC that a reward was created
        /// </summary>
        /// <value>Date in UTC that a reward was created</value>
        [DataMember(Name = "createDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createDate")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        ///     Date in UTC that a reward was modified
        /// </summary>
        /// <value>Date in UTC that a reward was modified</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        ///     User ID of reward creator (admin)
        /// </summary>
        /// <value>User ID of reward creator (admin)</value>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the reward (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the reward (localized)</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public List<Localization> Title { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the reward (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the reward (localized)</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public List<Localization> Description { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the reward (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the reward (localized)</value>
        [DataMember(Name = "terms", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terms")]
        public List<Localization> Terms { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the reward (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the reward (localized)</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageUrl")]
        public List<LocalizationImage> ImageUrl { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the reward (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the reward (localized)</value>
        [DataMember(Name = "termsUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "termsUrl")]
        public List<Localization> TermsUrl { get; set; }

        /// <summary>
        ///     Number of points to be redeemed to purchase reward
        /// </summary>
        /// <value>Number of points to be redeemed to purchase reward</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }

        /// <summary>
        ///     List of product SKUs eligible to redeem reward
        /// </summary>
        /// <value>List of product SKUs eligible to redeem reward</value>
        [DataMember(Name = "products", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "products")]
        public List<RewardProducts> Products { get; set; }

        /// <summary>
        ///     External Code used by POS Mapping system
        /// </summary>
        /// <value>External Code used by POS Mapping system</value>
        [DataMember(Name = "externalCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "externalCode")]
        public string ExternalCode { get; set; }

        /// <summary>
        ///     Number of days to use the reward
        /// </summary>
        /// <value>Number of days to use the reward</value>
        [DataMember(Name = "validityLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "validityLength")]
        public int? ValidityLength { get; set; }

        /// <summary>
        ///     IDs of tiers in which the reward can be obtained
        /// </summary>
        /// <value>IDs of tiers in which the reward can be obtained</value>
        [DataMember(Name = "tierIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tierIds")]
        public List<string> TierIds { get; set; }

        /// <summary>
        ///     Is this item able to be purchased
        /// </summary>
        /// <value>Is this item able to be purchased</value>
        [DataMember(Name = "purchaseable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "purchaseable")]
        public bool? Purchaseable { get; set; }

        /// <summary>
        ///     ID of transaction, event, customer service log event, redemption, offer, or bonus
        /// </summary>
        /// <value>ID of transaction, event, customer service log event, redemption, offer, or bonus</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }


        ///// <summary>
        ///// Get the string presentation of the object
        ///// </summary>
        ///// <returns>String presentation of the object</returns>
        //public override string ToString()  {
        //  var sb = new StringBuilder();
        //  sb.Append("class Reward {\n");
        //  sb.Append("  Name: ").Append(Name).Append("\n");
        //  sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        //  sb.Append("  Id: ").Append(Id).Append("\n");
        //  sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
        //  sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        //  sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        //  sb.Append("  Creator: ").Append(Creator).Append("\n");
        //  sb.Append("  Title: ").Append(Title).Append("\n");
        //  sb.Append("  Description: ").Append(Description).Append("\n");
        //  sb.Append("  Terms: ").Append(Terms).Append("\n");
        //  sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
        //  sb.Append("  TermsUrl: ").Append(TermsUrl).Append("\n");
        //  sb.Append("  Price: ").Append(Price).Append("\n");
        //  sb.Append("  Products: ").Append(Products).Append("\n");
        //  sb.Append("  ExternalCode: ").Append(ExternalCode).Append("\n");
        //  sb.Append("  ValidityLength: ").Append(ValidityLength).Append("\n");
        //  sb.Append("  TierIds: ").Append(TierIds).Append("\n");
        //  sb.Append("  Purchaseable: ").Append(Purchaseable).Append("\n");
        //  sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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