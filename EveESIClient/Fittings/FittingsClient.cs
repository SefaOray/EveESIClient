using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Fittings;
using System;
using System.Collections.Generic;

namespace EveESIClient.Fittings
{
    public class FittingsClient
    {
        private readonly IHttpClient _client;

        internal FittingsClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Return fittings of a character
        /// </summary>
        /// <param name="authtoken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of fittings</returns>
        public ESIResponse<List<GetCharacterFittingsResponse>> GetCharacterFittings(string authtoken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/fittings/", authtoken);

            return _client.Execute<List<GetCharacterFittingsResponse>>(request);
        }

        /// <summary>
        /// Save a new fitting for a character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="input">Details about the new fitting</param>
        /// <returns>Newly created fitting id</returns>
        public ESIResponse<CreateFittingResponse> CreateFitting(string authToken, Int64 characterId, CreateFittingInput input)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"characters/{characterId}/fittings/", authToken);
            request.AddBody(input);

            return _client.Execute<CreateFittingResponse>(request);
        }

        /// <summary>
        /// Delete a fitting from a character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fittingId">ID for a fitting of this character</param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> DeleteFitting(string authToken, Int64 characterId, int fittingId)
        {
            var request = RestRequestHelper.CreateAuthorizedDeleteRequest($"characters/{characterId}/fittings/{fittingId}", authToken);

            return _client.Execute<object>(request);
        }
    }
}