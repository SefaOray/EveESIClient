using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Killmails;
using System.Collections.Generic;

namespace EveESIClient.Killmails
{
    public class KillmailsClient
    {
        private readonly IHttpClient _httpClient;
        internal KillmailsClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Return a list of character’s recent kills and losses
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="maxCount">How many killmails to return at maximum</param>
        /// <param name="maxKillmailId">Only return killmails with ID smaller than this</param>
        /// <returns>A list of killmail IDs and hashes</returns>
        public ESIResponse<List<GetCharacterKillmailsResponse>> GetCharacterKillmails(string authToken, int characterId, int? maxCount, int? maxKillmailId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/killmails/recent/", authToken);
            request.AddParameter("max_count", maxCount, RestSharp.ParameterType.QueryString);
            request.AddParameter("max_kill_id", maxKillmailId, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCharacterKillmailsResponse>>(request);
        }

        /// <summary>
        /// Get a list of corporation’s recent kills and losses
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE character ID</param>
        /// <param name="maxCount">How many killmails to return at maximum</param>
        /// <param name="maxKillmailId">Only return killmails with ID smaller than this</param>
        /// <returns>A list of killmail IDs and hashes</returns>
        public ESIResponse<List<GetCorporationKillmailsResponse>> GetCorporationKillmails(string authToken, int corporationId, int? maxCount, int? maxKillmailId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/killmails/recent/", authToken);
            request.AddParameter("max_count", maxCount, RestSharp.ParameterType.QueryString);
            request.AddParameter("max_kill_id", maxKillmailId, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCorporationKillmailsResponse>>(request);
        }

        /// <summary>
        /// Return a single killmail from its ID and hash
        /// </summary>
        /// <param name="killmailHash"></param>
        /// <param name="killmailId"></param>
        /// <returns>A killmail</returns>
        public ESIResponse<GetKillmailResponse> GetKillmail(string killmailHash, int killmailId)
        {
            var request = RestRequestHelper.CreateGetRequest($"killmails/{killmailId}/{killmailHash}/");

            return _httpClient.Execute<GetKillmailResponse>(request);
        }
    }
}
