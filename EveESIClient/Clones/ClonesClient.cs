using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Clones;
using System;
using System.Collections.Generic;

namespace EveESIClient.Clones
{
    public class ClonesClient
    {
        private readonly IHttpClient _client;

        internal ClonesClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// A list of the character’s clones
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Clone information for the given character</returns>
        public ESIResponse<GetClonesResponse> GetClones(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/clones/", authToken);

            return _client.Execute<GetClonesResponse>(request);
        }

        /// <summary>
        /// Return implants on the active clone of a character
        /// </summary>
        /// <param name="authToken">An EVE character ID</param>
        /// <param name="characterId">Access token to use </param>
        /// <returns>A list of implant type ids</returns>
        public ESIResponse<List<Int64>> GetImplants(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/implants/", authToken);

            return _client.Execute<List<Int64>>(request);
        }
    }
}