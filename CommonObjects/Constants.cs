using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoyaltyIntegration.CommonObjects
{
    public class Constants
    {
        public const string Get = "GET";
        public const string Post = "POST";
        public const string Put = "PUT";
        public const string MediaType = "application/json";
        public const string ApiKey = "x-api-key";
        public const string ConceptKey = "tenant";
        public const string Environment = "env";

        public const string Loyalty = "programs/";
        public const string Tier = "/tiers/";
        public const string Reward = "/rewards/";
    }
}