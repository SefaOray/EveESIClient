using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.FactionWarfare;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.FactionWarfare
{
    public class FactionWarfareClient
    {
        private readonly IHttpClient _client;
        internal FactionWarfareClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Statistical overview of a character involved in faction warfare
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Faction warfare statistics for a given character</returns>
        public ESIResponse<GetCharacterFactionWarfareStatsResponse> GetCharacterFactionWarfareStats(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/fw/stats/", Method.GET, authToken);

            return _client.Execute<GetCharacterFactionWarfareStatsResponse>(request);
        }

        /// <summary>
        /// Statistics about a corporation involved in faction warfare
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>Faction warfare statistics for a given corporation</returns>
        public ESIResponse<GetCorporationFactionWarfareStatsResponse> GetCorporationFactionWarfareStats(string authToken, Int64 corporationId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/fw/stats/", Method.GET, authToken);

            return _client.Execute<GetCorporationFactionWarfareStatsResponse>(request);
        }

        /// <summary>
        /// Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday.
        /// </summary>
        /// <returns>Corporation leaderboard of kills and victory points within faction warfare</returns>
        public ESIResponse<GetLeaderboardsResponse> GetLeaderboards()
        {
            var request = RestRequestHelper.CreateRestRequest($"fw/leaderboards/", Method.GET);

            return _client.Execute<GetLeaderboardsResponse>(request);
        }

        /// <summary>
        /// Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday.
        /// </summary>
        /// <returns>Character leaderboard of kills and victory points within faction warfare.</returns>
        public ESIResponse<GetCharacterLeaderboardsResponse> GetCharacterLeaderboards()
        {
            var request = RestRequestHelper.CreateRestRequest($"fw/leaderboards/characters/", Method.GET);

            return _client.Execute<GetCharacterLeaderboardsResponse>(request);
        }

        /// <summary>
        /// Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday.
        /// </summary>
        /// <returns>Corporation leaderboard of kills and victory points within faction warfare.</returns>
        public ESIResponse<GetCorporationLeaderboardsResponse> GetCorporationLeaderboards()
        {
            var request = RestRequestHelper.CreateRestRequest($"fw/leaderboards/corporations/", Method.GET);

            return _client.Execute<GetCorporationLeaderboardsResponse>(request);
        }

        /// <summary>
        /// Statistical overviews of factions involved in faction warfare
        /// </summary>
        /// <returns>Per faction breakdown of faction warfare statistics</returns>
        public ESIResponse<GetFactionWarfareStatsResponse> GetFactionWarfareStats()
        {
            var request = RestRequestHelper.CreateRestRequest($"fw/stats/", Method.GET);

            return _client.Execute<GetFactionWarfareStatsResponse>(request);
        }

        /// <summary>
        /// An overview of the current ownership of faction warfare solar systems
        /// </summary>
        /// <returns>All faction war solar systems</returns>
        public ESIResponse<List<GetFactionWarfareSystemOwnershipsResponse>> GetFactionWarfareSystemOwnerships()
        {
            var request = RestRequestHelper.CreateRestRequest($"fw/systems/", Method.GET);

            return _client.Execute<List<GetFactionWarfareSystemOwnershipsResponse>>(request);
        }

        /// <summary>
        /// Data about which NPC factions are at war
        /// </summary>
        /// <returns>A list of NPC factions at war</returns>
        public ESIResponse<List<GetFactionWarfareWarsResponse>> GetFactionWarfareWars()
        {
            var request = RestRequestHelper.CreateRestRequest($"fw/wars/", Method.GET);

            return _client.Execute<List<GetFactionWarfareWarsResponse>>(request);
        }
    }
}
