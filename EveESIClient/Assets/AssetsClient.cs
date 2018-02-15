using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Assets;
using RestSharp;
using System;
using System.Collections.Generic;

namespace EveESIClient.Assets
{
    public class AssetsClient
    {
        private readonly IHttpClient _client;

        internal AssetsClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Return a list of the characters assets
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return (Default is 0) </param>
        /// <returns>A flat list of the users assets</returns>
        public ESIResponse<List<GetCharacterAssetsResponse>> GetCharacterAssets(string authToken, Int64 characterId, int page = 0)
        {
            var request =
                RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/assets/",
                    authToken);

            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCharacterAssetsResponse>>(request);
        }

        /// <summary>
        /// Return locations for a set of item ids, which you can get from character assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)
        /// </summary>
        /// <param name="authToken">Access token</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="itemIds">A list of item ids</param>
        /// <returns>List of asset locations</returns>
        public ESIResponse<List<GetCharacterAssetsLocationsResponse>> GetCharacterAssetsLocations(string authToken,
            Int64 characterId, Int64[] itemIds)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"characters/{characterId}/assets/locations/", authToken);

            request.AddBody(itemIds);

            return _client.Execute<List<GetCharacterAssetsLocationsResponse>>(request);
        }

        /// <summary>
        /// Return names for a set of item ids, which you can get from character assets endpoint. Typically used for items that can customize names, like containers or ships.
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="itemIds">A list of item ids</param>
        /// <returns>List of asset names</returns>
        public ESIResponse<List<GetCharacterAssetsNamesResponse>> GetCharacterAssetsNames(string authToken,
            Int64 characterId, Int64[] itemIds)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"characters/{characterId}/assets/names/", authToken);

            request.AddBody(itemIds);

            return _client.Execute<List<GetCharacterAssetsNamesResponse>>(request);
        }

        /// <summary>
        /// Return a list of the corporation assets
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of assets</returns>
        public ESIResponse<List<GetCorporationAssetsResponse>> GetCorporationAssets(string authToken, Int64 corporationId, int page = 0)
        {
            var request =
                RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/assets/",
                    authToken);

            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationAssetsResponse>>(request);
        }

        /// <summary>
        /// Return locations for a set of item ids, which you can get from corporation assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="itemIds">A list of item ids</param>
        /// <returns>List of asset locations</returns>
        public ESIResponse<List<GetCorporationAssetsLocationsResponse>> GetCorporationAssetsLocations(string authToken,
            Int64 corporationId, Int64[] itemIds)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"corporations/{corporationId}/assets/locations/", authToken);

            request.AddBody(itemIds);

            return _client.Execute<List<GetCorporationAssetsLocationsResponse>>(request);
        }

        /// <summary>
        /// Return names for a set of item ids, which you can get from corporation assets endpoint. Only valid for items that can customize names, like containers or ships.
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="itemIds">A list of item ids</param>
        /// <returns>List of asset names</returns>
        public ESIResponse<List<GetCorporationAssetsNamesResponse>> GetCorporationAssetsNames(string authToken,
            Int64 corporationId, Int64[] itemIds)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/assets/names/",
                Method.POST, authToken);

            request.AddBody(itemIds);

            return _client.Execute<List<GetCorporationAssetsNamesResponse>>(request);
        }
    }
}