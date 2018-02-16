using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Industry;
using System.Collections.Generic;

namespace EveESIClient.Industry
{
    public class IndustryClient
    {
        private readonly IHttpClient _httpClient;
        internal IndustryClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// List industry jobs placed by a character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Industry jobs placed by a character</returns>
        public ESIResponse<List<GetCharacterIndustryJobsResponse>> GetCharacterIndustryJobs(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/industry/jobs/", authToken);

            return _httpClient.Execute<List<GetCharacterIndustryJobsResponse>>(request);
        }

        /// <summary>
        /// Paginated record of all mining done by a character for the past 30 days
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>Mining ledger of a character</returns>
        public ESIResponse<List<GetCharacterMiningLedgerResponse>> GetCharacterMiningLedger(string authToken, int characterId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/mining/", authToken);
            request.AddParameter("page", page, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCharacterMiningLedgerResponse>>(request);
        }

        /// <summary>
        /// Extraction timers for all moon chunks being extracted by refineries belonging to a corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>A list of chunk timers</returns>
        public ESIResponse<List<GetCorporationMoonExtractionTimersResponse>> GetCorporationMoonExtractionTimers(string authToken, int corporationId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporation/{corporationId}/mining/extractions/", authToken);

            return _httpClient.Execute<List<GetCorporationMoonExtractionTimersResponse>>(request);
        }

        /// <summary>
        /// Paginated list of all entities capable of observing and recording mining for a corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>Observer list of a corporation</returns>
        public ESIResponse<List<GetCorporationMiningObserversResponse>> GetCorporationMiningObservers(string authToken, int corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporation/{corporationId}/mining/observers/", authToken);
            request.AddParameter("page", page, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCorporationMiningObserversResponse>>(request);
        }

        /// <summary>
        /// Paginated record of all mining seen by an observer
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="observerId">A mining observer id</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>Mining ledger of an observer</returns>
        public ESIResponse<List<GetCorporationObservedMiningResponse>> GetCorporationObservedMining(string authToken, int corporationId, int observerId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporation/{corporationId}/mining/observers/{observerId}/", authToken);
            request.AddParameter("page", page, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCorporationObservedMiningResponse>>(request);
        }

        /// <summary>
        /// List industry jobs run by a corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>A list of corporation industry jobs</returns>
        public ESIResponse<List<GetCorporationIndustryJobsResponse>> GetCorporationIndustryJobs(string authToken, int corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/industry/jobs/", authToken);
            request.AddParameter("page", page, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCorporationIndustryJobsResponse>>(request);
        }

        /// <summary>
        /// Return a list of industry facilities
        /// </summary>
        /// <returns>A list of facilities</returns>
        public ESIResponse<List<GetIndustryFacilitiesResponse>> GetIndustryFacilities()
        {
            var request = RestRequestHelper.CreateGetRequest($"industry/facilities/");

            return _httpClient.Execute<List<GetIndustryFacilitiesResponse>>(request);
        }

        /// <summary>
        /// Return cost indices for solar systems
        /// </summary>
        /// <returns>A list of cost indicies</returns>
        public ESIResponse<List<GetSolarSystemCostIndicesResponse>> GetSolarSystemCostIndices()
        {
            var request = RestRequestHelper.CreateGetRequest($"industry/systems/");

            return _httpClient.Execute<List<GetSolarSystemCostIndicesResponse>>(request);
        }
    }
}
