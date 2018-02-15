using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Contacts;
using RestSharp;
using System;
using System.Collections.Generic;

namespace EveESIClient.Contacts
{
    public class ContactsClient
    {
        private readonly IHttpClient _client;

        internal ContactsClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Return contacts of an alliance
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of contacts</returns>
        public ESIResponse<List<GetAllianceContactsResponse>> GetAllianceContacts(string authToken, Int64 allianceId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"alliances/{allianceId}/contacts/", authToken);

            return _client.Execute<List<GetAllianceContactsResponse>>(request);
        }

        /// <summary>
        /// Bulk delete contacts
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">A list of contacts to delete</param>
        /// <returns>IsSuccessful will be true on successfull call</returns>
        public ESIResponse<object> DeleteCharacterContacts(string authToken, Int64 characterId, Int64[] contactIds)
        {
            var request = RestRequestHelper.CreateAuthorizedDeleteRequest($"characters/{characterId}/contacts/", authToken);
            request.AddParameter("contact_ids", contactIds, ParameterType.QueryString);

            return _client.Execute<object>(request);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="authToken"></param>
        /// <param name="characterId"></param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns></returns>
        public ESIResponse<List<GetCharacterContactsResponse>> GetCharacterContacts(string authToken, Int64 characterId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/contacts/", authToken);

            return _client.Execute<List<GetCharacterContactsResponse>>(request);
        }

        /// <summary>
        /// Bulk add contacts with same settings
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">A list of contacts to add</param>
        /// <param name="standing">Standing for the new contact</param>
        /// <param name="labelId">Add a custom label to the new contact</param>
        /// <param name="watched">Whether the new contact should be watched, note this is only effective on characters</param>
        /// <returns>A list of contact ids that successfully created</returns>
        public ESIResponse<List<Int64>> AddContacts(string authToken, Int64 characterId, Int64[] contactIds, float standing, int? labelId, bool? watched)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"characters/{characterId}/contacts/", authToken);
            request.AddParameter("standing", standing, ParameterType.QueryString);
            request.AddParameter("label_id", labelId, ParameterType.QueryString);
            request.AddParameter("watched", watched, ParameterType.QueryString);
            request.AddBody(contactIds);

            return _client.Execute<List<Int64>>(request);
        }

        /// <summary>
        /// Bulk edit contacts with same settings
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contactIds">A list of contacts to add</param>
        /// <param name="standing">Standing for the new contact</param>
        /// <param name="labelId">Add a custom label to the new contact</param>
        /// <param name="watched">Whether the new contact should be watched, note this is only effective on characters</param>
        /// <returns>IsSuccessful will be true on successfull call</returns>
        public ESIResponse<object> UpdateContacts(string authToken, Int64 characterId, Int64[] contactIds, float standing, int? labelId, bool? watched)
        {
            var request = RestRequestHelper.CreateAuthorizedPutRequest($"characters/{characterId}/contacts/", authToken);
            request.AddParameter("standing", standing, ParameterType.QueryString);
            request.AddParameter("label_id", labelId, ParameterType.QueryString);
            request.AddParameter("watched", watched, ParameterType.QueryString);
            request.AddBody(contactIds);

            return _client.Execute<object>(request);
        }

        /// <summary>
        /// Return custom labels for contacts the character defined
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of contact labels</returns>
        public ESIResponse<List<GetContactLabelsResponse>> GetContactLabels(string authToken, Int64 characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/contacts/labels/", authToken);

            return _client.Execute<List<GetContactLabelsResponse>>(request);
        }

        /// <summary>
        /// Return contacts of a corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of contacts</returns>
        public ESIResponse<List<GetCorporationContactsResponse>> GetCorporationContacts(string authToken, Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/contacts/", authToken);

            return _client.Execute<List<GetCorporationContactsResponse>>(request);
        }
    }
}