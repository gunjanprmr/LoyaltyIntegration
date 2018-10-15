using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using LoyaltyIntegration.CommonObjects;

namespace LoyaltyIntegration
{
    public class WebApiApplication : HttpApplication
    {
        internal static HttpClient HttpClientInstance;
        internal static Uri BaseUriInstance;


        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var environment = ConfigurationManager.AppSettings["PlatformLoyaltyServiceEnvironment"];
            var apiKey = ConfigurationManager.AppSettings["PlatformLoyaltyServiceKey"];
            var conceptKey = ConfigurationManager.AppSettings["PlatformLoyaltyServiceTenant"];

            HttpClientInstance = new HttpClient();
            HttpClientInstance.DefaultRequestHeaders.Accept.Clear();
            HttpClientInstance.DefaultRequestHeaders.ConnectionClose = false;
            HttpClientInstance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.MediaType));
            HttpClientInstance.DefaultRequestHeaders.Add(Constants.Environment, environment);
            HttpClientInstance.DefaultRequestHeaders.Add(Constants.ApiKey, apiKey);
            HttpClientInstance.DefaultRequestHeaders.Add(Constants.ConceptKey, conceptKey);

            BaseUri();
        }

        protected Uri BaseUri()
        {
            var baseUrl = ConfigurationManager.AppSettings["PlatformLoyaltyServiceURL"];
            BaseUriInstance = new Uri(baseUrl);
            ServicePointManager.FindServicePoint(BaseUriInstance).ConnectionLeaseTimeout = 60 * 1000;
            return BaseUriInstance;
        }
    }
}