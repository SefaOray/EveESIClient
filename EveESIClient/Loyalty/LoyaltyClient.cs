using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Loyalty;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Loyalty
{
    public class LoyaltyClient
    {
        private readonly IHttpClient _httpClient;
        internal LoyaltyClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Return a list of loyalty points for all corporations the character has worked for
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of loyalty points</returns>
        public ESIResponse<List<GetCharacterLocaltyPointsResponse>> GetCharacterLoyaltyPoints(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/loyalty/points/", authToken);

            return _httpClient.Execute<List<GetCharacterLocaltyPointsResponse>>(request);
        }

        /// <summary>
        /// Return a list of offers from a specific corporation’s loyalty store
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <returns>A list of offers</returns>
        public ESIResponse<List<GetLoyaltyStoreOffersResponse>> GetLoyaltyStoreOffers(int corporationId)
        {
            var request = RestRequestHelper.CreateGetRequest($"loyalty/stores/{corporationId}/offers/");

            return _httpClient.Execute<List<GetLoyaltyStoreOffersResponse>>(request);
        }
    }
}