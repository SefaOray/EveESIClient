using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Incursions;
using System.Collections.Generic;

namespace EveESIClient.Incursions
{
    public class IncursionsClient
    {
        private readonly IHttpClient _httpClient;
        internal IncursionsClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Return a list of current incursions
        /// </summary>
        /// <returns>A list of incursions</returns>
        public ESIResponse<List<ListIncursionsResponse>> ListIncursions()
        {
            var request = RestRequestHelper.CreateGetRequest("incursions/");

            return _httpClient.Execute<List<ListIncursionsResponse>>(request);
        }
    }
}