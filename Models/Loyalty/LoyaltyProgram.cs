using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.Loyalty
{
    [DataContract]
    public class LoyaltyProgram
    {
        /// <summary>
        /// Marketing name for the program
        /// </summary>
        /// <value>Marketing name for the program</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Boolean that determines whether a program is enabled
        /// </summary>
        /// <value>Boolean that determines whether a program is enabled</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// UUID for program
        /// </summary>
        /// <value>UUID for program</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Date in UTC that a program was created
        /// </summary>
        /// <value>Date in UTC that a program was created</value>
        [DataMember(Name = "createDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createDate")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date in UTC that a program was modified
        /// </summary>
        /// <value>Date in UTC that a program was modified</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// User ID of program creator (admin)
        /// </summary>
        /// <value>User ID of program creator (admin)</value>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// User facing terms and conditions for the program (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the program (localized)</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public List<Localization> Title { get; set; }

        /// <summary>
        /// User facing terms and conditions for the program (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the program (localized)</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public List<Localization> Description { get; set; }

        /// <summary>
        /// User facing terms and conditions for the program (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the program (localized)</value>
        [DataMember(Name = "terms", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "terms")]
        public List<Localization> Terms { get; set; }

        /// <summary>
        /// User facing terms and conditions for the program (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the program (localized)</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageUrl")]
        public List<LocalizationImage> ImageUrl { get; set; }

        /// <summary>
        /// User facing terms and conditions for the program (localized)
        /// </summary>
        /// <value>User facing terms and conditions for the program (localized)</value>
        [DataMember(Name = "termsUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "termsUrl")]
        public List<Localization> TermsUrl { get; set; }

        /// <summary>
        /// User facing frequently asked questions for the program (localized)
        /// </summary>
        /// <value>User facing frequently asked questions for the program (localized)</value>
        [DataMember(Name = "faq", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "faq")]
        public List<Localization> Faq { get; set; }

        /// <summary>
        /// Date program starts
        /// </summary>
        /// <value>Date program starts</value>
        [DataMember(Name = "availabilityStart", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "availabilityStart")]
        public DateTime? AvailabilityStart { get; set; }

        /// <summary>
        /// Date program ends
        /// </summary>
        /// <value>Date program ends</value>
        [DataMember(Name = "availabilityEnd", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "availabilityEnd")]
        public DateTime? AvailabilityEnd { get; set; }

        /// <summary>
        /// Transactions - points are earned per transaction, Spend - points are earned per subtotal dollar, Products - points are earned per qualifying product
        /// </summary>
        /// <value>Transactions - points are earned per transaction, Spend - points are earned per subtotal dollar, Products - points are earned per qualifying product</value>
        [DataMember(Name = "earningBasis", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "earningBasis")]
        public string EarningBasis { get; set; }

        /// <summary>
        /// Number of dollars for a transaction to be eligible for points
        /// </summary>
        /// <value>Number of dollars for a transaction to be eligible for points</value>
        [DataMember(Name = "eligibleTransactionMinimum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eligibleTransactionMinimum")]
        public decimal? EligibleTransactionMinimum { get; set; }

        /// <summary>
        /// List of SKUs eligible for points
        /// </summary>
        /// <value>List of SKUs eligible for points</value>
        [DataMember(Name = "eligibleProducts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eligibleProducts")]
        public List<string> EligibleProducts { get; set; }

        /// <summary>
        /// Finite - point balance reaches maximum, auto-redeems for reward, and resets, Infinite - point balance has no maximum
        /// </summary>
        /// <value>Finite - point balance reaches maximum, auto-redeems for reward, and resets, Infinite - point balance has no maximum</value>
        [DataMember(Name = "accumulationLimit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accumulationLimit")]
        public string AccumulationLimit { get; set; }

        /// <summary>
        /// Maximum point balance for auto-redemption for a finite program
        /// </summary>
        /// <value>Maximum point balance for auto-redemption for a finite program</value>
        [DataMember(Name = "finiteAccumulationMaximum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "finiteAccumulationMaximum")]
        public int? FiniteAccumulationMaximum { get; set; }

        /// <summary>
        /// ID of reward for a finite program
        /// </summary>
        /// <value>ID of reward for a finite program</value>
        [DataMember(Name = "finiteAccumulationReward", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "finiteAccumulationReward")]
        public string FiniteAccumulationReward { get; set; }

        /// <summary>
        /// Maximum number of points that can be earned in one day
        /// </summary>
        /// <value>Maximum number of points that can be earned in one day</value>
        [DataMember(Name = "dailyMaximum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dailyMaximum")]
        public int? DailyMaximum { get; set; }

        /// <summary>
        /// Number of minutes between points earned being posted and being available for redemption
        /// </summary>
        /// <value>Number of minutes between points earned being posted and being available for redemption</value>
        [DataMember(Name = "earningDelay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "earningDelay")]
        public int? EarningDelay { get; set; }

        /// <summary>
        /// Number of days between points being earned and points expiring
        /// </summary>
        /// <value>Number of days between points being earned and points expiring</value>
        [DataMember(Name = "pointsExpiration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pointsExpiration")]
        public int? PointsExpiration { get; set; }

        /// <summary>
        /// Number of points to redeem
        /// </summary>
        /// <value>Number of points to redeem</value>
        [DataMember(Name = "pointsRedemptionRatePoints", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pointsRedemptionRatePoints")]
        public int? PointsRedemptionRatePoints { get; set; }

        /// <summary>
        /// Number of dollars to discount
        /// </summary>
        /// <value>Number of dollars to discount</value>
        [DataMember(Name = "pointsRedemptionRateDollars", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pointsRedemptionRateDollars")]
        public decimal? PointsRedemptionRateDollars { get; set; }

        /// <summary>
        /// List of SKUs ineligible for points
        /// </summary>
        /// <value>List of SKUs ineligible for points</value>
        [DataMember(Name = "excludedProducts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "excludedProducts")]
        public List<string> ExcludedProducts { get; set; }

        /// <summary>
        /// Gets or Sets EligibleStores
        /// </summary>
        [DataMember(Name = "eligibleStores", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eligibleStores")]
        public LoyaltyEligibleStores EligibleStores { get; set; }

        /// <summary>
        /// Gets or Sets EligibleTerritories
        /// </summary>
        [DataMember(Name = "eligibleTerritories", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eligibleTerritories")]
        public LoyaltyEligibleStores EligibleTerritories { get; set; }

        /// <summary>
        /// Boolean that determines whether a program requires a user opt-in to process
        /// </summary>
        /// <value>Boolean that determines whether a program requires a user opt-in to process</value>
        [DataMember(Name = "requireOptin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requireOptin")]
        public bool? RequireOptin { get; set; }
    }
}
