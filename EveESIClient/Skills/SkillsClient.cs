using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Skills;

namespace EveESIClient.Skills
{
    public class SkillsClient
    {
        private readonly IHttpClient _httpClient;
        internal SkillsClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Attributes of a character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Attributes of a character</returns>
        public ESIResponse<GetCharacterAttributesResponse> GetCharacterAttributes(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/attributes/", authToken);

            return _httpClient.Execute<GetCharacterAttributesResponse>(request);
        }

        /// <summary>
        /// List the configured skill queue for the given character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>The current skill queue, sorted ascending by finishing time</returns>
        public ESIResponse<GetSkillQueueResponse> GetSkillQueue(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/skillqueue/", authToken);

            return _httpClient.Execute<GetSkillQueueResponse>(request);
        }

        /// <summary>
        /// List all trained skills for the given character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Known skills for the character</returns>
        public ESIResponse<GetCharacterSkills> GetCharacterSkills(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/skillqueue/", authToken);

            return _httpClient.Execute<GetCharacterSkills>(request);
        }
    }
}
