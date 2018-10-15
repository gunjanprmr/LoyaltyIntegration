using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using LoyaltyIntegration.Models.Loyalty;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.LoyaltyTiers
{
    [DataContract]
    public class Tier
    {
        /// <summary>
        ///     Marketing name for the tier
        /// </summary>
        /// <value>Marketing name for the tier</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Boolean that determines whether a tier is enabled
        /// </summary>
        /// <value>Boolean that determines whether a tier is enabled</value>
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
        ///     Date in UTC that a tier was created
        /// </summary>
        /// <value>Date in UTC that a tier was created</value>
        [DataMember(Name = "createDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createDate")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        ///     Date in UTC that a tier was modified
        /// </summary>
        /// <value>Date in UTC that a tier was modified</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        ///     User ID of tier creator (admin)
        /// </summary>
        /// <value>User ID of tier creator (admin)</value>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the tier (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the tier (localized)</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public List<Localization> Title { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the tier (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the tier (localized)</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public List<Localization> Description { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the tier (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the tier (localized)</value>
        [DataMember(Name = "terms", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terms")]
        public List<Localization> Terms { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the tier (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the tier (localized)</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageUrl")]
        public List<LocalizationImage> ImageUrl { get; set; }

        /// <summary>
        ///     User facing terms and conditions for the tier (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the tier (localized)</value>
        [DataMember(Name = "termsUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "termsUrl")]
        public List<Localization> TermsUrl { get; set; }

        /// <summary>
        ///     Number of points to qualify for the tier
        /// </summary>
        /// <value>Number of points to qualify for the tier</value>
        [DataMember(Name = "minimum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minimum")]
        public int? Minimum { get; set; }

        /// <summary>
        ///     Rolling - last n days, Anniversary - n days from tier qualification date, Calendar - calendar year is qualification
        ///     period
        /// </summary>
        /// <value>
        ///     Rolling - last n days, Anniversary - n days from tier qualification date, Calendar - calendar year is
        ///     qualification period
        /// </value>
        [DataMember(Name = "periodType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "periodType")]
        public string PeriodType { get; set; }

        /// <summary>
        ///     Number of days to earn qualifying points
        /// </summary>
        /// <value>Number of days to earn qualifying points</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "period")]
        public int? Period { get; set; }

        /// <summary>
        ///     Number of points to earn from qualifying transaction (decimal allowed)
        /// </summary>
        /// <value>Number of points to earn from qualifying transaction (decimal allowed)</value>
        [DataMember(Name = "points", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "points")]
        public decimal? Points { get; set; }

        /// <summary>
        ///     Number of qualifying transaction bases that earn points
        /// </summary>
        /// <value>Number of qualifying transaction bases that earn points</value>
        [DataMember(Name = "increment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "increment")]
        public decimal? Increment { get; set; }

        /// <summary>
        ///     Rounding method for calculating points
        /// </summary>
        /// <value>Rounding method for calculating points</value>
        [DataMember(Name = "roundingRules", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roundingRules")]
        public string RoundingRules { get; set; }


        ///// <summary>
        /////     Get the string presentation of the object
        ///// </summary>
        ///// <returns>String presentation of the object</returns>
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("class Tier {\n");
        //    sb.Append("  Name: ").Append(Name).Append("\n");
        //    sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        //    sb.Append("  Id: ").Append(Id).Append("\n");
        //    sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
        //    sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        //    sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        //    sb.Append("  Creator: ").Append(Creator).Append("\n");
        //    sb.Append("  Title: ").Append(Title).Append("\n");
        //    sb.Append("  Description: ").Append(Description).Append("\n");
        //    sb.Append("  Terms: ").Append(Terms).Append("\n");
        //    sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
        //    sb.Append("  TermsUrl: ").Append(TermsUrl).Append("\n");
        //    sb.Append("  Minimum: ").Append(Minimum).Append("\n");
        //    sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
        //    sb.Append("  Period: ").Append(Period).Append("\n");
        //    sb.Append("  Points: ").Append(Points).Append("\n");
        //    sb.Append("  Increment: ").Append(Increment).Append("\n");
        //    sb.Append("  RoundingRules: ").Append(RoundingRules).Append("\n");
        //    sb.Append("}\n");
        //    return sb.ToString();
        //}

        ///// <summary>
        /////     Get the JSON string presentation of the object
        ///// </summary>
        ///// <returns>JSON string presentation of the object</returns>
        //public string ToJson()
        //{
        //    return JsonConvert.SerializeObject(this, Formatting.Indented);
        //}
    }
}

