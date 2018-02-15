using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Fleets;
using System;
using System.Collections.Generic;

namespace EveESIClient.Fleets
{
    public class FleetsClient
    {
        private readonly IHttpClient _httpClient;
        internal FleetsClient(IHttpClient client)
        {
            _httpClient = client;
        }

        /// <summary>
        /// Return the fleet ID the character is in, if any.
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Details about the character’s fleet</returns>
        public ESIResponse<GetCharacterFleetInfoResponse> GetCharacterFleetInfo(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/fleet/", authToken);

            return _httpClient.Execute<GetCharacterFleetInfoResponse>(request);
        }

        /// <summary>
        /// Return details about a fleet
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <returns>Details about a fleet</returns>
        public ESIResponse<GetFleetInformationResponse> GetFleetInformation(string authToken, Int64 fleetId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"fleets/{fleetId}/", authToken);

            return _httpClient.Execute<GetFleetInformationResponse>(request);
        }

        /// <summary>
        /// Update settings about a fleet
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="motd">New fleet MOTD in CCP flavoured HTML</param>
        /// <param name="isFreeMove">Should free-move be enabled in the fleet</param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> UpdateFleet(string authToken, Int64 fleetId, string motd, bool? isFreeMove)
        {
            var request = RestRequestHelper.CreateAuthorizedPutRequest($"fleets/{fleetId}/", authToken);
            request.AddJsonBody(new { motd, is_free_move = isFreeMove });

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Return information about fleet members
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <returns>A list of fleet members</returns>
        public ESIResponse<List<GetFleetMembersResponse>> GetFleetMembers(string authToken, Int64 fleetId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"fleets/{fleetId}/members/", authToken);

            return _httpClient.Execute<List<GetFleetMembersResponse>>(request);
        }

        /// <summary>
        /// Invite a character into the fleet. If a character has a CSPA charge set it is not possible to invite them to the fleet using ESI
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="characterId">The character you want to invite</param>
        /// <param name="role">
        /// If a character is invited with the fleet_commander role, neither wing_id or squad_id should be specified. 
        /// If a character is invited with the wing_commander role, only wing_id should be specified.
        /// If a character is invited with the squad_commander role, both wing_id and squad_id should be specified. 
        /// If a character is invited with the squad_member role, wing_id and squad_id should either both be specified or not specified at all. 
        /// If they aren’t specified, the invited character will join any squad with available positions.</param>
        /// <param name="wingId"></param>
        /// <param name="squadId"></param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> CreateFleetInvitation(string authToken, Int64 fleetId, int characterId, string role, Int64? wingId, Int64? squadId)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"fleets/{fleetId}/members/", authToken);
            request.AddJsonBody(new { character_id = characterId, role, wing_id = wingId, squad_id = squadId });

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Kick a fleet member
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="characterId">The character ID of a member in this fleet</param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> KickFleetMember(string authToken, Int64 fleetId, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedDeleteRequest($"fleets/{fleetId}/members/{characterId}/", authToken);

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Move a fleet member around
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="characterId">The character ID of a member in this fleet</param>
        /// <param name="role">
        /// If a character is moved to the fleet_commander role, neither wing_id or squad_id should be specified. 
        /// If a character is moved to the wing_commander role, only wing_id should be specified.
        /// If a character is moved to the squad_commander role, both wing_id and squad_id should be specified. 
        /// If a character is moved to the squad_member role, both wing_id and squad_id should be specified.
        /// </param>
        /// <param name="wingId"></param>
        /// <param name="squadId"></param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> MoveFleetMember(string authToken, Int64 fleetId, int characterId, string role, Int64? wingId, Int64? squadId)
        {
            var request = RestRequestHelper.CreateAuthorizedPutRequest($"fleets/{fleetId}/members/{characterId}/", authToken);
            request.AddJsonBody(new { role, wing_id = wingId, squad_id = squadId });

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Delete a fleet squad, only empty squads can be deleted
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="squadId">The squad to delete</param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> DeleteFleetSquad(string authToken, Int64 fleetId, Int64 squadId)
        {
            var request = RestRequestHelper.CreateAuthorizedDeleteRequest($"fleets/{fleetId}/squads/{squadId}/", authToken);

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Rename a fleet squad
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="squadId">The squad to rename</param>
        /// <param name="name">new squad name</param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> RenameFleetSquad(string authToken, Int64 fleetId, Int64 squadId, string name)
        {
            var request = RestRequestHelper.CreateAuthorizedPutRequest($"fleets/{fleetId}/squads/{squadId}/", authToken);
            request.AddJsonBody(new { name });

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Return information about wings in a fleet
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <returns>A list of fleet wings</returns>
        public ESIResponse<List<GetFleetWingsResponse>> GetFleetWings(string authToken, Int64 fleetId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"fleets/{fleetId}/wings/", authToken);

            return _httpClient.Execute<List<GetFleetWingsResponse>>(request);
        }

        /// <summary>
        /// Create a new wing in a fleet
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <returns>Wing created</returns>
        public ESIResponse<CreateFleetWingResponse> CreateFleetWing(string authToken, Int64 fleetId)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"fleets/{fleetId}/wings/", authToken);

            return _httpClient.Execute<CreateFleetWingResponse>(request);
        }

        /// <summary>
        /// Delete a fleet wing, only empty wings can be deleted. The wing may contain squads, but the squads must be empty
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="wingId">The wing to delete</param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> DeleteFleetWing(string authToken, Int64 fleetId, Int64 wingId)
        {
            var request = RestRequestHelper.CreateAuthorizedDeleteRequest($"fleets/{fleetId}/wings/{wingId}/", authToken);

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Rename a fleet wing
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="wingId">The wing to delete</param>
        /// <param name="name">New wing name</param>
        /// <returns>IsSuccessful will be true on a successful call</returns>
        public ESIResponse<object> RenameFleetWing(string authToken, Int64 fleetId, Int64 wingId, string name)
        {
            var request = RestRequestHelper.CreateAuthorizedPutRequest($"fleets/{fleetId}/wings/{wingId}/", authToken);
            request.AddJsonBody(new { name });

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Create a new squad in a fleet
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="fleetId">ID for a fleet</param>
        /// <param name="wingId">The wing_id to create squad in</param>
        /// <returns>Squad created</returns>
        public ESIResponse<CreateFleetSquadResponse> CreateFleetSquad(string authToken, Int64 fleetId, Int64 wingId)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"fleets/{fleetId}/wings/{wingId}/squads/", authToken);

            return _httpClient.Execute<CreateFleetSquadResponse>(request);
        }
    }
}
