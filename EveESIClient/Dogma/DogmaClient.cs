using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Dogma;
using RestSharp;
using System;
using System.Collections.Generic;

namespace EveESIClient.Dogma
{
    public class DogmaClient
    {
        private readonly IHttpClient _client;

        internal DogmaClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Get a list of dogma attribute ids
        /// </summary>
        /// <returns>A list of dogma attribute ids</returns>
        public ESIResponse<List<Int64>> GetDogmaAttributes()
        {
            var request = RestRequestHelper.CreateGetRequest("dogma/attributes/");

            return _client.Execute<List<Int64>>(request);
        }

        /// <summary>
        /// Get information on a dogma attribute
        /// </summary>
        /// <param name="attributeId">A dogma attribute ID</param>
        /// <returns>Information about a dogma attribute</returns>
        public ESIResponse<GetDogmaAttributeInformationResponse> GetDogmaAttbiuteInformation(Int64 attributeId)
        {
            var request = RestRequestHelper.CreateGetRequest($"dogma/attributes/{attributeId}/");

            return _client.Execute<GetDogmaAttributeInformationResponse>(request);
        }

        /// <summary>
        /// Get a list of dogma effect ids
        /// </summary>
        /// <returns>A list of dogma effect ids</returns>
        public ESIResponse<List<Int64>> GetDogmaEffects()
        {
            var request = RestRequestHelper.CreateGetRequest("dogma/effects/");

            return _client.Execute<List<Int64>>(request);
        }

        /// <summary>
        /// Get information on a dogma effect
        /// </summary>
        /// <param name="effectId">A dogma effect ID</param>
        /// <returns>Information about a dogma effect</returns>
        public ESIResponse<GetDogmaEffectInformationResponse> GetDogmaEffectInformation(Int64 effectId)
        {
            var request = RestRequestHelper.CreateGetRequest($"dogma/effects/{effectId}/");

            return _client.Execute<GetDogmaEffectInformationResponse>(request);
        }
    }
}