using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Bookmarks;
using RestSharp;
using System;
using System.Collections.Generic;

namespace EveESIClient.Bookmarks
{
    public class BookmarksClient
    {
        private readonly IHttpClient _client;

        internal BookmarksClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// A list of your character’s personal bookmarks
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of bookmarks</returns>
        public ESIResponse<List<GetPersonalBookmarksResponse>> GetPersonalBookmarks(string authToken, Int64 characterId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/bookmarks/",
                    authToken);

            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetPersonalBookmarksResponse>>(request);
        }

        /// <summary>
        /// A list of your character’s personal bookmark folders
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns></returns>
        public ESIResponse<List<GetPersonalBookmarkFoldersResponse>> GetPersonalBookmarkFolders(string authToken, Int64 characterId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/bookmarks/folders/",
                    authToken);

            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetPersonalBookmarkFoldersResponse>>(request);
        }

        /// <summary>
        ///A list of your corporation’s bookmarks
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of bookmarks</returns>
        public ESIResponse<List<GetCorporationBookmarksResponse>> GetCorporationBookmarks(string authToken, Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/bookmarks/",
                    authToken);

            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationBookmarksResponse>>(request);
        }

        /// <summary>
        /// A list of your corporation’s bookmark folders
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns></returns>
        public ESIResponse<List<GetCorporationBookmarkFoldersResponse>> GetCorporationBookmarkFolders(string authToken, Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/bookmarks/folders/",
                    authToken);

            request.AddParameter("page", page, ParameterType.QueryString);

            return _client.Execute<List<GetCorporationBookmarkFoldersResponse>>(request);
        }
    }
}