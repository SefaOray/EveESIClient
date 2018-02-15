using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Character;
using System;
using System.Collections.Generic;

namespace EveESIClient.Character
{
    public class CharacterClient
    {
        private readonly IHttpClient _client;

        internal CharacterClient(IHttpClient httpClient)
        {
            _client = httpClient;
        }

        /// <summary>
        /// Public information about a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Public data for the given character</returns>
        public ESIResponse<GetCharacterResponse> GetCharacter(Int64 characterId)
        {
            var request = RestRequestHelper.CreateGetRequest($"characters/{characterId}/");

            return _client.Execute<GetCharacterResponse>(request);
        }

        /// <summary>
        /// Return a list of agents research information for a character.
        /// The formula for finding the current research points with an agent is: c
        /// urrentPoints = remainderPoints + pointsPerDay * days(currentTime - researchStartDate)
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of agents research information</returns>
        public ESIResponse<List<GetAgentResearchResponse>> GetAgentResearch(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/agents_research/", authToken);

            return _client.Execute<List<GetAgentResearchResponse>>(request);
        }

        /// <summary>
        /// Return a list of blueprints the character owns
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of blueprints</returns>
        public ESIResponse<List<GetBlueprintsResponse>> GetBlueprints(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/blueprints/", authToken);

            return _client.Execute<List<GetBlueprintsResponse>>(request);
        }

        /// <summary>
        /// Return chat channels that a character is the owner or operator of
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of chat channels</returns>
        public ESIResponse<List<GetChatChannelsResponse>> GetChatChannels(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/chat_channels/", authToken);

            return _client.Execute<List<GetChatChannelsResponse>>(request);
        }

        /// <summary>
        /// Get a list of all the corporations a character has been a member of
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Corporation history for the given character</returns>
        public ESIResponse<List<GetCorporationHistoryResponse>> GetCorporationHistory(Int64 characterId)
        {
            var request = RestRequestHelper.CreateGetRequest($"characters/{characterId}/corporationhistory/");

            return _client.Execute<List<GetCorporationHistoryResponse>>(request);
        }

        /// <summary>
        /// Takes a source character ID in the url and a set of target character ID’s in the body, returns a CSPA charge cost
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="targetCharacters">The target characters to calculate the charge for</param>
        /// <returns>Aggregate cost of sending a mail from the source character to the target characters, in ISK</returns>
        public ESIResponse<float> Cspa(string authToken, Int64 characterId, List<Int64> targetCharacters)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"characters/{characterId}/cspa/", authToken);

            request.AddBody(targetCharacters);

            return _client.Execute<float>(request);
        }

        /// <summary>
        /// Return a character’s jump activation and fatigue information
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Jump activation and fatigue information</returns>
        public ESIResponse<GetFatigueResponse> GetFatigue(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/fatigue/", authToken);

            return _client.Execute<GetFatigueResponse>(request);
        }

        /// <summary>
        /// Return a list of medals the character has
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of medals</returns>
        public ESIResponse<List<GetCharacterMedalsResponse>> GetCharacterMedals(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/medals/", authToken);

            return _client.Execute<List<GetCharacterMedalsResponse>>(request);
        }

        /// <summary>
        /// Return character notifications
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Returns your recent notifications</returns>
        public ESIResponse<List<GetCharacterNotificationsResponse>> GetCharacterNotifications(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/notifications/", authToken);

            return _client.Execute<List<GetCharacterNotificationsResponse>>(request);
        }

        /// <summary>
        /// Return notifications about having been added to someone’s contact list
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of contact notifications</returns>
        public ESIResponse<List<GetContactNotificationsResponse>> GetContactNotifications(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/notifications/contacts/", authToken);

            return _client.Execute<List<GetContactNotificationsResponse>>(request);
        }

        /// <summary>
        /// Get portrait urls for a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Public data for the given character</returns>
        public ESIResponse<GetCharacterPortraitResponse> GetCharacterPortrait(Int64 characterId)
        {
            var request = RestRequestHelper.CreateGetRequest($"characters/{characterId}/portrait/");

            return _client.Execute<GetCharacterPortraitResponse>(request);
        }

        /// <summary>
        /// Returns a character’s corporation roles
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>The character’s roles in thier corporation</returns>
        public ESIResponse<List<GetCharacterRolesResponse>> GetCharacterRoles(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/roles/", authToken);

            return _client.Execute<List<GetCharacterRolesResponse>>(request);
        }

        /// <summary>
        /// Return character standings from agents, NPC corporations, and factions
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of standings</returns>
        public ESIResponse<List<GetCharacterStandingsResponse>> GetCharacterStandings(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/standings/", authToken);

            return _client.Execute<List<GetCharacterStandingsResponse>>(request);
        }

        /// <summary>
        /// Returns aggregate yearly stats for a character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Character stats</returns>
        public ESIResponse<List<GetCharacterStatsResponse>> GetCharacterStats(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/stats/", authToken);

            return _client.Execute<List<GetCharacterStatsResponse>>(request);
        }

        /// <summary>
        /// Returns a character’s titles
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of titles</returns>
        public ESIResponse<List<GetCharacterTitlesResponse>> GetCharacterTitles(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/titles/", authToken);

            return _client.Execute<List<GetCharacterTitlesResponse>>(request);
        }

        /// <summary>
        /// Bulk lookup of character IDs to corporation, alliance and faction
        /// </summary>
        /// <param name="characterIds">The character IDs to fetch affiliations for. All characters must exist, or none will be returned.</param>
        /// <returns>Character corporation, alliance and faction IDs</returns>
        public ESIResponse<List<GetcharacterAffiliationsResponse>> GetcharacterAffiliations(Int64[] characterIds)
        {
            var request = RestRequestHelper.CreatePostRequest($"characters/affiliation/");
            request.AddBody(characterIds);

            return _client.Execute<List<GetcharacterAffiliationsResponse>>(request);
        }

        /// <summary>
        /// Resolve a set of character IDs to character names
        /// </summary>
        /// <param name="characterIds">list of character IDs</param>
        /// <returns>List of id/name associations</returns>
        public ESIResponse<List<GetCharacterNamesResponse>> GetCharacterNames(Int64[] characterIds)
        {
            var request = RestRequestHelper.CreateGetRequest($"characters/names/");
            request.AddQueryParameter("character_ids", string.Join(",", characterIds));

            return _client.Execute<List<GetCharacterNamesResponse>>(request);
        }
    }
}