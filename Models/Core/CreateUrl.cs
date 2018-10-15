using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using LoyaltyIntegration.CommonObjects;
using LoyaltyIntegration.Models.Enum;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Models.Core
{
    public class CreateUrl
    {
        /// <summary>
        ///     Create URL dynamically.
        /// </summary>
        public static UriBuilder GetUrl(PlatformLoyaltyServiceRequestType requestType, string loyaltyId = null, string id = null)
        {
            var uriBuilder = GetBaseUri();

            switch (requestType)
            {
                case PlatformLoyaltyServiceRequestType.AllLoyalties:
                case PlatformLoyaltyServiceRequestType.CreateLoyalty:
                    uriBuilder.Path += Constants.Loyalty;
                    break;
                case PlatformLoyaltyServiceRequestType.UpdateLoyaltyById:
                case PlatformLoyaltyServiceRequestType.GetLoyaltyById:
                    uriBuilder.Path += Constants.Loyalty + loyaltyId;
                    break;
                case PlatformLoyaltyServiceRequestType.AllTiers:
                case PlatformLoyaltyServiceRequestType.CreateTier:
                    uriBuilder.Path += Constants.Loyalty + loyaltyId + Constants.Tier;
                    break;
                case PlatformLoyaltyServiceRequestType.GetTierById:
                case PlatformLoyaltyServiceRequestType.UpdateTierById:
                    uriBuilder.Path += Constants.Loyalty + loyaltyId + Constants.Tier + id;
                    break;
                case PlatformLoyaltyServiceRequestType.AllRewards:
                case PlatformLoyaltyServiceRequestType.CreateReward:
                    uriBuilder.Path += Constants.Loyalty + loyaltyId + Constants.Reward;
                    break;
                case PlatformLoyaltyServiceRequestType.GetRewardById:
                case PlatformLoyaltyServiceRequestType.UpdateRewardById:
                    uriBuilder.Path += Constants.Loyalty + loyaltyId + Constants.Reward + id;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(requestType), requestType, null);
            }

            return uriBuilder;
        }

        private static UriBuilder GetBaseUri()
        {
            var url = ConfigurationManager.AppSettings["PlatformLoyaltyServiceURL"];
            var baseUri = WebApiApplication.BaseUriInstance ?? new Uri(url);
            var baseUriBuilder = new UriBuilder(baseUri);

            return baseUriBuilder;
        }
    }
}