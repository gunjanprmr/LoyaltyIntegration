using LoyaltyIntegration.CommonObjects;
using LoyaltyIntegration.Models.Enum;
using LoyaltyIntegration.Models.Loyalty;
using LoyaltyIntegration.Models.LoyaltyRewards;
using LoyaltyIntegration.Models.LoyaltyTiers;

namespace LoyaltyIntegration.Models.Core
{
    public class LoyaltyManager : ILoyalyManager
    {
        #region 1st Approach

        //#region Loyalty

        //public LoyaltyPrograms GetAllLoyalties()
        //{
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.AllLoyalties;
        //    var commonRequest = new PlatformLoyaltyServiceRequest();
        //    var response = GetHttpResponseMessage(requestType, commonRequest);

        //    var allLoyalties = response.IsSuccessStatusCode
        //        ? (LoyaltyPrograms) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    //var allLoyalties = response.IsSuccessStatusCode
        //    //    ? GenericResponse<LoyaltyPrograms>(requestType, response)
        //    //    : throw new Exception((int)response.StatusCode + "-" + response.StatusCode);

        //    return allLoyalties;
        //}

        //public LoyaltyProgram GetLoyaltyById(string loyaltyId)
        //{
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.GetLoyaltyById;
        //    var commonRequest = new PlatformLoyaltyServiceRequest {Loyalty = new LoyaltyProgram {Id = loyaltyId}};
        //    var response = GetHttpResponseMessage(requestType, commonRequest);

        //    var loyaltyByIdResponse = response.IsSuccessStatusCode
        //        ? (LoyaltyProgram) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return loyaltyByIdResponse;
        //}

        //public LoyaltyProgram CreateLoyalty(LoyaltyProgram loyaltyRequest)
        //{
        //    var commonRequest = new PlatformLoyaltyServiceRequest {Loyalty = loyaltyRequest};
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.CreateLoyalty;
        //    var response = PostHttpResponseMessage(requestType, commonRequest);

        //    var savedLoyalty = response.IsSuccessStatusCode
        //        ? (LoyaltyProgram) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return savedLoyalty;
        //}

        //public LoyaltyProgram UpdateLoyaltyById(LoyaltyProgram loyaltyRequest)
        //{
        //    var commonRequest = new PlatformLoyaltyServiceRequest {Loyalty = loyaltyRequest};

        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.UpdateLoyaltyById;
        //    var response = PutHttpResponseMessage(requestType, commonRequest);

        //    var updatedLoyaltyResponse = response.IsSuccessStatusCode
        //        ? (LoyaltyProgram) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return updatedLoyaltyResponse;
        //}

        //#endregion Loyalty

        //#region Tiers

        //public Tiers GetAllTiers(string loyaltyId)
        //{
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.AllTiers;
        //    var commonRequest = new PlatformLoyaltyServiceRequest {Loyalty = new LoyaltyProgram {Id = loyaltyId}};
        //    var response = GetHttpResponseMessage(requestType, commonRequest);

        //    var allTiers = response.IsSuccessStatusCode
        //        ? (Tiers) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return allTiers;
        //}

        //public Tier GetTierById(string loyaltyId, string tierId)
        //{
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.GetTierById;
        //    var commonRequest =
        //        new PlatformLoyaltyServiceRequest {Tier = new Tier {Id = tierId, ProgramId = loyaltyId}};
        //    var response = GetHttpResponseMessage(requestType, commonRequest);

        //    var tier = response.IsSuccessStatusCode
        //        ? (Tier) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);
        //    return tier;
        //}

        //public Tier UpdateTierById(Tier tierRequest)
        //{
        //    var commonRequest = new PlatformLoyaltyServiceRequest {Tier = tierRequest};
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.UpdateTierById;
        //    var response = PutHttpResponseMessage(requestType, commonRequest);
        //    var updatedTier = response.IsSuccessStatusCode
        //        ? (Tier) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return updatedTier;
        //}

        //public Tier CreateTier(Tier tierRequest)
        //{
        //    var commonRequest = new PlatformLoyaltyServiceRequest {Tier = tierRequest};
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.CreateTier;
        //    var response = PostHttpResponseMessage(requestType, commonRequest);

        //    var createdTier = response.IsSuccessStatusCode
        //        ? (Tier) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return createdTier;
        //}

        //#endregion Tiers

        //#region Rewards

        //public Rewards GetAllRewards(string loyaltyId)
        //{
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.AllRewards;
        //    var commomRequest = new PlatformLoyaltyServiceRequest {Loyalty = new LoyaltyProgram {Id = loyaltyId}};
        //    var response = GetHttpResponseMessage(requestType, commomRequest);

        //    var allRewards = response.IsSuccessStatusCode
        //        ? (Rewards) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return allRewards;
        //}

        //public Reward CreateReward(Reward rewardRequest)
        //{
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.CreateReward;
        //    var commonRequest = new PlatformLoyaltyServiceRequest {Reward = rewardRequest};
        //    var response = PostHttpResponseMessage(requestType, commonRequest);

        //    var createdReward = response.IsSuccessStatusCode
        //        ? (Reward) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return createdReward;
        //}

        //public Reward GetRewardById(string loyaltyId, string rewardId)
        //{
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.GetRewardById;
        //    var commonRequest =
        //        new PlatformLoyaltyServiceRequest {Reward = new Reward {Id = rewardId, ProgramId = loyaltyId}};
        //    var response = GetHttpResponseMessage(requestType, commonRequest);

        //    var reward = response.IsSuccessStatusCode
        //        ? (Reward) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);

        //    return reward;
        //}

        //public Reward UpdateRewardById(Reward rewardRequest)
        //{
        //    var commonRequest = new PlatformLoyaltyServiceRequest {Reward = rewardRequest};
        //    const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.UpdateRewardById;
        //    var response = PutHttpResponseMessage(requestType, commonRequest);
        //    var updatedReward = response.IsSuccessStatusCode
        //        ? (Reward) Response(requestType, response)
        //        : throw new Exception((int) response.StatusCode + "-" + response.StatusCode);
        //    return updatedReward;
        //}

        //#endregion Rewards

        //#region Common Objects

        //public static HttpResponseMessage GetHttpResponseMessage(PlatformLoyaltyServiceRequestType requestType,
        //    PlatformLoyaltyServiceRequest request)
        //{
        //    UriBuilder uri = null;

        //    switch (requestType)
        //    {
        //        case PlatformLoyaltyServiceRequestType.AllLoyalties:
        //            uri = HttpClientFactory.GetUrl(requestType);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.GetLoyaltyById:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Loyalty.Id);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.AllTiers:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Loyalty.Id);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.GetTierById:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Tier.ProgramId, request.Tier.Id);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.AllRewards:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Loyalty.Id);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.GetRewardById:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Reward.ProgramId, request.Reward.Id);
        //            break;
        //    }

        //    var client = HttpClientFactory.GetClient();
        //    var response = client.GetAsync(uri.ToString()).Result;
        //    return response;
        //}

        //public static HttpResponseMessage PostHttpResponseMessage(PlatformLoyaltyServiceRequestType requestType,
        //    PlatformLoyaltyServiceRequest request)
        //{
        //    UriBuilder uri = null;
        //    StringContent content = null;

        //    switch (requestType)
        //    {
        //        case PlatformLoyaltyServiceRequestType.CreateLoyalty:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Loyalty.Id);
        //            content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Loyalty);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.CreateTier:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Tier.ProgramId);
        //            content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Tier);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.CreateReward:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Reward.ProgramId);
        //            content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Reward);
        //            break;
        //    }

        //    var client = HttpClientFactory.GetClient();
        //    var response = client.PostAsync(uri.ToString(), content).Result;
        //    return response;
        //}

        //public static HttpResponseMessage PutHttpResponseMessage(PlatformLoyaltyServiceRequestType requestType,
        //    PlatformLoyaltyServiceRequest request)
        //{
        //    UriBuilder uri = null;
        //    StringContent content = null;
        //    switch (requestType)
        //    {
        //        case PlatformLoyaltyServiceRequestType.UpdateLoyaltyById:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Loyalty.Id);
        //            content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Loyalty);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.UpdateTierById:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Tier.ProgramId, request.Tier.Id);
        //            content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Tier);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.UpdateRewardById:
        //            uri = HttpClientFactory.GetUrl(requestType, request.Reward.ProgramId, request.Reward.Id);
        //            content = HttpClientFactory.JsonContentFactory.CreateJsonContent(request.Reward);
        //            break;
        //    }

        //    var client = HttpClientFactory.GetClient();
        //    var response = client.PutAsync(uri.ToString(), content).Result;
        //    return response;
        //}

        //private dynamic Response(PlatformLoyaltyServiceRequestType requestType, HttpResponseMessage httpResponseMessage)
        //{
        //    var data = httpResponseMessage.Content.ReadAsStringAsync().Result;

        //    dynamic dynamicObject;

        //    switch (requestType)
        //    {
        //        case PlatformLoyaltyServiceRequestType.AllLoyalties:
        //            dynamicObject = JsonConvert.DeserializeObject<LoyaltyPrograms>(data);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.CreateLoyalty:
        //        case PlatformLoyaltyServiceRequestType.UpdateLoyaltyById:
        //        case PlatformLoyaltyServiceRequestType.GetLoyaltyById:
        //            dynamicObject = JsonConvert.DeserializeObject<LoyaltyProgram>(data);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.AllTiers:
        //            dynamicObject = JsonConvert.DeserializeObject<Tiers>(data);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.CreateTier:
        //        case PlatformLoyaltyServiceRequestType.UpdateTierById:
        //        case PlatformLoyaltyServiceRequestType.GetTierById:
        //            dynamicObject = JsonConvert.DeserializeObject<Tier>(data);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.AllRewards:
        //            dynamicObject = JsonConvert.DeserializeObject<Rewards>(data);
        //            break;
        //        case PlatformLoyaltyServiceRequestType.CreateReward:
        //        case PlatformLoyaltyServiceRequestType.UpdateRewardById:
        //        case PlatformLoyaltyServiceRequestType.GetRewardById:
        //            dynamicObject = JsonConvert.DeserializeObject<Reward>(data);
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException(nameof(requestType), requestType, null);
        //    }

        //    return dynamicObject;
        //}

        //#endregion Common Objects

        #endregion 1st Approach

        #region 2nd Approch

        private readonly PlatformLoyaltyServiceApi _platformLoyaltyServiceApi;

        public LoyaltyManager()
        {
            _platformLoyaltyServiceApi = new PlatformLoyaltyServiceApi();
        }

        #region Loyalty

        public LoyaltyPrograms GetAllLoyalties()
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.AllLoyalties;
            const string method = Constants.Get;
            var commonRequest = new PlatformLoyaltyServiceRequest();
            var allLoyalties = _platformLoyaltyServiceApi.LoyaltyProgramsResponse(requestType, commonRequest, method);
            return allLoyalties;
        }

        public LoyaltyProgram GetLoyaltyById(string loyaltyId)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.GetLoyaltyById;
            const string method = Constants.Get;
            var commonRequest = new PlatformLoyaltyServiceRequest { Loyalty = new LoyaltyProgram { Id = loyaltyId } };
            var loyaltyByIdResponse = _platformLoyaltyServiceApi.LoyaltyProgramResponse(requestType, commonRequest, method);
            return loyaltyByIdResponse;
        }

        public LoyaltyProgram CreateLoyalty(LoyaltyProgram loyaltyRequest)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.CreateLoyalty;
            const string method = Constants.Post;
            var savedLoyalty = _platformLoyaltyServiceApi.LoyaltyProgramResponse(loyaltyRequest, requestType, method);
            return savedLoyalty;
        }

        public LoyaltyProgram UpdateLoyaltyById(LoyaltyProgram loyaltyRequest)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.UpdateLoyaltyById;
            const string method = Constants.Put;
            var updatedLoyaltyResponse = _platformLoyaltyServiceApi.LoyaltyProgramResponse(loyaltyRequest, requestType, method);
            return updatedLoyaltyResponse;
        }

        #endregion Loyalty

        #region Tiers

        public Tiers GetAllTiers(string loyaltyId)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.AllTiers;
            const string method = Constants.Get;
            var commonRequest = new PlatformLoyaltyServiceRequest { Loyalty = new LoyaltyProgram { Id = loyaltyId } };
            var allTiers = _platformLoyaltyServiceApi.TiersResponse(requestType, commonRequest, method);
            return allTiers;
        }

        public Tier GetTierById(string loyaltyId, string tierId)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.GetTierById;
            const string method = Constants.Get;
            var commonRequest = new PlatformLoyaltyServiceRequest { Tier = new Tier { Id = tierId, ProgramId = loyaltyId } };
            var tier = _platformLoyaltyServiceApi.TierResponse(requestType, commonRequest, method);
            return tier;
        }

        public Tier CreateTier(Tier tierRequest)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.CreateTier;
            const string method = Constants.Post;
            var createdTier = _platformLoyaltyServiceApi.TierResponse(tierRequest, requestType, method);
            return createdTier;
        }

        public Tier UpdateTierById(Tier tierRequest)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.UpdateTierById;
            const string method = Constants.Put;
            var updatedTier = _platformLoyaltyServiceApi.TierResponse(tierRequest, requestType, method);
            return updatedTier;
        }

        #endregion Tiers

        #region Rewards

        public Rewards GetAllRewards(string loyaltyId)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.AllRewards;
            const string method = Constants.Get;
            var commonRequest = new PlatformLoyaltyServiceRequest { Loyalty = new LoyaltyProgram { Id = loyaltyId } };
            var allRewards = _platformLoyaltyServiceApi.RewardsResponse(requestType, commonRequest, method);
            return allRewards;
        }

        public Reward GetRewardById(string loyaltyId, string rewardId)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.GetRewardById;
            const string method = Constants.Get;
            var commonRequest = new PlatformLoyaltyServiceRequest { Reward = new Reward { Id = rewardId, ProgramId = loyaltyId } };
            var reward = _platformLoyaltyServiceApi.RewardResponse(requestType, commonRequest, method);
            return reward;
        }

        public Reward CreateReward(Reward rewardRequest)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.CreateReward;
            const string method = Constants.Post;
            var createdReward = _platformLoyaltyServiceApi.RewardResponse(rewardRequest, requestType, method);
            return createdReward;
        }

        public Reward UpdateRewardById(Reward rewardRequest)
        {
            const PlatformLoyaltyServiceRequestType requestType = PlatformLoyaltyServiceRequestType.UpdateRewardById;
            const string method = Constants.Put;
            var updatedReward = _platformLoyaltyServiceApi.RewardResponse(rewardRequest, requestType, method);
            return updatedReward;
        }

        #endregion Rewards

        #endregion 2nd Approch


    }
}