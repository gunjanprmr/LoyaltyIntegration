using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using LoyaltyIntegration.CommonObjects;
using Newtonsoft.Json;

namespace LoyaltyIntegration.Framework
{
    public class HttpClientFactory
    {
        /// <summary>
        ///     HttpClient Helper
        /// </summary>
        public static HttpClient GetClient(Dictionary<string, string> customHeaders = null)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.MediaType));
            SetHeaders(customHeaders, client);

            return client;
        }

        private static void SetHeaders(Dictionary<string, string> customHeaders, HttpClient client)
        {
            if (customHeaders != null)
            {
                foreach (var header in customHeaders)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }
        }

        /// <summary>
        ///     StringContent Helper for POST and PUT request.
        ///     This will pass request in API call.
        /// </summary>
        public static class JsonContentFactory
        {
            public static StringContent CreateJsonContent(object request)
            {
                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, Constants.MediaType);
                return content;
            }
        }

        public static HttpResponseMessage PerformRequest(string method, UriBuilder uri, StringContent content,
            HttpClient client)
        {
            HttpResponseMessage responseMessage;

            switch (method.ToUpper())
            {
                case "GET":
                    responseMessage = client.GetAsync(uri.ToString()).Result;
                    break;
                case "POST":
                    responseMessage = client.PostAsync(uri.ToString(), content).Result;
                    break;
                case "PUT":
                    responseMessage = client.PutAsync(uri.ToString(), content).Result;
                    break;
                default:
                    throw new NotImplementedException();
            }

            return responseMessage;
        }
    }
}