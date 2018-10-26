using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using LoyaltyIntegration.Models;
using LoyaltyIntegration.Models.Core;
using LoyaltyIntegration.Models.Enum;
using LoyaltyIntegration.Models.Loyalty;
using LoyaltyIntegration.Models.LoyaltyRewards;
using LoyaltyIntegration.Models.LoyaltyTiers;
using LoyaltyIntegration.Models.LoyaltyUsers;
using Newtonsoft.Json;
using HttpClientFactory = LoyaltyIntegration.Framework.HttpClientFactory;

namespace LoyaltyIntegration.CommonObjects
{
    public class PlatformLoyaltyServiceApi : IPlatformLoyaltyServiceApi
    {
        #region Loyalty

        public LoyaltyPrograms LoyaltyProgramsResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method)
        {
            var response = HttpResponseMessage(requestType, commonRequest, method);

            var allTiers = response.IsSuccessStatusCode
                ? GenericResponse<LoyaltyPrograms>(requestType, response)
                : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);
            return allTiers;
        }

        public LoyaltyProgram LoyaltyProgramResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method)
        {
            var responseMessage = HttpResponseMessage(requestType, commonRequest, method);
            var loyaltyProgram = responseMessage.IsSuccessStatusCode
                ? GenericResponse<LoyaltyProgram>(requestType, responseMessage)
                : throw new Exception((int) responseMessage.StatusCode + "-" + responseMessage.StatusCode);

            return loyaltyProgram;
        }

        public LoyaltyProgram LoyaltyProgramResponse(LoyaltyProgram loyaltyRequest,
            PlatformLoyaltyServiceRequestType requestType, string method)
        {
            var commonRequest = new PlatformLoyaltyServiceRequest {Loyalty = loyaltyRequest};
            var loyaltyProgram = LoyaltyProgramResponse(requestType, commonRequest, method);
            return loyaltyProgram;
        }

        #endregion Loyalty

        #region Tier

        public Tiers TiersResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method)
        {
            var response = HttpResponseMessage(requestType, commonRequest, method);

            var allTiers = response.IsSuccessStatusCode
                ? GenericResponse<Tiers>(requestType, response)
                : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

            return allTiers;
        }

        public Tier TierResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method)
        {
            var responseMessage = HttpResponseMessage(requestType, commonRequest, method);
            var tier = responseMessage.IsSuccessStatusCode
                ? GenericResponse<Tier>(requestType, responseMessage)
                : throw new Exception((int) responseMessage.StatusCode + "-" + responseMessage.StatusCode);

            return tier;
        }

        public Tier TierResponse(Tier tierRequest, PlatformLoyaltyServiceRequestType requestType, string method)
        {
            var commonRequest = new PlatformLoyaltyServiceRequest {Tier = tierRequest};
            var tier = TierResponse(requestType, commonRequest, method);
            return tier;
        }

        #endregion Tier

        #region Reward

        public Rewards RewardsResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method)
        {
            var response = HttpResponseMessage(requestType, commonRequest, method);

            var allRewards = response.IsSuccessStatusCode
                ? GenericResponse<Rewards>(requestType, response)
                : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

            return allRewards;
        }

        public Reward RewardResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method)
        {
            var responseMessage = HttpResponseMessage(requestType, commonRequest, method);
            var reward = responseMessage.IsSuccessStatusCode
                ? GenericResponse<Reward>(requestType, responseMessage)
                : throw new Exception((int) responseMessage.StatusCode + "-" + responseMessage.StatusCode);

            return reward;
        }

        public Reward RewardResponse(Reward rewardRequest, PlatformLoyaltyServiceRequestType requestType, string method)
        {
            var commonRequest = new PlatformLoyaltyServiceRequest {Reward = rewardRequest};
            var reward = RewardResponse(requestType, commonRequest, method);
            return reward;
        }

        #endregion Reward

        #region User

        public Users UsersResponse(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest commonRequest, string method)
        {
            var response = HttpResponseMessage(requestType, commonRequest, method);

            var allUsers = response.IsSuccessStatusCode
                ? GenericResponse<Users>(requestType, response)
                : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);
            return allUsers;
        }

        #endregion User

        #region Common Objects

        private T GenericResponse<T>(PlatformLoyaltyServiceRequestType requestType,
            HttpResponseMessage httpResponseMessage)
        {
            var data = httpResponseMessage.Content.ReadAsStringAsync().Result;
            T genericType;

            switch (requestType)
            {
                case PlatformLoyaltyServiceRequestType.AllLoyalties:
                    genericType = (T) JsonConvert.DeserializeObject(data, typeof(LoyaltyPrograms));
                    break;
                case PlatformLoyaltyServiceRequestType.CreateLoyalty:
                case PlatformLoyaltyServiceRequestType.UpdateLoyaltyById:
                case PlatformLoyaltyServiceRequestType.GetLoyaltyById:
                    genericType = (T) JsonConvert.DeserializeObject(data, typeof(LoyaltyProgram));
                    break;
                case PlatformLoyaltyServiceRequestType.AllTiers:
                    genericType = (T) JsonConvert.DeserializeObject(data, typeof(Tiers));
                    break;
                case PlatformLoyaltyServiceRequestType.CreateTier:
                case PlatformLoyaltyServiceRequestType.UpdateTierById:
                case PlatformLoyaltyServiceRequestType.GetTierById:
                    genericType = (T) JsonConvert.DeserializeObject(data, typeof(Tier));
                    break;
                case PlatformLoyaltyServiceRequestType.AllRewards:
                    genericType = (T) JsonConvert.DeserializeObject(data, typeof(Rewards));
                    break;
                case PlatformLoyaltyServiceRequestType.CreateReward:
                case PlatformLoyaltyServiceRequestType.UpdateRewardById:
                case PlatformLoyaltyServiceRequestType.GetRewardById:
                    genericType = (T) JsonConvert.DeserializeObject(data, typeof(Reward));
                    break;
                case PlatformLoyaltyServiceRequestType.AllUsers:
                    genericType = (T) JsonConvert.DeserializeObject(data, typeof(Users));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(requestType), requestType, null);
            }

            return genericType;
        }

        private static HttpResponseMessage HttpResponseMessage(PlatformLoyaltyServiceRequestType requestType,
            PlatformLoyaltyServiceRequest request, string method)
        {
            UriBuilder uri;
            StringContent content = null;

            switch (requestType)
            {
                case PlatformLoyaltyServiceRequestType.AllLoyalties:
                    uri = CreateUrl.GetUrl(requestType);
                    break;
                case PlatformLoyaltyServiceRequestType.GetLoyaltyById:
                    uri = CreateUrl.GetUrl(requestType, request.Loyalty.Id);
                    break;
                case PlatformLoyaltyServiceRequestType.CreateLoyalty:
                    uri = CreateUrl.GetUrl(requestType);
                    content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Loyalty);
                    break;
                case PlatformLoyaltyServiceRequestType.UpdateLoyaltyById:
                    uri = CreateUrl.GetUrl(requestType, request.Loyalty.Id);
                    content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Loyalty);
                    break;
                case PlatformLoyaltyServiceRequestType.AllTiers:
                    uri = CreateUrl.GetUrl(requestType, request.Loyalty.Id);
                    break;
                case PlatformLoyaltyServiceRequestType.GetTierById:
                    uri = CreateUrl.GetUrl(requestType, request.Tier.ProgramId, request.Tier.Id);
                    break;
                case PlatformLoyaltyServiceRequestType.CreateTier:
                    uri = CreateUrl.GetUrl(requestType, request.Tier.ProgramId);
                    content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Tier);
                    break;
                case PlatformLoyaltyServiceRequestType.UpdateTierById:
                    uri = CreateUrl.GetUrl(requestType, request.Tier.ProgramId, request.Tier.Id);
                    content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Tier);
                    break;
                case PlatformLoyaltyServiceRequestType.AllRewards:
                    uri = CreateUrl.GetUrl(requestType, request.Loyalty.Id);
                    break;
                case PlatformLoyaltyServiceRequestType.GetRewardById:
                    uri = CreateUrl.GetUrl(requestType, request.Reward.ProgramId, request.Reward.Id);
                    break;
                case PlatformLoyaltyServiceRequestType.CreateReward:
                    uri = CreateUrl.GetUrl(requestType, request.Reward.ProgramId);
                    content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Reward);
                    break;
                case PlatformLoyaltyServiceRequestType.UpdateRewardById:
                    uri = CreateUrl.GetUrl(requestType, request.Reward.ProgramId, request.Reward.Id);
                    content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Reward);
                    break;
                case PlatformLoyaltyServiceRequestType.AllUsers:
                    uri = CreateUrl.GetUrl(requestType);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(requestType), requestType, null);
            }

            var responseMessage = HttpClientFactory.PerformRequest(method, uri, content, GetHttpClient());
            return responseMessage;
        }

        private static HttpClient GetHttpClient()
        {
            var customHeaders = GetDefaultHeadersForHttpClient();
            var httpClient = HttpClientFactory.GetClient(customHeaders);
            return httpClient;
        }

        private static Dictionary<string, string> GetDefaultHeadersForHttpClient()
        {
            var environment = ConfigurationManager.AppSettings["PlatformLoyaltyServiceEnvironment"];
            var apiKey = ConfigurationManager.AppSettings["PlatformLoyaltyServiceKey"];
            var conceptKey = ConfigurationManager.AppSettings["PlatformLoyaltyServiceTenant"];

            var customHeaders = new Dictionary<string, string>
            {
                {Constants.Environment, environment},
                {Constants.ApiKey, apiKey},
                {Constants.ConceptKey, conceptKey}
            };

            return customHeaders;
        }

        #endregion Common Objects
    }
}