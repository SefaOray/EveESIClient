using System;
using System.Collections.Generic;
using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Assets;
using RestSharp;

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
        /// <returns></returns>
        public ESIResponse<List<GetCharacterAssetsResponse>> GetCharacterAssets(string authToken, Int64 characterId)
        {
            var request =
                RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/assets/", Method.GET,
                    authToken);

            return _client.Execute<List<GetCharacterAssetsResponse>>(request);
        }

        public ESIResponse<List<GetCharacterAssetsLocationsResponse>> GetCharacterAssetsLocations(string authToken,
            Int64 characterId, Int64[] itemIds)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/assets/locations/",
                Method.POST, authToken);

            request.AddBody(itemIds);

            return _client.Execute<List<GetCharacterAssetsLocationsResponse>>(request);
        }
    }
}