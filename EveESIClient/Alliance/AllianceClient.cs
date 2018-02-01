using EveESIClient.Client;
using EveESIClient.Models.Alliance;
using RestSharp;
using System;
using System.Collections.Generic;
using EveESIClient.Helpers;

namespace EveESIClient.Alliance
{
    /// <summary>
    /// Requests to /alliances endpoints
    /// </summary>
    public class AllianceClient
    {
        private readonly IHttpClient _client;
        internal AllianceClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// List all active player alliances
        /// </summary>
        /// <returns>List of Alliance IDs</returns>
        public ESIResponse<List<Int64>> Alliances()
        {
            var request = RestRequestHelper.CreateRestRequest("alliances/",Method.GET);
            var response = _client.Execute<List<Int64>>(request);
            return response;
        }

        /// <summary>
        /// Public information about an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <returns>Public data about an alliance</returns>
        public ESIResponse<GetAllianceResponse> GetAlliance(Int64 allianceId)
        {
            var request = RestRequestHelper.CreateRestRequest($"alliances/{allianceId}", Method.GET);

            var response = _client.Execute<GetAllianceResponse>(request);
            return response;
        }

        /// <summary>
        /// List all current member corporations of an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <returns>List of corporation IDs</returns>
        public ESIResponse<List<Int64>> GetAllianceCorporations(Int64 allianceId)
        {
            var request = RestRequestHelper.CreateRestRequest($"alliances/{allianceId}/corporations/", Method.GET);

            var response = _client.Execute<List<Int64>>(request);
            return response;
        }

        /// <summary>
        /// Get the icon urls for a alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <returns>Icon URLs for the given alliance id and server</returns>
        public ESIResponse<GetAllianceIconsResponse> GetAllianceIcons(Int64 allianceId)
        {
            var request = RestRequestHelper.CreateRestRequest($"alliances/{allianceId}/icons/", Method.GET);

            var response = _client.Execute<GetAllianceIconsResponse>(request);
            return response;
        }

        /// <summary>
        /// Resolve a set of alliance IDs to alliance names
        /// </summary>
        /// <param name="allianceIds">A comma separated list of alliance IDs. Note: Comma seperation is done by the client.</param>
        /// <returns>List of id/name associations</returns>
        public ESIResponse<GetAllianceNamesResponse> GetAllianceNames(Int64[] allianceIds)
        {
            var request = RestRequestHelper.CreateRestRequest("alliances/names/", Method.GET);
            request.AddParameter("alliance_ids", string.Join(",",allianceIds));

            var response = _client.Execute<GetAllianceNamesResponse>(request);
            return response;
        }
    }
}
