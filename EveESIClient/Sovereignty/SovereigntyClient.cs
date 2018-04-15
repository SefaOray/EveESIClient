using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Sovereignty;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Sovereignty
{
    public class SovereigntyClient
    {
        private readonly IHttpClient _httpClient;
        internal SovereigntyClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Shows sovereignty data for campaigns
        /// </summary>
        /// <returns>A list of sovereignty campaigns</returns>
        public ESIResponse<GetSovereigntyCampaignsResponse> GetSovereigntyCampaigns()
        {
            var request = RestRequestHelper.CreateGetRequest($"sovereignty/campaigns/");

            return _httpClient.Execute<GetSovereigntyCampaignsResponse>(request);
        }

        /// <summary>
        /// Shows sovereignty information for solar systems
        /// </summary>
        /// <returns>A  list of sovereignty information for solar systems in New Eden</returns>
        public ESIResponse<List<GetSovereigntyOfSystemsResponse>> GetSovereigntyOfSystems()
        {
            var request = RestRequestHelper.CreateGetRequest($"sovereignty/map/");

            return _httpClient.Execute<List<GetSovereigntyOfSystemsResponse>>(request);
        }

        /// <summary>
        /// Shows sovereignty data for structures
        /// </summary>
        /// <returns>A list of sovereignty structures</returns>
        public ESIResponse<List<GetSovereigntyStructuresResponse>> GetSovereigntyStructures()
        {
            var request = RestRequestHelper.CreateGetRequest($"sovereignty/structures/");

            return _httpClient.Execute<List<GetSovereigntyStructuresResponse>>(request);
        }
    }
}
