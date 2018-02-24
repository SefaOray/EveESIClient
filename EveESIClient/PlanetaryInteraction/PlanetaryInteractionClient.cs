using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.PlanetaryInteraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.PlanetaryInteraction
{
    public class PlanetaryInteractionClient
    {
        private IHttpClient _httpClient;
        internal PlanetaryInteractionClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Returns a list of all planetary colonies owned by a character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>List of colonies</returns>
        public ESIResponse<List<GetColoniesResponse>> GetColonies(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/planets/", authToken);

            return _httpClient.Execute<List<GetColoniesResponse>>(request);
        }

        /// <summary>
        /// Returns full details on the layout of a single planetary colony, including links, pins and routes. 
        /// Note: Planetary information is only recalculated when the colony is viewed through the client. 
        /// Information will not update until this criteria is met
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="planetId">Planet id of the target planet</param>
        /// <returns>Colony layout</returns>
        public ESIResponse<GetColonyLayoutResponse> GetColonyLayout(string authToken, int characterId, int planetId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/planets/{planetId}/", authToken);

            return _httpClient.Execute<GetColonyLayoutResponse>(request);
        }

        /// <summary>
        /// List customs offices owned by a corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>A list of customs offices and their settings</returns>
        public ESIResponse<List<GetCorporationCustomsOfficesResponse>> GetCorporationCustomsOffices(string authToken, int corporationId, int? page)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/customs_offices/", authToken);

            return _httpClient.Execute<List<GetCorporationCustomsOfficesResponse>>(request);
        }

        /// <summary>
        /// Get information on a planetary factory schematic
        /// </summary>
        /// <param name="schematicId">A PI schematic ID</param>
        /// <returns>Public data about a schematic</returns>
        public ESIResponse<GetSchematicInformationResponse> GetSchematicInformation(int schematicId)
        {
            var request = RestRequestHelper.CreateGetRequest($"universe/schematics/{schematicId}/");

            return _httpClient.Execute<GetSchematicInformationResponse>(request);
        }
    }
}
