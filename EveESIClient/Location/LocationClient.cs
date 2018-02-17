using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Location;

namespace EveESIClient.Location
{
    public class LocationClient
    {
        private readonly IHttpClient _httpClient;
        internal LocationClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Information about the characters current location. 
        /// Returns the current solar system id, and also the current station or structure ID if applicable.
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Information about the characters current location.
        /// Returns the current solar system id, and also the current station or structure ID if applicable</returns>
        public ESIResponse<GetCharacterLocationResponse> GetCharacterLocation(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/location/", authToken);

            return _httpClient.Execute<GetCharacterLocationResponse>(request);
        }

        /// <summary>
        /// Checks if the character is currently online
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Object describing the character’s online status</returns>
        public ESIResponse<GetCharacterOnlineResponse> GetCharacterOnline(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/online/", authToken);

            return _httpClient.Execute<GetCharacterOnlineResponse>(request);
        }

        /// <summary>
        /// Get the current ship type, name and id
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Get the current ship type, name and id</returns>
        public ESIResponse<GetCharactersCurrentShipResponse> GetCharactersCurrentShip(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/ship/", authToken);

            return _httpClient.Execute<GetCharactersCurrentShipResponse>(request);
        }
    }
}